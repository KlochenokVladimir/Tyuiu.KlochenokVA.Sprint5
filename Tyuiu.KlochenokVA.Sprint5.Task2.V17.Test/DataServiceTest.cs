using Tyuiu.KlochenokVA.Sprint5.Task2.V17.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidReplaceOddNumbers()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 2, 1, 7 },
                             { 1, 2, 4 },
                             { 2, 3, 4 } };

            string path = ds.SaveToFileTextData(matrix);
            string fileContent = File.ReadAllText(path);

            string expected = "2;0;0" + Environment.NewLine + "0;2;4" + Environment.NewLine + "2;0;4";
            Assert.AreEqual(expected, fileContent);
        }
    }
}