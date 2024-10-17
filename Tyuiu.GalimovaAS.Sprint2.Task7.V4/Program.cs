using Tyuiu.GalimovaAS.Sprint2.Task7.V4.Lib;
namespace Tyuiu.GalimovaAS.Sprint2.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                   *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                     *");
            Console.WriteLine("* Задание #7                                                                                  *");
            Console.WriteLine("* Вариант #4                                                                                  *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна      | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет, находится ли точка     *");
            Console.WriteLine("* с координатоми X,Y в заштрихованной области                                                 *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Введите значение Х = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите значение Y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine(" Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine(" Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
