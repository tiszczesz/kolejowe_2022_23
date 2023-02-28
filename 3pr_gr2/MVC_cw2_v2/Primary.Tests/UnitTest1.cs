using MVC_cw2_v2.Models;

namespace Primary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrimal()
        {
            PrimaryGenerator pg = new PrimaryGenerator();
            var result = pg.IsPrimal(4);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestIsPrimal2()
        {
            PrimaryGenerator pg = new PrimaryGenerator();
            var result = pg.IsPrimal(47);
            Assert.IsTrue(result);
        }
    }
}