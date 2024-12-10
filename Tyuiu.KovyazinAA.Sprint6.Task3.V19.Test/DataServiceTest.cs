using Tyuiu.KovyazinAA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { 4, 32, -20, 27, 21 },
                                      { 17, 15, -1, -2, -1 },
                                      { -3, 18, 12, -10, 29 },
                                      { 7, -15, 2, -8, 12 },
                                      { -10, 25, 5, 27, 21 }};
            int[,] res = ds.Calculate(mtrx);
            int[] finalres = new int[] { res[0, 4], res[1, 4], res[2, 4], res[3, 4], res[4, 4] };
            int[] wait = new int[] { -1, 12, 21, 21, 29 };
            CollectionAssert.AreEqual(wait, finalres);
        }
    }
}