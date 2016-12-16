/** \file
* \$Rev: 82 $
* 
* \$Date: 2011-04-02 23:40:01 +0000 (Sat, 02 Apr 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/ReadOnlyTableTextbox.cs $
*/

using System;
using System.Windows.Forms;

namespace BenfWaves.Client
{
	/// <summary>
	/// A text box that is docked in a table, that is read-only, and whose
	/// background appears enabled.
	/// </summary>
	public partial class ReadOnlyTableTextbox : TextBox
	{
		/// <summary>
		/// The constructor. Nothing special.
		/// </summary>
		public ReadOnlyTableTextbox()
		{
			InitializeComponent();
		}
	}
}
