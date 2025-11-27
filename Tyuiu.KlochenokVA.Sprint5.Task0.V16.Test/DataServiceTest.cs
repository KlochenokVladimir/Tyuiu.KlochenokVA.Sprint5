using Tyuiu.KlochenokVA.Sprint5.Task0.V16.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            
            string path = ds.SaveToFileTextData(3);
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}