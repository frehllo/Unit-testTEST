using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Addizione()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Addizione(10, 10);
            Assert.AreEqual(res, 20);
        }
        public void Test_Sottrazione()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Sottrazione(10, 10);
            Assert.AreEqual(res, 0);
        }
        public void Test_Moltiplicazioni()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Moltiplicazione(10, 10);
            Assert.AreEqual(res, 100);
        }
        public void Test_Divisione()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Divisione(10, 2);
            Assert.AreEqual(res, 5);
        }
}
