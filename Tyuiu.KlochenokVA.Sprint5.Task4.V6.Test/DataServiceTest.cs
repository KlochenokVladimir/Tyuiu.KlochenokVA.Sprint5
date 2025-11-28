using Tyuiu.KlochenokVA.Sprint5.Task4.V6.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V6.txt");
            File.WriteAllText(path, "1");

            double wait = Math.Round((1.0 / Math.Cos(1)) + 2.2 * Math.Pow(1, 2), 3);
            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}