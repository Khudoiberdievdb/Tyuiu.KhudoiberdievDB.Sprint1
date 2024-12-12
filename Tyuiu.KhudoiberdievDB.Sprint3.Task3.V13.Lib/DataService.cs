using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int a = (int)number / 100; int c = (int)number % 10; int b = ((int)number % 100) / 10;
            int m = a * b * c;
            return m;


        }
    }
}


