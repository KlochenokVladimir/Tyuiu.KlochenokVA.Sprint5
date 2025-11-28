using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            string result = "";

            foreach (char c in content)
            {
                if (!char.IsDigit(c))
                {
                    result += c;
                }
            }

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");
            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}