using Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask7V1.txt" });
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);




        }
    }
}