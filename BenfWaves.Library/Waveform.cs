﻿/** \file
* \$Rev: 141 $
* 
* \$Date: 2012-02-18 16:47:41 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/Waveform.cs $
*/

using System;
using System.Data.Linq.Mapping;
using System.IO;
using System.Xml.Serialization;

/// <summary>
/// The library containing conversion, serialization and file operations for
/// the BenF XML waveform format.
/// </summary>
namespace BenfWaves.Library
{
	/// <summary>A single waveform.</summary>
	[XmlRoot("Document")]
	public class Waveform
	{
		/// <summary>The XML serializer for this class.</summary>
		static XmlSerializer serializer = new XmlSerializer(typeof(Waveform));

		/// <summary>All attributes of the waveform.</summary>
		public Profile Profile { get; set; }

		/// <summary>The list of waveform data points.</summary>
		[XmlElement]
		public Point[] Point { get; set; }

		/// <summary>The first sample index in the waveform.</summary>
		[XmlIgnore]
		public int FirstIndex { get { return Point[0].seq; } }

		/// <summary>The last sample index in the waveform.</summary>
		[XmlIgnore]
		public int LastIndex { get { return Point[Point.Length - 1].seq; } }

		/// <summary>
		/// The series of voltages as a function of time.
		/// </summary>
		[XmlIgnore]
		public Series Voltages;
	
		/// <summary>
		/// Construct a Waveform by reading an XML file.
		/// </summary>
		/// <param name="filename">The name of the file to read.</param>
		/// <returns>The new WaveForm instance.</returns>
		public static Waveform FromXMLFile(string filename)
		{
			FileStream file = new FileStream(filename,
				FileMode.Open, FileAccess.Read);
			using (file)
			{
				Waveform newwave = (Waveform)serializer.Deserialize(file);
				newwave.Profile.filename = filename;
				newwave.Profile.parent = newwave;

				int seq = newwave.FirstIndex;
				foreach (Point point in newwave.Point)
				{
					if (point.seq != seq)
						throw new InvalidDataException(
							"The waveform data points are not contiguous.");
					seq++;
					point.Parent = newwave;
				}
				newwave.InitSeries();
				return newwave;
			}
		}

		/// <summary>
		/// Save this Waveform to an XML file.
		/// </summary>
		/// <param name="writer">The stream writer to write to.</param>
		public void ToXMLStream(TextWriter writer)
		{
			serializer.Serialize(writer, this);
		}

		/// <summary>
		/// Initialize the series data.
		/// </summary>
		void InitSeries()
		{
			VertSeriesDimension dimVoltage = new VertSeriesDimension();
			dimVoltage.GetUnitStart = () => -Profile.vdiffMaxDouble;
			dimVoltage.GetUnitRange = () => Profile.vdiffMaxDouble * 2;
			dimVoltage.GetNewSIValue = () => new SIVoltage();

			HorzSeriesDimension dimTime = new HorzSeriesDimension();
			dimTime.GetUnitStart = () => Profile.timeStart.Value;
			dimTime.GetUnitRange = () => Profile.timeRangeDouble;
			dimTime.GetNewSIValue = () => new SITime();

			Voltages = new Series(
				Array.ConvertAll(Point, p => p.val),
				dimTime, dimVoltage);
		}
	}

	/// <summary>A single data point in the waveform.</summary>
	[Table(Name = "Data_Raw$")]
	public class Point
	{
		/// <summary>The waveform to which this point belongs.</summary>
		[XmlIgnore]
		public Waveform Parent { get; set; }

		/// <summary>The index of the data point.</summary>
		[Column(IsPrimaryKey = true)]
		public int seq { get; set; }

		/// <summary>The value of the data point.</summary>
		[Column]
		public double val { get; set; }

		/// <summary>
		/// The time of this point, relative to the trigger index. Formatted
		/// as an SI quantity.
		/// </summary>
		[XmlIgnore]
		public SITime Time
		{
			get { return new SITime(TimeDouble); }
		}

		/// <summary>
		/// The time of this point, relative to the trigger index.
		/// </summary>
		[XmlIgnore]
		public double TimeDouble
		{
			get
			{
				return (seq - Parent.Profile.triggerIndex) /
					Parent.Profile.samplingFreq.Value;
			}
		}

		/// <summary>
		/// The voltage at this point, as an SI quantity.
		/// </summary>
		[XmlIgnore]
		public SIVoltage Voltage { get { return new SIVoltage(val); } }

		/// <summary>
		/// The parameterless constructor.
		/// </summary>
		public Point() { }

		/// <summary>
		/// A constructor for immediate initialization.
		/// </summary>
		/// <param name="seq">The point index.</param>
		/// <param name="val">The point voltage.</param>
		public Point(int seq, double val)
		{
			this.seq = seq;
			this.val = val;
		}
	}
}
