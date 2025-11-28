using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((1.0 / Math.Cos(x)) + 2.2 * Math.Pow(x, 2), 3);
            return res;
        }
    }
}