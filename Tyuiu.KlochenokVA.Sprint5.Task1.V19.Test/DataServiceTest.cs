using Tyuiu.KlochenokVA.Sprint5.Task1.V19.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            
            string path = ds.SaveToFileTextData(-5, 5);
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
        
        [TestMethod]
        public void ValidCalculationCheck()
        {
            DataService ds = new DataService();
            int testX = 0;
            
            double expected = Math.Round(Math.Sin(testX) + (2.0 / 3.0) * testX + 0.5 - 2 * Math.Cos(testX) * 2 * testX, 2);
            double actual = ds.GetMassFunction(testX);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
