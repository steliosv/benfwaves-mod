﻿/** \file
* \$Rev: 140 $
* 
* \$Date: 2012-02-18 16:41:11 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/WaveformWindow.cs $
*/

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using BenfWaves.Library;

namespace BenfWaves.Client
{
	/// <summary>
	/// The MDI child form representing a single waveform
	/// </summary>
	public partial class WaveformWindow : Form
	{
		/// <summary>
		/// The waveform object associated with this window
		/// </summary>
		public readonly Waveform waveform;

		/// <summary>
		/// The main waveform display panel for the voltage vs. time plot.
		/// </summary>
		public WaveformPanel PanelVoltTime { get { return panelVoltTime; } }

		/// <summary>
		/// The constructor for the waveform MDI child window
		/// </summary>
		/// <param name="parent">The MDI parent window</param>
		/// <param name="waveform">
		/// The waveform object to associate with this window
		/// </param>
		public WaveformWindow(Form parent, Waveform waveform)
		{
			InitializeComponent();

			// Base the title of the window on the file name.
			this.waveform = waveform;
			MdiParent = parent;
			Text = waveform.Profile.fileNumber + " (" +
				waveform.Profile.filename + ")";

			// Set up data binding.
			bindSrcWaveform.DataSource = waveform;
			comboFastMode.DataSource =
				Enum.GetValues(typeof(FastSamplingMode));
			comboTriggerKind.DataSource = Enum.GetValues(typeof(TriggerKind));
			comboTriggerMode.DataSource = Enum.GetValues(typeof(TriggerMode));

			panelVoltTime.Waveform = waveform;
			panelVoltTime.Series = waveform.Voltages;

			AddMouseListener(this);
		}

		/// <summary>
		/// Add listeners on mouse events for all controls that have a tooltip.
		/// When the mouse is on such a control, the tooptip text also goes to
		/// the status bar.
		/// </summary>
		/// <param name="control">The control to add listeners to.</param>
		void AddMouseListener(Control control)
		{
			string toolText = toolTip.GetToolTip(control);
			if (toolText != "")
			{
				control.MouseEnter += (sender, args) =>
					{ Program.MainForm.Status = toolText; };
				control.MouseLeave += (sender, args) =>
					{ Program.MainForm.Status = Program.MainForm.DefaultStatus; };
			}
			foreach (Control child in control.Controls)
				AddMouseListener(child);
		}

		/// <summary>Save the current file.</summary>
		public void SaveAs()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.DefaultExt = WaveformFormat.Formats[0].Extension;
			dialog.Filter = WaveformFormat.AllFilters;

			// Base the initial file and directory on the current waveform file
			// name.
			FileInfo fi = new FileInfo(waveform.Profile.filename);
			dialog.InitialDirectory = fi.Directory.FullName;
			dialog.FileName =
				Path.GetFileNameWithoutExtension(waveform.Profile.filename);

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Program.MainForm.UseWaitCursor = true;
				Program.MainForm.DefaultStatus = "Saving...";

				Thread savethread = new Thread(() =>
				{
					WaveformFormat format =
						WaveformFormat.Formats[dialog.FilterIndex - 1];
					format.Save(waveform, dialog.FileName);
					Program.MainForm.Invoke((Action)(() =>
					{
						Program.MainForm.UseWaitCursor = false;
						Program.MainForm.DefaultStatus = "Ready";
					}));
				});
				savethread.Start();
			}
		}
	}
}
