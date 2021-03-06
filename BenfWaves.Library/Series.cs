﻿/** \file
* \$Rev: 109 $
* 
* \$Date: 2011-04-14 23:21:23 +0000 (Thu, 14 Apr 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/Series.cs $
*/

using System;

namespace BenfWaves.Library
{
	/// <summary>One dimension of a data series.</summary>
	public abstract class SeriesDimension
	{
		/// <summary>The data for this series.</summary>
		public double[] data;

		/// <summary>
		/// Get the range of the waveform quantity associated with this
		/// dimension.
		/// </summary>
		public Func<double> GetUnitRange;

		/// <summary>
		/// Get the start of the waveform quantity associated with this
		/// dimension.
		/// </summary>
		public Func<double> GetUnitStart;

		/// <summary>
		/// Get a new instance of an SIValue to properly format a waveform
		/// quantity associated with this dimension.
		/// </summary>
		public Func<SIValue> GetNewSIValue;

		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <returns>An array index.</returns>
		public abstract double? UnitToIndex(double unit);

		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <param name="imin">The minimum index to search.</param>
		/// <param name="imax">The maximum index to search.</param>
		/// <returns>An array index.</returns>
		public abstract double? UnitToIndexLimited(
			double unit, int imin, int imax);

		/// <summary>
		/// Convert an array index to a waveform quantity.
		/// </summary>
		/// <param name="index">An array index.</param>
		/// <returns>A waveform quantity.</returns>
		public abstract double? IndexToUnit(double index);
	}

	/// <summary>
	/// The horizontal dimension of a waveform series.
	/// </summary>
	public class HorzSeriesDimension : SeriesDimension
	{
		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <returns>An array index.</returns>
		public override double? UnitToIndex(double unit)
		{
			return (unit - GetUnitStart()) * data.Length /
				GetUnitStart();
		}

		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <param name="imin">The minimum index to search.</param>
		/// <param name="imax">The maximum index to search.</param>
		/// <returns>An array index.</returns>
		public override double? UnitToIndexLimited(
			double unit, int imin, int imax)
		{
			return UnitToIndex(unit);
		}

		/// <summary>
		/// Convert an array index to a waveform quantity.
		/// </summary>
		/// <param name="index">An array index.</param>
		/// <returns>A waveform quantity.</returns>
		public override double? IndexToUnit(double index)
		{
			return GetUnitStart() + index * GetUnitRange() /
				data.Length;
		}
	}

	/// <summary>
	/// The vertical dimension of a waveform series.
	/// </summary>
	public class VertSeriesDimension : SeriesDimension
	{
		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <returns>An array index.</returns>
		public override double? UnitToIndex(double unit)
		{
			return UnitToIndexLimited(unit,
				0, data.Length);
		}

		/// <summary>
		/// Convert a waveform quantity to an array index.
		/// </summary>
		/// <param name="unit">A waveform quantity.</param>
		/// <param name="imin">The minimum index to search.</param>
		/// <param name="imax">The maximum index to search.</param>
		/// <returns>An array index.</returns>
		public override double? UnitToIndexLimited(
			double unit, int imin, int imax)
		{
			imax = Math.Min(imax, data.Length);
			double vprev = data[imin];
			for (int index = imin + 1; index < imax; index++)
			{
				double vnow = data[index];
				if ((vprev < vnow && unit >= vprev && unit <= vnow) ||
					(vnow < vprev && unit >= vnow && unit <= vprev))
					return index - 1 + (unit - vprev) / (vnow - vprev);
				vprev = vnow;
			}
			return null;
		}

		/// <summary>
		/// Convert an array index to a waveform quantity.
		/// </summary>
		/// <param name="index">An array index.</param>
		/// <returns>A waveform quantity.</returns>
		public override double? IndexToUnit(double index)
		{
			int ind1 = (int)Math.Floor(index),
				ind2 = (int)Math.Ceiling(index);
			if (ind1 < 0 || ind2 >= data.Length)
				return null;
			double v1 = data[ind1],
				v2 = data[ind2];
			return (v2 - v1) * (index - ind1) + v1;
		}
	}

	/// <summary>A waveform data series.</summary>
	public class Series
	{
		/// <summary>The raw data.</summary>
		public readonly double[] data;
		/// <summary>The horizontal dimension for the series.</summary>
		public readonly SeriesDimension DimHorz;
		/// <summary>The vertical dimension for the series.</summary>
		public readonly SeriesDimension DimVert;

		/// <summary>The constructor.</summary>
		/// <param name="data">The series data array.</param>
		/// <param name="dimHorz">The horizontal dimension.</param>
		/// <param name="dimVert">The vertical dimension.</param>
		public Series(double[] data,
			HorzSeriesDimension dimHorz,
			VertSeriesDimension dimVert)
		{
			this.data = data;
			this.DimHorz = dimHorz;
			this.DimVert = dimVert;
			DimHorz.data = data;
			DimVert.data = data;
		}
	}
}
