using Tyuiu.KovyazinAA.Sprint6.Task0.V16.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 3.111;
            Assert.AreEqual(wait, res);
        }
    }
}