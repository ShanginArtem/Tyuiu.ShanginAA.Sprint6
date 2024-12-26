using Tyuiu.ShanginAA.Sprint6.Task6.V26.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\msi\source\repos\Tyuiu.ShanginAA.Sprint6\Tyuiu.ShanginAA.Sprint6.Task6.V26\bin\Debug\InPutDataFileTask6V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}