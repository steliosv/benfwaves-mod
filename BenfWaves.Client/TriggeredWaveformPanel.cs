/** \file
* \$Rev: 141 $
* 
* \$Date: 2012-02-18 16:47:41 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/TriggeredWaveformPanel.cs $
*/

using System.Drawing;
using System.Windows.Forms;

using BenfWaves.Library;

namespace BenfWaves.Client
{
	/// <summary>
	/// A waveform panel for voltage with respect to time that, in addition
	/// to the trace, displays trigger levels.
	/// </summary>
	public partial class TriggeredWaveformPanel : WaveformPanel
	{
		/// <summary>The pen to draw the trigger lines.</summary>
		static protected readonly Pen triggerPen = new Pen(Color.Orange, 1f);

		/// <summary>
		/// The waveform that this panel draws.
		/// </summary>
		public Waveform Waveform { get; set; }

		/// <summary>
		/// The constructor.
		/// </summary>
		public TriggeredWaveformPanel()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Draw the one or two trigger levels, and the trigger event.
		/// </summary>
		/// <param name="e">
		/// The paint event arguments, including clipping information and
		/// a graphics object.
		/// </param>
		void DrawTriggers(PaintEventArgs e)
		{
			float pixTrigHigh = dimVert.UnitToPixel(Waveform.Profile.triggerHigh.Value),
				pixTrigLow = dimVert.UnitToPixel(Waveform.Profile.triggerLow.Value),
				pixTrigEvent = dimHorz.UnitToPixel(0);

			e.Graphics.DrawLine(triggerPen,
				new PointF(0, pixTrigLow),
				new PointF(Width, pixTrigLow));
			e.Graphics.DrawLine(triggerPen,
				new PointF(0, pixTrigHigh),
				new PointF(Width, pixTrigHigh));
			e.Graphics.DrawLine(triggerPen,
				new PointF(pixTrigEvent, 0),
				new PointF(pixTrigEvent, Height));
		}
		
		/// <summary>
		/// Draw all of the features on this panel.
		/// </summary>
		/// <param name="e">
		/// The paint event arguments, including clipping information and
		/// a graphics object.
		/// </param>
		protected override void DrawFeatures(PaintEventArgs e)
		{
			DrawTriggers(e);
			base.DrawFeatures(e);
		}
	}
}
