using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            
            double numerator = 2 * Math.Pow(x, 2) - 1;
            double denominator = Math.Sqrt(Math.Pow(x, 2) - 2);
            double y = Math.Round(numerator / denominator, 3);
            
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}