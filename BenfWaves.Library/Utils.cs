﻿/** \file
* \$Rev: 148 $
* 
* \$Date: 2013-11-20 21:56:25 +0000 (Wed, 20 Nov 2013) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Library/Utils.cs $
*/

namespace BenfWaves.Library
{
	/// <summary>
	/// A class containing general utilities.
	/// </summary>
	public static class Utils
	{
		#region Configuration string
		/// <summary>
		/// A string representing the build configuration.
		/// </summary>
		public const string configuration =
			".NET" +
#if Debug_3_5
			"3.5 - Debug"
#elif Debug_4_0
			"4.0 - Debug"
#elif Debug_4_5
			"4.5 - Debug"
#elif Release_3_5
			"3.5 - Release"
#elif Release_4_0
			"4.0 - Release"
#elif Release_4_5
			"4.5 - Release"
#endif
            + " - " +
#if PLATFORM_x86
			"x86"
#elif PLATFORM_x64
			"x64"
#elif PLATFORM_AnyCPU
			"AnyCPU"
#endif
			;
		#endregion
	}
}
