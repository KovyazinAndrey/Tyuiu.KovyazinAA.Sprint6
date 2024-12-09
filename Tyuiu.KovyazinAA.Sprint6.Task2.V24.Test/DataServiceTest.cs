using Tyuiu.KovyazinAA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task2.V24.Test
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
            double[] wait = new double[] { 20.364, 15.422, 10.992, 7.432, 0, 1, 0, -8.87, -13.025, -16.528, -19.596 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}