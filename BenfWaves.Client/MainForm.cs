/** \file
* \$Rev: 100 $
* 
* \$Date: 2011-04-07 04:33:55 +0000 (Thu, 07 Apr 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/MainForm.cs $
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using BenfWaves.Library;

namespace BenfWaves.Client
{
	/// <summary>The main application form.</summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// A list of controls only enabled if an MDI child is active.
		/// </summary>
		readonly List<ToolStripItem> mdiChildItems;

		/// <summary>The default text to show in the status bar.</summary>
		string defaultStatus = "Ready";

		/// <summary>The default text to show in the status bar.</summary>
		public string DefaultStatus
		{
			get { return defaultStatus; }
			set
			{
				defaultStatus = value;
				Status = value;
			}
		}

		/// <summary>
		/// The status bar text on the bottom of the MDI parent.
		/// </summary>
		public string Status
		{
			get { return statusLabel.Text; }
			set { statusLabel.Text = value; }
		}

		/// <summary>The constructor for the main form.</summary>
		public MainForm()
		{
			InitializeComponent();

			// These controls should only appear if there is an MDI child
			mdiChildItems = new List<ToolStripItem>
			{
				menuSaveAs,
				menuPrint,
				menuPrintPreview,
				menuPrintSetup,
				toolbarPrint,
				toolbarSaveAs
			};

			// Initially disable Save, etc.
			MainForm_MdiChildActivate(null, null);

#if DEBUG
			// For quick debugging, open a default file
			WaveformWindow ww = new WaveformWindow(this,
				Library.Waveform.FromXMLFile(@"BenfWaves.Tests\Samples\100ksine.xml"));
			ww.Show();
#endif
		}

		/// <summary>
		/// Look up which MDI window is associated with a certain waveform.
		/// </summary>
		/// <param name="waveform">The waveform to look for.</param>
		/// <returns>An MDI child window.</returns>
		public WaveformWindow WindowForWaveform(Waveform waveform)
		{
			return (WaveformWindow)Array.Find(MdiChildren, form =>
				ReferenceEquals(((WaveformWindow)form).waveform, waveform));
		}

		/// <summary>Open a file.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void OpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.DefaultExt = "xml";
			dialog.Filter =
				"DSO Nano XML files (*.xml)|*.xml|All files (*.*)|*.*";
			dialog.Multiselect = true;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string filename in dialog.FileNames)
				{
					Waveform newwave = Waveform.FromXMLFile(filename);
					WaveformWindow ww = new WaveformWindow(this, newwave);
					ww.Show();
				}
			}
		}

		/// <summary>Save a file to a specific location.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void SaveFile_Click(object sender, EventArgs e)
		{
			WaveformWindow ww = ActiveMdiChild as WaveformWindow;
			if (ww != null)
				ww.SaveAs();
		}

		/// <summary>Quit the program.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void Exit_Click(object sender, EventArgs e) { Close(); }

		/// <summary>Show or hide the toolbar.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void ShowToolbar_Click(object sender, EventArgs e)
		{
			toolStrip.Visible = menuShowToolbar.Checked;
		}

		/// <summary>Show or hide the status bar.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void ShowStatusbar_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = menuShowStatus.Checked;
		}

		/// <summary>Cascade the MDI child windows.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void Cascade_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		/// <summary>Tile the MDI children vertically.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void TileVertical_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		/// <summary>Tile the MDI children horizontally.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void TileHorizontal_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		/// <summary>Arrange minimized MDI child window icons.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void ArrangeIcons_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		/// <summary>Close all MDI children.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void CloseAll_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
				childForm.Close();
		}

		/// <summary>Show the project's home page on Google Code.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void Homepage_Click(object sender, EventArgs e)
		{
			Process.Start("http://code.google.com/p/benfwaves/");
		}

		/// <summary>Show the wiki for this project.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void Wiki_Click(object sender, EventArgs e)
		{
			Process.Start("http://code.google.com/p/benfwaves/wiki/BenfWaves");
		}

		/// <summary>Show the BenF firmware manual.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void FirmwareManual_Click(object sender, EventArgs e)
		{
			Process.Start("http://benfwaves.googlecode.com/files/" +
				"BenF V3 Firmware Users Guide.pdf");
		}

		/// <summary>
		/// Change the controls to reflect an MDI child being active or
		/// inactive.
		/// </summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event arguments.</param>
		private void MainForm_MdiChildActivate(object sender, EventArgs e)
		{
			bool childactive = ActiveMdiChild != null;
			foreach (ToolStripItem item in mdiChildItems)
				item.Enabled = childactive;
		}
	}
}
