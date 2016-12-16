/** \file
* \$Rev: 140 $
* 
* \$Date: 2012-02-18 16:41:11 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/WaveformFormat.cs $
*/

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace BenfWaves.Library
{
	/// <summary>
	/// A format to which a waveform can be saved.
	/// </summary>
	public abstract class WaveformFormat
	{
		/// <summary>
		/// The list of all waveform formats.
		/// </summary>
		public static readonly List<WaveformFormat> Formats =
			new List<WaveformFormat>
		{
			new XmlFormat(),
			new TSVFormat(),
			new CSVFormat(),
			new ExcelFormat(),
			new MatlabFormat(),
			new GnuplotFormat(),
			new RenderedFormat(ImageFormat.Bmp, "bmp", "Bitmap"),
			new RenderedFormat(ImageFormat.Gif, "gif", "GIF"),
			new RenderedFormat(ImageFormat.Jpeg, "jpg", "JPEG"),
			new RenderedFormat(ImageFormat.Png, "png", "PNG"),
			new RenderedFormat(ImageFormat.Tiff, "tiff", "TIFF")
		};

		/// <summary>
		/// All filter strings concatenated, for use in Windows Forms save and
		/// load dialogues.
		/// </summary>
		public static string AllFilters
		{
			get
			{
				return string.Join("|", Formats.ConvertAll( 
					format => format.Filter).ToArray());
			}
		}

		/// <summary>The file extension for this format.</summary>
		public abstract string Extension { get; }

		/// <summary>A description for this format.</summary>
		public abstract string Description { get; }

		/// <summary>
		/// The filter string to use for open and save dialogues.
		/// </summary>
		public string Filter
		{
			get
			{
				return Description + " files (*." + Extension + ")|*." +
					Extension;
			}
		}

		/// <summary>Save a waveform to a stream.</summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="writer">The stream writer to write to.</param>
		public virtual void Save(Waveform waveform, StreamWriter writer)
		{
			throw new NotImplementedException();
		}

		/// <summary>Save a waveform to a file.</summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="filename">The name of the file to save to.</param>
		public virtual void Save(Waveform waveform, string filename)
		{
			FileStream stream = new FileStream(filename,
				FileMode.Create, FileAccess.Write);
			StreamWriter writer = new StreamWriter(stream);
			using (stream)
			using (writer)
				Save(waveform, writer);
			waveform.Profile.filename = filename;
		}
	}

	/// <summary>
	/// A format based off of a template text file in a resource.
	/// </summary>
	public abstract class TemplatedFormat : WaveformFormat
	{
		/// <summary>
		/// The parsing regex, used to extract property names from templates.
		/// </summary>
		static readonly Regex parser =
			new Regex("{(?<property>[^{}]+)}", RegexOptions.Compiled);

		/// <summary>
		/// The name of the resource containing the template text for this
		/// format.
		/// </summary>
		protected abstract string TemplateResourceName { get; }

		/// <summary>
		/// The template text for this format, containing property
		/// placeholders.
		/// </summary>
		string Template
		{
			get
			{
				System.Resources.ResourceManager manager =
					Properties.Resources.ResourceManager;
				return (string)manager.GetObject(TemplateResourceName);
			}
		}

		/// <summary>Replace a template token.</summary>
		/// <param name="token">The token string.</param>
		/// <param name="waveform">
		/// The waveform from which data should be taken.
		/// </param>
		/// <returns>The replacement text.</returns>
		protected virtual string ReplaceToken(string token, Waveform waveform)
		{
			if (token == "TemplateProfile")
				return Replace(Properties.Resources.TemplateProfile, waveform);
			return PropertyExtractor.Extract(token, waveform);
		}

		/// <summary>
		/// Replace {tokens} in a template string with data from a waveform.
		/// </summary>
		/// <param name="text">The template string.</param>
		/// <param name="waveform">
		/// The waveform from which properties will be acquired.
		/// </param>
		/// <returns>The template string, with {tokens} replaced.</returns>
		protected string Replace(string text, Waveform waveform)
		{
			return parser.Replace(text, match =>
				ReplaceToken(match.Groups["property"].Value, waveform)
			);
		}

		/// <summary>
		/// Save a waveform to a stream.
		/// </summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="writer">The stream writer to write to.</param>
		public override void Save(Waveform waveform, StreamWriter writer)
		{
			string newtext = Replace(Template, waveform);
			writer.Write(newtext);
		}
	}

	/// <summary>The DSO Nano XML format.</summary>
	public class XmlFormat : WaveformFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "xml"; } }

		/// <summary>A description for this format.</summary>
		public override string Description { get { return "DSO Nano XML"; } }

		/// <summary>
		/// Save a waveform to a stream.
		/// </summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="writer">The stream writer to write to.</param>
		public override void Save(Waveform waveform, StreamWriter writer)
		{
			waveform.ToXMLStream(writer);
		}
	}

	/// <summary>
	/// A format for a Matlab/Octave script containing the data and a basic
	/// graph routine.
	/// </summary>
	public class MatlabFormat : TemplatedFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "m"; } }

		/// <summary>A description for this format.</summary>
		public override string Description
		{
			get { return "Matlab/Octave script"; }
		}

		/// <summary>
		/// The name of the resource containing the template text for this format.
		/// </summary>
		protected override string TemplateResourceName
		{
			get { return "MatlabTemplate"; }
		}

		/// <summary>
		/// Replace a template token.
		/// </summary>
		/// <param name="token">The token string.</param>
		/// <param name="waveform">
		/// The waveform from which data should be taken.
		/// </param>
		/// <returns>The replacement text.</returns>
		protected override string ReplaceToken(string token, Waveform waveform)
		{
			string result = base.ReplaceToken(token, waveform);
			if (result != null)
				return result;
			if (token != "DataLines")
				return null;
			result = "";
			int column = 0;
			foreach (Point point in waveform.Point)
			{
				result += point.val + ";";
				if (++column == 10)
				{
					column = 0;
					result += "\n";
				}
				else
					result += "\t";
			}
			return result;
		}
	}

	/// <summary>A Gnuplot script format.</summary>
	public class GnuplotFormat : TemplatedFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "plt"; } }

		/// <summary>A description for this format.</summary>
		public override string Description { get { return "Gnuplot script"; } }

		/// <summary>
		/// The name of the resource containing the template text for this
		/// format.
		/// </summary>
		protected override string TemplateResourceName
		{
			get { return "GnuplotTemplate"; }
		}

		/// <summary>Replace a template token.</summary>
		/// <param name="token">The token string.</param>
		/// <param name="waveform">
		/// The waveform from which data should be taken.
		/// </param>
		/// <returns>The replacement text.</returns>
		protected override string ReplaceToken(string token, Waveform waveform)
		{
			string result = base.ReplaceToken(token, waveform);
			if (result != null)
				return result;
			if (token != "DataLines")
				return null;
			return string.Join(Environment.NewLine,
				Array.ConvertAll(waveform.Point, p =>
					p.val.ToString(CultureInfo.InvariantCulture)));
		}
	}

	/// <summary>A simple string-delimited format.</summary>
	public abstract class DelimitedFormat : WaveformFormat
	{
		/// <summary>The string to add between columns in the file.</summary>
		public abstract string Delimiter { get; }

		/// <summary>
		/// Save a waveform to a stream.
		/// </summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="writer">The stream writer to write to.</param>
		public override void Save(Waveform waveform, StreamWriter writer)
		{
			writer.WriteLine(
				"Series index" + Delimiter + "Time" + Delimiter + "Voltage");

			foreach (Point p in waveform.Point)
				writer.WriteLine(
					p.seq + Delimiter +
					p.TimeDouble + Delimiter +
					p.val);
		}
	}

	/// <summary>A simple tab-separated value format.</summary>
	public class TSVFormat : DelimitedFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "tsv"; } }

		/// <summary>A description for this format.</summary>
		public override string Description
		{
			get { return "Tab-separated value"; }
		}

		/// <summary>The string to add between columns in the file.</summary>
		public override string Delimiter { get { return "\t"; } }
	}

	/// <summary>A simple comma-separated value format.</summary>
	public class CSVFormat : DelimitedFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "csv"; } }

		/// <summary>A description for this format.</summary>
		public override string Description
		{
			get { return "Comma-separated value"; }
		}

		/// <summary>The string to add between columns in the file.</summary>
		public override string Delimiter { get { return ","; } }
	}

	/// <summary>
	/// A format representing Microsoft Excel spreadsheets.
	/// </summary>
	public class ExcelFormat : WaveformFormat
	{
		/// <summary>The file extension for this format.</summary>
		public override string Extension { get { return "xls"; } }

		/// <summary>A description for this format.</summary>
		public override string Description
		{
			get { return "Microsoft Excel spreadsheet"; }
		}

		/// <summary>Check whether the current process is 64-bit.</summary>
		public static bool Is64BitProcess
		{
			get { return IntPtr.Size == 8; }
		}

		/// <summary>Save a waveform to a file.</summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="filename">The name of the file to save to.</param>
		public override void Save(Waveform waveform, string filename)
		{
			// Write an internal XLS template resource to the file first.
			WriteTemplate(filename);

			// Use the Jet OLE DB facility to connect to the XLS file as a
			// database.
			OleDbConnectionStringBuilder connbuilder =
				new OleDbConnectionStringBuilder();
			connbuilder.DataSource = filename;
            connbuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
			connbuilder.Add("Extended Properties", "Excel 8.0");

			OleDbConnection conn = new OleDbConnection(connbuilder.ConnectionString);
			using (conn)
			{
				try { conn.Open(); }
				catch (InvalidOperationException e)
				{
					if (Is64BitProcess)
						throw new ApplicationException(
							"Excel export currently will not work because " +
							"this is a 64-bit process.", e);
					throw;
				}

				DataContext context = new DataContext(conn);
				using (context)
				{
					Table<Profile> tprofile = context.GetTable<Profile>();
					tprofile.InsertOnSubmit(waveform.Profile);

					Table<Point> tpoint = context.GetTable<Point>();
					tpoint.InsertAllOnSubmit(waveform.Point);

					context.SubmitChanges();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Write out the Excel template resource to a file, overwriting it if
		/// it already exists.
		/// </summary>
		/// <param name="filename">The name of the file to write.</param>
		void WriteTemplate(string filename)
		{
			FileStream stream = new FileStream(filename,
				FileMode.Create, FileAccess.Write);
			using (stream)
				stream.Write(
					Properties.Resources.ExcelTemplate, 0,
					Properties.Resources.ExcelTemplate.Length);
		}
	}

	/// <summary>
	/// A rendered image format. This requires external rendering code.
	/// </summary>
	public class RenderedFormat : WaveformFormat
	{
		/// <summary>
		/// A delegate that must be initialized before attempting to save any
		/// images. It accepts a waveform and returns a rendered bitmap. It's
		/// done this way to keep the format code in the library but decouple
		/// the UI, since rendering is done in the UI.
		/// </summary>
		public static Func<Waveform, Bitmap> WaveformToBitmap;

		/// <summary>
		/// The type of image that will be saved.
		/// </summary>
		readonly ImageFormat format;

		/// <summary>The file extension for this format.</summary>
		readonly string extension;

		/// <summary>A description for this format.</summary>
		readonly string description;

		/// <summary>The file extension for this format.</summary>
		public override string Extension
		{
			get { return extension; }
		}

		/// <summary>A description for this format.</summary>
		public override string Description
		{
			get { return description + " image"; }
		}

		/// <summary>Save a waveform to a file.</summary>
		/// <param name="waveform">The waveform to save.</param>
		/// <param name="filename">The name of the file to save to.</param>
		public override void Save(Waveform waveform, string filename)
		{
			Bitmap bitmap = WaveformToBitmap(waveform);
			bitmap.Save(filename, format);
		}

		/// <summary>
		/// Construct a new rendered image format.
		/// </summary>
		/// <param name="format">The type of image that will be saved.</param>
		/// <param name="extension">The image file extension.</param>
		/// <param name="description">The image file description string.</param>
		public RenderedFormat(ImageFormat format, string extension, string description)
		{
			this.format = format;
			this.extension = extension;
			this.description = description;
		}
	}
}
