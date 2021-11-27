using cicdExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cicdTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Helper.GetDescription(-1), "FREEZING");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Helper.GetDescriptionToLower(-1), "freezing");
        }
    }
}
