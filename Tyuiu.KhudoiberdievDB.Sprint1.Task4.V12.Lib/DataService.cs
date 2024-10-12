using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task4.V12.Lib
{
    public class DataService : ISprint1Task4V12
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Sin(x) / (x + (Math.Sqrt(Math.Abs(y))));
            res = Math.Round(res, 3);
            return res;

        }
    }
}
