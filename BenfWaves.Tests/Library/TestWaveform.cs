/** \file
* \$Rev: 149 $
* 
* \$Date: 2013-11-20 22:05:05 +0000 (Wed, 20 Nov 2013) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Tests/Library/TestWaveform.cs $
*/

using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>The namespace containing all unit tests for the library.</summary>
namespace BenfWaves.Library.Tests
{
	/// <summary>Tests for the Waveform class.</summary>
	[TestClass]
	public class TestWaveform
	{
		/// <summary>All of the sample XML file names.</summary>
		static string[] XmlFiles =
			Directory.GetFiles(samplesDir, "*.xml");

		/// <summary>
		/// The directory to search for XML input files.
		/// </summary>
		const string samplesDir = @"..\..\..\Samples\";
		
		/// <summary>
		/// The directory to output serialized waveforms.
		/// </summary>
		const string serializedDir = "Serialized";

		/// <summary>
		/// Test that the waveform can serialize to a file properly.
		/// </summary>
		[TestMethod]
		public void Serialize()
		{
			// Test that each sample XML file can serialize to each format.
			// Put each different file in its own thread.

			Directory.CreateDirectory(serializedDir);
			List<Thread> threads = new List<Thread>();
			foreach (string filein in XmlFiles)
			{
				Thread serthread = new Thread(SerializeThreadProc);
				threads.Add(serthread);
				serthread.Name = "TestWaveform.SerializeThreadProc(" + filein + ")";
				serthread.Start(filein);
			}
			foreach (Thread serthread in threads)
				serthread.Join();
		}

		/// <summary>
		/// The thread procedure to parallelize a serialization test on each
		/// sample XML file.
		/// </summary>
		/// <param name="parameter">The input XML file name.</param>
		public void SerializeThreadProc(object parameter)
		{
			string filein = (string)parameter;
			FileInfo ininfo = new FileInfo(filein);
			Waveform wave = Waveform.FromXMLFile(filein);
			foreach (WaveformFormat format in WaveformFormat.Formats)
			{
				if (format is RenderedFormat)
					continue;
				string fileout = Path.Combine(
					serializedDir, ininfo.Name + ".test." + format.Extension);
				format.Save(wave, fileout);
				Assert.IsTrue(File.Exists(fileout));
				FileInfo fileoutinfo = new FileInfo(fileout);
				Assert.IsTrue(fileoutinfo.Length > 0);
			}
		}

		/// <summary>
		/// Test that the waveform can deserialize from a file properly.
		/// </summary>
		[TestMethod]
		public void Deserialize()
		{
			// Test that each sample XML file can be deserialized.

			foreach (string filename in XmlFiles)
			{
				Waveform wave = Waveform.FromXMLFile(filename);
				Assert.IsNotNull(wave);
				Assert.IsNotNull(wave.Profile);
				Assert.IsNotNull(wave.Point);
				Assert.IsTrue(wave.Point.Length > 1);
			}
		}

	}
}
