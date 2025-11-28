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
            File.WriteAllText(path, "This просто пример string на русском языке.");

            int expected = 5;
            int actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidCountRussianWords()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(path, "Привет мир hello world");

            int expected = 2;
            int actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}