using Tyuiu.ShanginAA.Sprint6.Task4.V2.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\msi\source\repos\Tyuiu.ShanginAA.Sprint6\Tyuiu.ShanginAA.Sprint6.Task4.V2\bin\Debug\net8.0-windows\OutPutFileTask4V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}