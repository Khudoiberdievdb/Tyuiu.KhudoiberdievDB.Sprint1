namespace Tyuiu.KhudoiberdievDB.Sprint1.SprintRewiew.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #SprintRewiew                                                        *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение :             *");
            Console.WriteLine("* ln|cosx|/ln(1+x^2)                                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите значение Х :");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = Math.Log(Math.Abs(Math.Cos(x))) / (Math.Log(Math.Abs(1 + Math.Pow(x, 2))));

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(Math.Round(res,3));
            Console.ReadKey();

        }
    }
}
