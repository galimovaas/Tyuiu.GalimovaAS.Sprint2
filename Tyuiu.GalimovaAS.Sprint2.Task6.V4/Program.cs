using Tyuiu.GalimovaAS.Sprint2.Task6.V4.Lib;
namespace Tyuiu.GalimovaAS.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Галимова А.С. | АСОиУб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Получение результата из switch                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #4                                                                        *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна   | АСОиУб-23-1                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите номер масти:");
            int numCard= Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numCard < 1) || (numCard > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Название масти: " + ds.FindCardSuit(numCard);

                Console.WriteLine("*************************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
                Console.WriteLine("*************************************************************************************");

                Console.WriteLine($"Полное название: {ds.FindCardSuit}");

                Console.ReadKey();
            }
        }
    }
}
