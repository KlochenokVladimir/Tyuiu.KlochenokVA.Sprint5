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
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            int russianWordsCount = 0;

            foreach (string word in words)
            {
                bool isRussianWord = false;
                foreach (char c in word)
                {
                    if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'ё' || c == 'Ё')
                    {
                        isRussianWord = true;
                        break;
                    }
                }

                if (isRussianWord)
                {
                    russianWordsCount++;
                }
            }

            return russianWordsCount;
        }
    }
}