using MVC_first_v2.Models;
namespace NWD.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void NWD_REC_RESULT()
		{
			var nwd = new MyNWD();
			nwd.A = 20;
			nwd.B = 16;
			nwd.Count();
			Assert.AreEqual(4, nwd.Result);
		}
		[TestMethod]
		public void NWD_Iter_RESULT2()
		{
			var nwd = new MyNWD();
			nwd.A = 18;
			nwd.B = 12;
			nwd.RecCount();
			Assert.AreEqual(6, nwd.Result);
		}
	}
}