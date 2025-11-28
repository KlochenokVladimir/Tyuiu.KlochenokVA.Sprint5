using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string content = File.ReadAllText(path);
            int count = 0;

            foreach (char c in content)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}