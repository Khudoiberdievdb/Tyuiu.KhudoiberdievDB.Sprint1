﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double res = (x + Math.Pow(Math.E, x)) + ((Math.Pow(Math.Sin(x), 5) + Math.Pow(x, 3))) / (Math.Pow(3, x)) + (Math.Pow(y, 5)) / (Math.Pow(5, y));
            return Math.Round(res,3);


        }
    }
}
