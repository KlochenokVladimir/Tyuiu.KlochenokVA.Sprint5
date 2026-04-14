using Tyuiu.KlochenokVA.Sprint5.Task1.V19.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\PC\source\repos\Tyuiu.KlochenokVA.Sprint5\Tyuiu.KlochenokVA.Sprint5.Task7.V1\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
