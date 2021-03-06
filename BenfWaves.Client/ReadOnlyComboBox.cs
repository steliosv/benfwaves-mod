﻿/** \file
* \$Rev: 76 $
* 
* \$Date: 2011-03-31 03:56:58 +0000 (Thu, 31 Mar 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/ReadOnlyComboBox.cs $
*/

using System;
using System.Windows.Forms;

namespace BenfWaves.Client
{
	/// <summary>
	/// A combobox that appears as an enabled one does, but does not allow the
	/// value to change
	/// </summary>
	public partial class ReadOnlyComboBox : ComboBox
	{
		/// <summary>
		/// True if a user selection change is to be reverted.
		/// </summary>
		bool ignoreNextChange = false;
		/// <summary>
		/// The previous index to use when a changed index must be reverted.
		/// </summary>
		int prevIndex = -1;

		/// <summary>The constructor.</summary>
		public ReadOnlyComboBox() { InitializeComponent(); }

		/// <summary>
		/// Revert a change in selection if appropriate.
		/// </summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event parameters.</param>
		private void ReadOnlyComboBox_SelectedIndexChanged(
			object sender, EventArgs e)
		{
			if (ignoreNextChange)
			{
				ignoreNextChange = false;
				SelectedIndex = prevIndex;
			}
			else
				prevIndex = SelectedIndex;
		}

		/// <summary>
		/// Detect a user selection change (and not a change from a binding
		/// source).
		/// </summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event parameters.</param>
		private void ReadOnlyComboBox_SelectionChangeCommitted(
			object sender, EventArgs e)
		{
			ignoreNextChange = true;
		}
	}
}
