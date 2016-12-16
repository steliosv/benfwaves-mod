/** \file
* \$Rev: 141 $
* 
* \$Date: 2012-02-18 16:47:41 +0000 (Sat, 18 Feb 2012) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Tests/Library/TestPropertyExtractor.cs $
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenfWaves.Library.Tests
{
	/// <summary>
	/// Tests for the PropertyExtractor class to extract properties, nested and
	/// otherwise.
	/// </summary>
	[TestClass]
	public class TestPropertyExtractor
	{
		/// <summary>
		/// A test object whose properties should be detected by the extractor.
		/// </summary>
		class TestObject
		{
			/// <summary>A test property.</summary>
			public int p1 { get; set; }
			/// <summary>A test property.</summary>
			public string p2 { get; set; }
			/// <summary>A test nested object property.</summary>
			public NestedObject nested { get; set; }

			/// <summary>A test nested class type.</summary>
			public class NestedObject
			{
				/// <summary>A test property.</summary>
				public int p3 { get; set; }
				/// <summary>A test property.</summary>
				public string p4 { get; set; }
			}
		}

		/// <summary>
		/// Test that the property extractor can replace regular properties.
		/// </summary>
		[TestMethod]
		public void FillProps()
		{
			TestObject to = new TestObject();
			to.p1 = 10;
			to.p2 = "ab";

			Assert.AreEqual(to.p1.ToString(),
				PropertyExtractor.Extract("p1", to));
			Assert.AreEqual(to.p2.ToString(),
				PropertyExtractor.Extract("p2", to));
		}

		/// <summary>
		/// Test that the property extractor can extract nested properties.
		/// </summary>
		[TestMethod]
		public void FillNestedProps()
		{
			TestObject to = new TestObject();
			to.nested = new TestObject.NestedObject();
			to.nested.p3 = 20;
			to.nested.p4 = "cd";

			Assert.AreEqual(to.nested.p3.ToString(),
				PropertyExtractor.Extract("nested.p3", to));
			Assert.AreEqual(to.nested.p4.ToString(),
				PropertyExtractor.Extract("nested.p4", to));
		}
	}
}
