using Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #13                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int number;
            Console.WriteLine("Введите значение числа ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("Произведение цифр заданного трехзначного числа равно - " + ds.MultiplyOfDigits(number));
            Console.ReadLine();
        }
    }
}



