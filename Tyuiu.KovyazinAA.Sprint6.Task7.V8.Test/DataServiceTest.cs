using System.IO;
using Tyuiu.KovyazinAA.Sprint6.Task7.V8.Lib;

namespace Tyuiu.KovyazinAA.Sprint6.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Andrey\source\repos\Tyuiu.KovyazinAA.Sprint6\Tyuiu.KovyazinAA.Sprint6.Task7.V8\bin\Debug\net8.0-windows\OutPutFileTask7.csv";
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }
    }
}
