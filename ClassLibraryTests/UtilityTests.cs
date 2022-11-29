namespace ClassLibrary.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

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