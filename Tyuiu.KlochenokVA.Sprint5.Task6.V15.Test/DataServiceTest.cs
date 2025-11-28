using Tyuiu.KlochenokVA.Sprint5.Task6.V15.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V15.txt");
            File.WriteAllText(path, "abc123def456");

            int expected = 6;
            int actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidCountDigits()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(path, "Hello123World456!");

            int expected = 6;
            int actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}