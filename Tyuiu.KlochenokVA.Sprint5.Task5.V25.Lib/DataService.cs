using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string content = File.ReadAllText(path);
            string[] values = content.Split(new char[] { ' ', '\n', '\r', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

            double product = 1.0;
            bool hasRealNumbers = false;

            foreach (string value in values)
            {
                if (double.TryParse(value.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    
                    if (number != Math.Floor(number))
                    {
                        product *= number;
                        hasRealNumbers = true;
                    }
                }
            }

            if (!hasRealNumbers)
            {
                return 0;
            }

            return Math.Round(product, 3);
        }
    }
}