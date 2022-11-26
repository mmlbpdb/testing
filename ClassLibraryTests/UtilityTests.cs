using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Tests
{
	[TestClass()]
	public class UtilityTests
	{
		[TestMethod()]
		public void ToUpperTest()
		{
			var result = Utility.ToUpper("a");
			Assert.AreEqual("A", result);
		}
	}
}