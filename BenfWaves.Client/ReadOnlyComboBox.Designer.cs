/** \file
* \$Rev: 53 $
* 
* \$Date: 2011-03-28 06:40:05 +0000 (Mon, 28 Mar 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/ReadOnlyComboBox.Designer.cs $
*/

namespace BenfWaves.Client
{
	partial class ReadOnlyComboBox : System.Windows.Forms.ComboBox
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
			this.SuspendLayout();
			// 
			// ReadOnlyComboBox
			// 
			this.CausesValidation = false;
			this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SelectedIndexChanged += new System.EventHandler(this.ReadOnlyComboBox_SelectedIndexChanged);
			this.SelectionChangeCommitted += new System.EventHandler(this.ReadOnlyComboBox_SelectionChangeCommitted);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
