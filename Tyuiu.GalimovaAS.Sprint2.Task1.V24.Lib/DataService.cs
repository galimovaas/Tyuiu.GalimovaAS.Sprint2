using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovaAS.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c - 3 < d);
            res[1] = (a > b) & (c - 3 > d);
            res[2] = (a == b) || (c + 82 == d);
            res[3] = (a > b) && (c - 3 > d);
            res[4] = !(!res[0]);
            res[5] = (a == b) ^ (c - 3 < d);

            return res;
        }
    }
}
