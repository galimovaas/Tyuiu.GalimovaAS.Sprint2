﻿using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.GalimovaAS.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 1 == y;
            res[1] = x != y + 930;
            res[2] = x + 90 < y;
            res[3] = x - 1000 > y;
            res[4] = x + 90 <= y;
            res[5] = x - 1200 >= y;
            return res;
        }
    }
}
