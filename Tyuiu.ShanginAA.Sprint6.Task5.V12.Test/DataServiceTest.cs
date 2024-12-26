using Tyuiu.ShanginAA.Sprint6.Task5.V12.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] paths = { @"c:\Users", "msi", "source", "repos", "Tyuiu.ShanginAA.Sprint6", "Tyuiu.ShanginAA.Sprint6.Task5.V12", "bin", "Debug", "InPutDataFileTask5V12.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}