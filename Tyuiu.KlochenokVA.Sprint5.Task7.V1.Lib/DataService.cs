namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

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