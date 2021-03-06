﻿/** \file
* \$Rev: 141 $
* 
* \$Date: 2012-02-18 16:47:41 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/DisplayDimension.cs $
*/

using System;
using System.Drawing;
using System.Windows.Forms;

using BenfWaves.Library;

namespace BenfWaves.Client
{
	/// <summary>
	/// A class to factor common code between horizontal axis and vertical axis
	/// operations on the waveform display.
	/// </summary>
	public class DisplayDimension
	{
		/// <summary>The dimension orthagonal to this one.</summary>
		public DisplayDimension Orth { get; set; }

		/// <summary>The scrollbar to pan across the dimension.</summary>
		public ScrollBar ScrollPan { get; set; }
		/// <summary>The scrollbar to zoom in and out.</summary>
		public ScrollBar ScrollZoom { get; set; }
		/// <summary>Whether the axis direction is inverted.</summary>
		public bool DisplayInversion { get; set; }

		/// <summary>The associated waveform.</summary>
		SeriesDimension seriesDim;
		/// <summary>The associated waveform.</summary>
		public SeriesDimension SeriesDim
		{
			get { return seriesDim; }
			set
			{
				seriesDim = value;
				RefreshPan();
			}
		}


		/// <summary>
		/// A function to get the panel size in this dimension.
		/// </summary>
		public Func<Size> GetPanelSize { get; set; }
		/// <summary>
		/// A function to convert from absolute coordinates to coordinates that
		/// might be transposed to correct for this dimension.
		/// </summary>
		public Func<PointF, PointF> TransposePointF { get; set; }

		/// <summary>
		/// A function to look for an intersection; the argument is a pixel
		/// distance and the return value is a waveform quantity (or null if no
		/// intersection was found).
		/// </summary>
		public Func<float, double?> Intersect { get; set; }

		/// <summary>
		/// The size of the panel, in transposed pixel coordinates.
		/// </summary>
		public PointF PanelPixels
		{
			get
			{
				return TransposePointF(
					new PointF(
						GetPanelSize().Width,
						GetPanelSize().Height));
			}
		}

		/// <summary>
		/// The string format that determines whether axis quantities are shown
		/// normally or rotated 90 degrees.
		/// </summary>
		public StringFormat StringFormat { get; set; }
		/// <summary>The maximum zoom exponent.</summary>
		public const double MaxZoom = 3;
		/// <summary>
		/// The scrollbar value to maintain a centred display while zooming.
		/// </summary>
		int pinnedCentre;
		/// <summary>Whether this dimension is currently zooming.</summary>
		bool zooming = false;

		/// <summary>The zoom multiplier.</summary>
		public double ZoomFactor
		{
			get
			{
				double exp = ((ScrollZoom.Value - ScrollZoom.Minimum) /
					(double)(ScrollZoom.Maximum - ScrollZoom.Minimum -
					ScrollZoom.LargeChange + 1) - 1) *
					MaxZoom;
				return Math.Pow(10, exp);
			}
		}

		/// <summary>
		/// The pan position of the view, as a factor of total width.
		/// </summary>
		public double ViewStartFactor
		{
			get
			{
				return (ScrollPan.Value - ScrollPan.Minimum) /
					(double)(ScrollPan.Maximum - ScrollPan.Minimum);
			}
		}

		/// <summary>
		/// Transpose a point from absolute coordinates to dimension-
		/// corrected coordinates.
		/// </summary>
		/// <param name="old">The original (absolute) point.</param>
		/// <returns>A point that might be transposed to be corrected.</returns>
		public System.Drawing.Point TransposePoint(System.Drawing.Point old)
		{
			PointF transposed = TransposePointF(new PointF(old.X, old.Y));
			return new System.Drawing.Point(
				(int)transposed.X,
				(int)transposed.Y);
		}

		/// <summary>
		/// Convert a pixel distance to a waveform quantity.
		/// </summary>
		/// <param name="pixel">The pixel distance.</param>
		/// <returns>The waveform quantity.</returns>
		public double PixelToUnit(float pixel)
		{
			pixel /= PanelPixels.X;
			if (DisplayInversion)
				pixel = 1 - pixel;
			double unit = SeriesDim.GetUnitStart() + SeriesDim.GetUnitRange() *
				(ViewStartFactor + pixel * ZoomFactor);
			return unit;
		}

		/// <summary>
		/// Convert a waveform quantity to a pixel distance.
		/// </summary>
		/// <param name="unit">The waveform quantity.</param>
		/// <returns>The pixel distance.</returns>
		public float UnitToPixel(double unit)
		{
			double pixel = ((unit - SeriesDim.GetUnitStart())
				/ SeriesDim.GetUnitRange() - ViewStartFactor) / ZoomFactor;
			if (DisplayInversion)
				pixel = 1 - pixel;
			return (float)(pixel * PanelPixels.X);
		}

		/// <summary>
		/// The waveform quantity per display pixel.
		/// </summary>
		public double UnitPerPixel
		{
			get { return SeriesDim.GetUnitRange() * ZoomFactor / PanelPixels.X; }
		}

		/// <summary>
		/// The waveform quantity per display division.
		/// </summary>
		public double UnitPerDiv
		{
			get
			{
				double
					pixelsPerDiv = 25,
					unitPerDiv = UnitPerPixel * pixelsPerDiv,
					order = Math.Pow(10, Math.Floor(Math.Log10(unitPerDiv))),
					unitSigdigs = unitPerDiv / order;

				if (unitSigdigs <= 2)
					unitSigdigs = 2;
				else if (unitSigdigs <= 5)
					unitSigdigs = 5;
				else unitSigdigs = 10;

				return unitSigdigs * order;
			}
		}

		/// <summary>
		/// The number of display pixels per division.
		/// </summary>
		public double PixelsPerDiv
		{
			get { return UnitPerDiv / UnitPerPixel; }
		}

		/// <summary>
		/// The number of divs in this dimension.
		/// </summary>
		public double Divs { get { return PanelPixels.X / PixelsPerDiv; } }

		/// <summary>
		/// Iterate through the possible grid values in this dimension.
		/// </summary>
		/// <param name="body">
		/// The loop body delegate, accepting parameters for the pixel value,
		/// the waveform quantity, and whether text should be drawn at this
		/// location.
		/// </param>
		public void IterateGrid(Action<float, double, bool> body)
		{
			double unitPerDiv = UnitPerDiv,
				pixelPerDiv = PixelsPerDiv,
				unitStart = PixelToUnit(0);
			int divEnd = (int)Divs;
			unitStart -= unitStart % unitPerDiv;
			double pixelStart = UnitToPixel(unitStart);

			bool drawText = false;

			for (int div = 0; div < divEnd; div++)
			{
				double unitOffset = div * unitPerDiv;
				if (DisplayInversion)
					unitOffset = -unitOffset;
				double unit = unitStart + unitOffset,
					pixel = pixelStart + div * pixelPerDiv;
				body((float)pixel, unit, drawText);
				if (pixel > 0)
					drawText = true;
			}
		}

		/// <summary>
		/// Refresh the pan scrollbar based on zoom information.
		/// </summary>
		public void RefreshPan()
		{
			RefreshPan(ScrollEventType.EndScroll);
		}

		/// <summary>
		/// Refresh the pan scrollbar based on zoom information.
		/// </summary>
		/// <param name="sevent">
		/// The type of scroll event received. If any type except EndScroll,
		/// the dimension goes into zooming mode with a fixed centre.
		/// Otherwise, zooming mode is finished.
		/// </param>
		public void RefreshPan(ScrollEventType sevent)
		{
			if (ScrollPan == null)
				return;

			if (!zooming)
			{
				zooming = true;
				pinnedCentre = ScrollPan.Value + ScrollPan.LargeChange / 2;
			}

			ScrollPan.LargeChange = (int)(ZoomFactor * ScrollPan.Maximum);
			ScrollPan.SmallChange = ScrollPan.LargeChange / 25;

			ScrollPan.Value = Math.Max(0, Math.Min(ScrollPan.Maximum,
				pinnedCentre - ScrollPan.LargeChange / 2));

			if (sevent == ScrollEventType.EndScroll)
				zooming = false;
		}
	}
}
