﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {

            return ((number / 100) * (number / 10 % 10) * (number % 10));
        }
    }
}


