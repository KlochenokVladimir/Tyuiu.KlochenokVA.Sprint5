using Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V1.txt");
            File.WriteAllText(inputPath, "123 Привет, это тестовая строка 456.");

            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            string expected = " Привет, это тестовая строка .";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();

            string inputPath = Path.Combine(Path.GetTempPath(), "testInput.txt");
            File.WriteAllText(inputPath, "abc123def456");

            string outputPath = ds.LoadDataAndSave(inputPath);

            FileInfo fileInfo = new FileInfo(outputPath);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}