/** \file
* \$Rev: 112 $
* 
* \$Date: 2011-04-16 00:06:50 +0000 (Sat, 16 Apr 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/WaveformPanel.Designer.cs $
*/

namespace BenfWaves.Client
{
	partial class WaveformPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timerHover = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timerHover
			// 
			this.timerHover.Tick += new System.EventHandler(this.timerHover_Tick);
			// 
			// WaveformPanel
			// 
			this.Name = "WaveformDisplay";
			this.Size = new System.Drawing.Size(410, 285);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WaveformPanel_Paint);
			this.MouseEnter += new System.EventHandler(this.WaveformPanel_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.WaveformPanel_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WaveformPanel_MouseMove);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timerHover;
	}
}
