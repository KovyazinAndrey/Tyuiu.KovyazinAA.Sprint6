using Tyuiu.KovyazinAA.Sprint6.Task5.V1.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
