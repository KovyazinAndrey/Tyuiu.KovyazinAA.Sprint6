using Tyuiu.KovyazinAA.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task1.V21.Test
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
            double[] wait = new double[] { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.6 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}