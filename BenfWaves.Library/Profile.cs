/** \file
* \$Rev: 140 $
* 
* \$Date: 2012-02-18 16:41:11 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/Profile.cs $
*/

using System;
using System.Data.Linq.Mapping;
using System.Globalization;
using System.Xml.Serialization;

namespace BenfWaves.Library
{
	/// <summary>
	/// The characteristics of a waveform.
	/// This is annotated for both Linq mapping (Table, Column) for Excel
	/// export and XmlSerializer (XmlIgnore, XmlElement).
	/// </summary>
	[Table(Name = "Profile_Raw$")]
	public class Profile
	{
		/// <summary>
		/// At time divs at or below this quantity, the scope operates in fast
		/// sampling mode only.
		/// </summary>
		public const double fastTimeLimit = 20e-6;

		/// <summary>The attenuation of the signal</summary>
		[XmlIgnore]
		[Column]
		public double attenuationDouble { get; set; }

		/// <summary>
		/// The attenuation of the signal, formatted as a string beginning with
		/// "x"
		/// </summary>
		[XmlElement("attenuation")]
		public string attenuationString
		{
			get { return "x" + attenuationDouble.ToString(CultureInfo.InvariantCulture); }
			set
			{
				if (value[0] != 'x')
					throw new ArgumentException();
				attenuationDouble = double.Parse(value.Substring(1), 
					CultureInfo.InvariantCulture);
			}
		}

		/// <summary>
		/// The total number of divisions visible in the waveform.
		/// </summary>
		[XmlIgnore]
		public double divRange
		{
			get { return timeRangeDouble / timeDivDouble; }
		}

		/// <summary>
		/// Whether the scope is in fast sampling mode.
		/// </summary>
		[XmlIgnore]
		public FastSamplingMode fastSamplingModeEnum
		{
			get
			{
				// For older firmware, this check is necessary
				if (sampleDiv == null)
				{
					// This is derived from the specsheet
					double expectedFreq = 25 / timeDivSI.Value;
					if (samplingFreq.Value > expectedFreq)
						return FastSamplingMode.Enabled;
				}
				// This is applicable to V3.61+
				else
				{
					if (sampleDiv.Value < timeDivSI.Value)
						return FastSamplingMode.Enabled;
				}
				if (timeDivSI.Value <= fastTimeLimit)
					return FastSamplingMode.DisabledByTimescale;
				return FastSamplingMode.Disabled;
			}
			set { }
		}

		/// <summary>
		/// Whether the scope is in fast sampling mode. Formatted as a string.
		/// </summary>
		[XmlIgnore]
		[Column]
		public string fastSamplingModeString
		{
			get { return fastSamplingModeEnum.ToString(); }
			set
			{
				fastSamplingModeEnum = (FastSamplingMode)
					Enum.Parse(typeof(FastSamplingMode), value);
			}
		}

		/// <summary>The file name on the SD card.</summary>
		[Column(IsPrimaryKey = true)]
		public string fileNumber { get; set; }

		/// <summary>
		/// The most recently accessed filename associated with this waveform.
		/// </summary>
		[XmlIgnore]
		[Column]
		public string filename { get; set; }

		/// <summary>The firmware version.</summary>
		[Column]
		public string firmware { get; set; }

		/// <summary>
		/// The horizontal sensitivity.
		/// </summary>
		[XmlIgnore]
		public SITime hsens
		{
			get { return new SITime(timeRangeDouble / sampleCount); }
		}

		/// <summary>The waveform corresponding to this profile.</summary>
		[XmlIgnore]
		public Waveform parent { get; set; }

		/// <summary>
		/// The DC input resistance, formatted as an SI quantity.
		/// </summary>
		[XmlIgnore]
		public SIResistance rinSI
		{
			get { return new SIResistance(rinDouble); }
			// set { rinDouble = value.Value; }
		}

		/// <summary>The DC input resistance.</summary>
		[Column]
		public double rinDouble
		{
			get { return VscaleProps.Rin; }
			set { }
		}

		/// <summary>The number of samples in this waveform.</summary>
		[Column]
		public int sampleCount { get; set; }

		/// <summary>
		/// "The sampleDiv entry is used by the XML import utility to
		/// distinguish between fast and standard buffer modes. timeDiv is as
		/// in previous versions the T/Div we select on the Nano (used for
		/// display scaling) whereas sampleDiv is the actual sampling rate used
		/// during acquisitions. They will be different when Fast mode is used,
		/// but have the same value for Post and Equal modes."
		/// 
		/// Note that this is not actually the number of samples per division!
		/// 
		/// This field is not present in the XML prior to firmware v3.61. As a
		/// result, this field is not displayed in any export data or on the
		/// form. If it is present, it is used to determine FastSamplingMode.
		/// </summary>
		public SITime sampleDiv { get; set; }

		/// <summary>
		/// This is the actual number of samples per division, calculated from
		/// the sampling frequency and the selected time scale.
		/// </summary>
		[XmlIgnore]
		public double samplesPerDiv
		{
			get { return samplingFreq.Value * timeDivSI.Value; }
		}

		/// <summary>The sampling frequency (calculated).</summary>
		[XmlIgnore]
		public SIFreq samplingFreq
		{
			get { return new SIFreq(sampleCount / timeRangeDouble); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>The time per horizontal division.</summary>
		[XmlElement("timeDiv")]
		public SITime timeDivSI
		{
			get { return new SITime(timeDivDouble); }
			set { timeDivDouble = value.Value; }
		}

		/// <summary>
		/// The time per horizontal division, formatted as a double.
		/// </summary>
		[XmlIgnore]
		[Column]
		public double timeDivDouble { get; set; }

		/// <summary>The time that this waveform covers.</summary>
		[Column]
		[XmlElement("timeRange")]
		public double timeRangeDouble { get; set; }

		/// <summary>The time range, as an SI quantity.</summary>
		[XmlIgnore]
		public SITime timeRangeSI
		{
			get { return new SITime(timeRangeDouble); }
			set { timeRangeDouble = value.Value; }
		}

		/// <summary>
		/// The time (relative to the trigger) at which the waveform starts.
		/// </summary>
		[XmlIgnore]
		public SITime timeStart
		{
			get
			{
				return new SITime(
					(parent.FirstIndex - triggerIndex) /
					samplingFreq.Value);
			}
		}

		/// <summary>
		/// The trigger kind of the waveform (rising or falling).
		/// </summary>
		[XmlElement("triggerKind")]
		public TriggerKind triggerKindEnum { get; set; }

		/// <summary>
		/// The trigger kind of the waveform (rising or falling). Formatted as
		/// a string.
		/// </summary>
		[XmlIgnore]
		[Column]
		public string triggerKindString
		{
			get { return triggerKindEnum.ToString(); }
			set
			{
				triggerKindEnum = (TriggerKind)
				Enum.Parse(typeof(TriggerKind), value);
			}
		}

		/// <summary>The high side of the trigger range.</summary>
		[XmlIgnore]
		public SIVoltage triggerHigh
		{
			get
			{
				return new SIVoltage(
					triggerLevelSI.Value + triggerSensSI.Value);
			}
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// The index at which this trigger capture was started.
		/// </summary>
		[Column]
		public int triggerIndex { get; set; }

		/// <summary>The trigger level, in volts.</summary>
		[XmlElement("triggerLevel")]
		public SIVoltage triggerLevelSI { get; set; }

		/// <summary>
		/// The trigger level, in volts. Formatted as a double.
		/// </summary>
		[Column]
		public double triggerLevelDouble
		{
			get { return triggerLevelSI.Value; }
			set { } // triggerLevelSI = new SIVoltage(value); }
		}

		/// <summary>The low side of the trigger range.</summary>
		[XmlIgnore]
		public SIVoltage triggerLow
		{
			get
			{
				return new SIVoltage(
					triggerLevelSI.Value - triggerSensSI.Value);
			}
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// The trigger mode of the waveform (normal, auto or single).
		/// </summary>
		[XmlElement("triggerMode")]
		public TriggerMode triggerModeEnum { get; set; }

		/// <summary>
		/// The trigger mode of the waveform (normal, auto or single).
		/// Formatted as a string.
		/// </summary>
		[XmlIgnore]
		[Column]
		public string triggerModeString
		{
			get { return triggerModeEnum.ToString(); }
			set
			{
				triggerModeEnum = (TriggerMode)Enum.Parse(
					typeof(TriggerMode), value);
			}
		}

		/// <summary>The trigger sensitivity, in volts.</summary>
		[XmlElement("triggerSensitivity")]
		public SIVoltage triggerSensSI { get; set; }

		/// <summary>The trigger sensitivity, in volts.</summary>
		[XmlIgnore]
		[Column]
		public double triggerSensDouble
		{
			get { return triggerSensSI.Value; }
			set { } // triggerSensSI = new SIVoltage(value); }
		}

		/// <summary>
		/// The maximum allowable differential voltage, formatted as an SI
		/// quantity.
		/// </summary>
		[XmlIgnore]
		public SIVoltage vdiffMaxSI
		{
			get { return new SIVoltage(vdiffMaxDouble); }
			// set { vdiffMaxDouble = value.Value; }
		}

		/// <summary>
		/// The maximum allowable differential voltage.
		/// </summary>
		[XmlIgnore]
		[Column]
		public double vdiffMaxDouble
		{
			get { return VscaleProps.VdiffMax; }
			set { } // set { VscaleProps.VdiffMax = value; }
		}

		/// <summary>
		/// The voltage per vertical division, formatted as an SI quantity.
		/// </summary>
		[XmlElement("voltageDiv")]
		public SIVoltage voltageDivSI
		{
			get { return new SIVoltage(voltageDivDouble); }
			set { voltageDivDouble = value.Value; }
		}

		/// <summary>The voltage per vertical division.</summary>
		[XmlIgnore]
		[Column]
		public double voltageDivDouble { get; set; }

		/// <summary>
		/// The properties that are determined by the attenuation and v/div settings.
		/// </summary>
		VscaleProps VscaleProps
		{
			get
			{
				// Retrieve the applicable set of properties. The attenuation
				// has to match, and the v/div has to be within range.
				return Array.Find(VscaleProps.AllProps,
					vsp => vsp.Attenuation == attenuationDouble &&
						voltageDivDouble >= vsp.VdivMin &&
						voltageDivDouble <= vsp.VdivMax);
			}
		}

		/// <summary>
		/// The voltage sensitivity, formatted as an SI quantity.
		/// </summary>
		[XmlIgnore]
		public SIVoltage vsensSI
		{
			get { return new SIVoltage(vsensDouble); }
			// set { vsensDouble = value.Value; }
		}

		/// <summary>The voltage sensitivity.</summary>
		[XmlIgnore]
		[Column]
		public double vsensDouble
		{
			get { return VscaleProps.Sensitivity; }
			set { } // set { VscaleProps.Sensitivity = value; }
		}
	}

	/// <summary>
	/// The enumeration of all trigger modes possible for a profile.
	/// </summary>
	public enum TriggerMode
	{
		/// <summary>
		/// Continunously search for a trigger and don't update the display
		/// unless a trigger is found
		/// </summary>
		NORM,

		/// <summary>
		/// Search for a trigger, forcing a trigger after 100ms if no trigger
		/// is found.
		/// </summary>
		AUTO,

		/// <summary>
		/// Continuously search for a trigger; do not initiate a new
		/// acquisition cycle after a successful trigger.
		/// </summary>
		SING,

		/// <summary>
		/// "In SCAN mode, data acquisition runs continuously and the input
		/// signal is progressively displayed from left to right in real-time
		/// disregarding other trigger options."
		/// </summary>
		SCAN,

		/// <summary>
		/// "In FIT trigger mode, the Nano will automatically identify the
		/// type of waveform and adjust the settings to produce a usable
		/// display of the input signal."
		/// </summary>
		FIT
	};

	/// <summary>
	/// The enumeration of trigger kinds possible for a waveform.
	/// </summary>
	public enum TriggerKind
	{
		/// <summary>Trigger on the rising edge of a waveform</summary>
		EdgeRising,

		/// <summary>Trigger on the falling edge of a waveform</summary>
		EdgeFalling
	}

	/// <summary>
	/// The different fast sampling mode states possible for a waveform.
	/// </summary>
	public enum FastSamplingMode
	{
		/// <summary>Disabled by the user.</summary>
		Disabled,
		/// <summary>Enabled by the user.</summary>
		Enabled,
		/// <summary>Forced off due to the timescale.</summary>
		DisabledByTimescale
	};

	/// <summary>
	/// A set of properties for a range of V/div settings.
	/// </summary>
	public class VscaleProps
	{
		/// <summary>
		/// The array of all possible properties for certain ranges of voltage
		/// settings.
		/// </summary>
		public static readonly VscaleProps[] AllProps = new VscaleProps[]
		{
			new VscaleProps( 1,  10e-3, 100e-3, 288e-6, 800e-3, 1.02e+6),
			new VscaleProps( 1, 200e-3,   1e+0, 2.2e-3,   8e+0,  546e+3),
			new VscaleProps( 1,   2e+0,  10e+0,  23e-3,  80e+0,  513e+3),
			new VscaleProps(10, 200e-3,   1e+0, 2.8e-3,   8e+0, 1.02e+6),
			new VscaleProps(10,   2e+0,  10e+0,  22e-3,  80e+0,  575e+3),
			new VscaleProps(10,  20e+0, 100e+0, 205e-3, 800e+0,  517e+3)
		};

		/// <summary>
		/// The probe attenuation for which these properties apply.
		/// </summary>
		public double Attenuation { get; set; }

		/// <summary>
		/// The minimum v/div for which these properties apply.
		/// </summary>
		public double VdivMin { get; set; }

		/// <summary>
		/// The maximum v/div for which these properties apply.
		/// </summary>
		public double VdivMax { get; set; }

		/// <summary>
		/// The voltage sensitivity on this setting.
		/// </summary>
		public double Sensitivity { get; set; }

		/// <summary>
		/// The maximum allowable differential voltage on this setting.
		/// </summary>
		public double VdiffMax { get; set; }

		/// <summary>
		/// The DC input resistance on this setting.
		/// </summary>
		public double Rin { get; set; }

		/// <summary>The constructor.</summary>
		/// <param name="attenuation">
		/// The probe attenuation for which these properties apply.
		/// </param>
		/// <param name="vdivmin">
		/// The minimum v/div for which these properties apply.
		/// </param>
		/// <param name="vdivmax">
		/// The maximum v/div for which these properties apply.
		/// </param>
		/// <param name="sensitivity">
		/// The voltage sensitivity on this setting.
		/// </param>
		/// <param name="vdiffmax">
		/// The maximum allowablw differential voltage on this setting.
		/// </param>
		/// <param name="rin">
		/// The DC input resistance on this setting.
		/// </param>
		public VscaleProps(double attenuation, double vdivmin, double vdivmax,
			double sensitivity, double vdiffmax, double rin)
		{
			Attenuation = attenuation;
			VdivMin = vdivmin;
			VdivMax = vdivmax;
			Sensitivity = sensitivity;
			VdiffMax = vdiffmax;
			Rin = rin;
		}
	}
}
