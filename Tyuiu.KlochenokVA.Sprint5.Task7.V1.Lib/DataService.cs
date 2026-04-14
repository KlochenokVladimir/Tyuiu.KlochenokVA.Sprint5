using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\PC\source\repos\Tyuiu.KlochenokVA.Sprint5\Tyuiu.KlochenokVA.Sprint5.Task7.V1\bin\Debug\net8.0\OutPutDataFileTask7V1.txt";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }

            string data = File.ReadAllText(path);

            data = Regex.Replace(data, @"\d", "");

            data = data.Replace(".", "");

            string outpath = Path.GetTempFileName();

            File.WriteAllText(outpath, data);

            return outpath;
        }
    }
}