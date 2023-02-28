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
        [TestMethod]
        public void TestIsPrimal3()
        {
            PrimaryGenerator pg = new PrimaryGenerator();
            int limit = 10;
            List<int> result = pg.GetPrimals(limit);
            Assert.IsTrue(result.Count==4);
        }
        public void TestIsPrimal4()
        {
            PrimaryGenerator pg = new PrimaryGenerator();
            int limit = 10;
            List<int> result = pg.GetPrimals(limit);
            Assert.IsTrue(result[result.Count-1]==7);
        }
    }
}