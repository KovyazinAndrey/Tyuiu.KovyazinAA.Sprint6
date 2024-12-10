using Tyuiu.KovyazinAA.Sprint6.Task4.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = { 3.63, -11.7, -14.02, -5.24, 1.32, 0, -1.32, 5.24, 14.02, 11.7, -3.63 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}