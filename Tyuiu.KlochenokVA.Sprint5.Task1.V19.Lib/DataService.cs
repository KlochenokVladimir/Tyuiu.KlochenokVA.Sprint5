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
                strY = Convert.ToString(y);
                
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
            double y = Math.Round(Math.Sin(x) + (2.0 / 3.0) * x + 0.5 - 2 * Math.Cos(x) * 2 * x, 2);
            return y;
        }
    }
}
