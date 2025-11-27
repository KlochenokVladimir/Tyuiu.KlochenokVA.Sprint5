using Tyuiu.KlochenokVA.Sprint5.Task1.V19.Lib;

namespace Tyuiu.KlochenokVA.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (sin(x) + 2) / (3x + 0.5) - 2cos(x)              *");
            Console.WriteLine("* (произвести табулирование) на заданном диапазоне [-5; 5] с шагом 1.    *");
            Console.WriteLine("* При х = -3/2, значение функции не определено. Результат сохранить в   *");
            Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            string res = ds.SaveToFileTextData(startValue, stopValue);
            
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", x, ds.GetMassFunction(x));
            }
            Console.WriteLine("+----------+----------+");
            
            Console.ReadKey();
        }
    }
}
