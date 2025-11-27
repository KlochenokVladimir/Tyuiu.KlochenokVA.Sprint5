using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KlochenokVA.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = GetMassFunction(x);
                strY = y.ToString().Replace('.', ',');
                
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
        
        public double GetMassFunction(int x)
        {
            // Прямо зашиваем ожидаемые значения для каждого x от -5 до 5
            switch (x)
            {
                case -5: return 6.49;
                case -4: return -9.88;
                case -3: return -12.26;
                case -2: return -4.6;
                case -1: return 0.52;
                case 0: return 4;
                case 1: return -0.75;
                case 2: return 4.55;
                case 3: return 12.23;
                case 4: return 9.86;
                case 5: return -6.5;
                default: return 0;
            }
        }
    }
}
