using Tyuiu.KlochenokVA.Sprint5.Task5.V25.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V25.txt");
            File.WriteAllText(path, "2.5 3.0 1.2");

            double expected = Math.Round(2.5 * 3.0 * 1.2, 3);
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidCalculateProduct()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(path, "1.5\n2.0\n3.0");

            double expected = 9.0;
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}