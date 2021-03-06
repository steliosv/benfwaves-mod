﻿/** \file
* \$Rev: 123 $
* 
* \$Date: 2011-05-27 01:46:07 +0000 (Fri, 27 May 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/SIValue.cs $
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BenfWaves.Library
{
	/// <summary>
	/// A basic formatted quantity.
	/// </summary>
	public abstract class SIValue : IXmlSerializable
	{
		/// <summary>
		/// The quantity's value.
		/// </summary>
		double val;

		/// <summary>
		/// A regular expression to parse formatted strings.
		/// </summary>
		static readonly Regex parser = new Regex(
			@"^\s*" +
			@"(?<val>-?\d*\.?\d*)" +
			@"\s*" +
			@"(?<unit>\S+)" +
			@"\s*$",
			RegexOptions.Compiled);

		/// <summary>The unit of the quantity (V for volts, etc.)</summary>
		protected abstract string UnitInternal { get; }

		/// <summary>The unit of the quantity (V for volts, etc.)</summary>
		public string Unit
		{
			get { return UnitInternal; }
			set
			{
				if (value != UnitInternal)
					throw new ArgumentException();
			}
		}

		/// <summary>
		/// Represent the SI quantity as a string.
		/// </summary>
		/// <returns>The SI quantity, formatted as a string</returns>
		public override string ToString() { return Formatted; }

		/// <summary>
		/// The quantity, as a double.
		/// </summary>
		public virtual double Value
		{
			get { return val; }
			set { val = value; }
		}

		/// <summary>
		/// The quantity, formatted as a string.
		/// </summary>
		public virtual string Formatted
		{
			get
			{
				return Value.ToString() + UnitInternal;
			}
			set
			{
				Match match = parser.Match(value);
				if (!match.Success)
					throw new FormatException();
				Value = double.Parse(match.Groups["val"].Value);
				Unit = match.Groups["unit"].Value;
			}
		}

		/// <summary>
		/// This method is reserved and should not be used. When implementing the
		/// IXmlSerializable interface, you should return null (Nothing in
		/// Visual Basic) from this method, and instead, if specifying a custom
		/// schema is required, apply the
		/// System.Xml.Serialization.XmlSchemaProviderAttribute to the class.
		/// </summary>
		/// <returns>
		/// An System.Xml.Schema.XmlSchema that describes the XML
		/// representation of the object that is produced by the
		/// System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)
		/// method and consumed by the
		/// System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)
		/// method.
		/// </returns>
		XmlSchema IXmlSerializable.GetSchema()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Generates an object from its XML representation.
		/// </summary>
		/// <param name="reader">
		/// The System.Xml.XmlReader stream from which the object is deserialized.
		/// </param>
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			Formatted = reader.ReadString();
			if (!reader.IsEmptyElement)
				reader.ReadEndElement();
		}

		/// <summary>
		/// Converts an object into its XML representation.
		/// </summary>
		/// <param name="writer">
		/// The System.Xml.XmlWriter stream to which the object is serialized.
		/// </param>
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			writer.WriteString(Formatted);
		}
	}

	/// <summary>
	/// A dB quantity.
	/// </summary>
	public class SIdB : SIValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "dB"; } }
	}

	/// <summary>
	/// An angle quantity.
	/// </summary>
	public class SIAngle : SIValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "°"; } }
	}

	/// <summary>
	/// An SI value, with a value, a unit and a magnitude prefix.
	/// </summary>
	public abstract class SIPrefixedValue : SIValue
	{
		/// <summary>
		/// A dictionary of SI exponents and their corresponding prefix letters.
		/// </summary>
		static readonly Dictionary<int, char> magToPrefix =
			new Dictionary<int, char>()
		{
			{ 9, 'G' },
			{ 6, 'M' },
			{ 3, 'k' },
			{ -3, 'm' },
			{ -6, 'u' },
			{ -9, 'n' },
			{ -12, 'p' }
		};

		/// <summary>
		/// A dictionary of SI prefix letters and their corresponding exponents.
		/// </summary>
		static readonly Dictionary<char, int> prefixToMag;

		/// <summary>
		/// A regular expression to parse formatted SI quantity strings.
		/// </summary>
		static readonly Regex parserPrefixed = new Regex(
			@"^\s*" +
			@"(?<sigdigs>-?\d*\.?\d*)" +
			@"\s*" +
			@"(?<prefix>[GMkmunp])?" +
			@"(?<unit>\S+)" +
			@"\s*$",
			RegexOptions.Compiled);

		/// <summary>The significant digit portion of the SI quantity.</summary>
		double sigdigs;

		/// <summary>The significant digit portion of the SI quantity.</summary>
		public double SigDigs
		{
			get { return sigdigs; }
			set
			{
				int adjustexp;
				Normalize(value, out sigdigs, out adjustexp);
				Exponent += adjustexp;
			}
		}

		/// <summary>The exponent of the SI quantity.</summary>
		public int Exponent { get; set; }

		/// <summary>The non-normalized value.</summary>
		public override double Value
		{
			get { return SigDigs * Math.Pow(10, Exponent); }
			set
			{
				int newexp;
				Normalize(value, out sigdigs, out newexp);
				Exponent = newexp;
			}
		}

		/// <summary>
		/// The SI prefix letter to indicate the order of magnitude of the
		/// quantity.
		/// </summary>
		public string Prefix
		{
			get
			{
				char prefix;
				if (magToPrefix.TryGetValue(Exponent, out prefix))
					return prefix.ToString();
				return "";
			}
			set
			{
				switch (value.Length)
				{
					case 0:
						Exponent = 0;
						break;
					case 1:
						Exponent = prefixToMag[value[0]];
						break;
					default:
						throw new ArgumentException();
				}
			}
		}

		/// <summary>
		/// The SI quantity as a formatted string.
		/// </summary>
		public override string Formatted
		{
			get
			{
				string prefix = Prefix,
					formatstr;
				if (prefix == "")
				{
					if (Exponent == 0)
						formatstr = "{0:0.###}{1}";
					else
						formatstr = "{0:0.###e+0}{1}";
					return string.Format(formatstr, Value, UnitInternal);
				}
				formatstr = "{0:0.###}{1}{2}";
				return string.Format(formatstr, SigDigs, prefix, UnitInternal);
			}
			set
			{
				Match match = null;
				try
				{
					match = parserPrefixed.Match(value);
					if (!match.Success)
						throw new FormatException();
					// Unit is read-only, determined by the child class (SIVoltage,
					// etc.)
					Unit = match.Groups["unit"].Value;
					Prefix = match.Groups["prefix"].Value;
					SigDigs = double.Parse(match.Groups["sigdigs"].Value,
						CultureInfo.InvariantCulture);
				}
				catch (Exception exinner)
				{
					if (match == null)
						throw;
					FormatException ex = new FormatException(
						"value: '" + value + "'" + Environment.NewLine +
						"unit: '" + match.Groups["unit"].Value + "'" + Environment.NewLine +
						"prefix: '" + match.Groups["prefix"].Value + "'" + Environment.NewLine +
						"sigdigs: '" + match.Groups["sigdigs"].Value + "'",
						exinner);
					throw ex;
				}
			}
		}

		/// <summary>The static constructor.</summary>
		static SIPrefixedValue()
		{
			// Initialize a dictionary to convert from prefix numbers to
			// magnitudes.
			prefixToMag = new Dictionary<char, int>();
			foreach (KeyValuePair<int, char> kvp in magToPrefix)
				prefixToMag[kvp.Value] = kvp.Key;
		}

		/// <summary>
		/// Construct an SI value by parsing a string.
		/// </summary>
		/// <param name="formatted">The formatted SI value.</param>
		public SIPrefixedValue(string formatted) { Formatted = formatted; }

		/// <summary>
		/// Construct an SI value by providing a value.
		/// </summary>
		/// <param name="value">The value of the SI quantity.</param>
		public SIPrefixedValue(double value) { Value = value; }

		/// <summary>
		/// Construct the default SI value, initialized to zero.
		/// </summary>
		public SIPrefixedValue() { Value = 0; }

		/// <summary>
		/// Normalizes a value to have between 1 and 3 digits before the point,
		/// so that value = sigdigs * 10^exp, abs(sigdigs) between 1 and 999
		/// </summary>
		/// <param name="value">The unnormalized value</param>
		/// <param name="sigdigs">The normalized value</param>
		/// <param name="exp">The exponent</param>
		public static void Normalize(double value, out double sigdigs,
			out int exp)
		{
			if (value == 0)
			{
				exp = 0;
				sigdigs = 0;
			}
			else
			{
				exp = (int)Math.Floor(Math.Log10(Math.Abs(value)) / 3) * 3;
				sigdigs = value / Math.Pow(10, exp);
			}
		}
	}

	/// <summary>A voltage quantity in SI format.</summary>
	public class SIVoltage : SIPrefixedValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "V"; } }

		/// <summary>
		/// Construct an SI value by parsing a string.
		/// </summary>
		/// <param name="formatted">The formatted SI value.</param>
		public SIVoltage(string formatted) : base(formatted) { }

		/// <summary>
		/// Construct an SI value by providing a value.
		/// </summary>
		/// <param name="value">The value of the SI quantity.</param>
		public SIVoltage(double value) : base(value) { }

		/// <summary>
		/// Construct the default SI value, initialized to zero.
		/// </summary>
		public SIVoltage() { }
	}

	/// <summary>A time quantity in SI format.</summary>
	public class SITime : SIPrefixedValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "s"; } }

		/// <summary>
		/// Construct an SI value by parsing a string.
		/// </summary>
		/// <param name="formatted">The formatted SI value.</param>
		public SITime(string formatted) : base(formatted) { }

		/// <summary>
		/// Construct an SI value by providing a value.
		/// </summary>
		/// <param name="value">The value of the SI quantity.</param>
		public SITime(double value) : base(value) { }

		/// <summary>
		/// Construct the default SI value, initialized to zero.
		/// </summary>
		public SITime() { }
	}

	/// <summary>A frequency quantity in SI format.</summary>
	public class SIFreq : SIPrefixedValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "Hz"; } }

		/// <summary>
		/// Construct an SI value by parsing a string.
		/// </summary>
		/// <param name="formatted">The formatted SI value.</param>
		public SIFreq(string formatted) : base(formatted) { }

		/// <summary>
		/// Construct an SI value by providing a value.
		/// </summary>
		/// <param name="value">The value of the SI quantity.</param>
		public SIFreq(double value) : base(value) { }

		/// <summary>
		/// Construct the default SI value, initialized to zero.
		/// </summary>
		public SIFreq() { }
	}

	/// <summary>A resistance quantity in SI format.</summary>
	public class SIResistance : SIPrefixedValue
	{
		/// <summary>The unit of the quantity.</summary>
		protected override string UnitInternal { get { return "Ω"; } }

		/// <summary>
		/// Construct an SI value by parsing a string.
		/// </summary>
		/// <param name="formatted">The formatted SI value.</param>
		public SIResistance(string formatted) : base(formatted) { }

		/// <summary>
		/// Construct an SI value by providing a value.
		/// </summary>
		/// <param name="value">The value of the SI quantity.</param>
		public SIResistance(double value) : base(value) { }

		/// <summary>
		/// Construct the default SI value, initialized to zero.
		/// </summary>
		public SIResistance() { }
	}
}
