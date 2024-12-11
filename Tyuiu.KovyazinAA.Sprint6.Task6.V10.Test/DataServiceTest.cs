using Tyuiu.KovyazinAA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.KovyazinAA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = " nXkwQYzgZ tsCms LlckTwkpaAGTvLPc dlezsxTS z KxFxadaTMeBz BRW pSuA";
            string res = ds.CollectTextFromFile(@"C:\DataSprint6\InPutDataFileTask6V10.txt");
            Assert.AreEqual(wait, res);
        }
    }
}
