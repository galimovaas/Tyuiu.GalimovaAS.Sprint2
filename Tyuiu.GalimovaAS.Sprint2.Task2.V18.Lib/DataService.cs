using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovaAS.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;

            if ((x >= 2) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                if ((x == 2) && (y >= 6) && (y <= 7))
                {
                    return a = true;
                }
                if ((x == 3) && (y >= 3) && (y <= 7) || (y == 11))
                {
                    return a = true;
                }
                if ((x == 4) && (y >= 3) && (y <= 7) || (y == 11))
                {
                    return a = true;
                }
                if ((x == 5) && (y >= 3) && (y <= 7) || (y == 11))
                {
                    return a = true;
                }
                if ((x == 6) && (y >= 5) && (y <= 11))
                {
                    return a = true;
                }
                if ((x == 7) && (y >= 5) && (y <= 12))
                {
                    return a = true;
                }
                if ((x == 8) && (y >= 5) && (y <= 9))
                {
                    return a = true;
                }
                if ((x == 9) && (y >= 8) && (y <= 9))
                {
                    return a = true;
                }
                if ((x == 10) && (y >= 8) && (y <= 9))
                {
                    return a = true;
                }
                if ((x == 11) && (y >= 8) && (y <= 11))
                {
                    return a = true;
                }
                if ((x == 12) && (y >= 3) && (y <= 11))
                {
                    return a = true;
                }
                if ((x == 13) && (y >= 6) && (y <= 8))
                {
                    return a = true;
                }
                return a;
            }
            else
            {
                return false;
            }
        
        }

    }
}
