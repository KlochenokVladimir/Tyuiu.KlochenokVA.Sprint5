using Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}