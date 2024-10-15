using Tyuiu.GalimovaAS.Sprint2.Task1.V24.Lib;
namespace Tyuiu.GalimovaAS.Sprint2.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Логические операции                                                       *");
            Console.WriteLine("* Задание #1                                                                      *");
            Console.WriteLine("* Вариант #24                                                                     *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                           *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                 *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)      *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не       *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет            *");
            Console.WriteLine("* логическую последовательность(массив): (True, False, False, False, True, False) *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.WriteLine(" c = " + c);
            Console.WriteLine(" d = " + d);

            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                       *");
            Console.WriteLine("***********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
