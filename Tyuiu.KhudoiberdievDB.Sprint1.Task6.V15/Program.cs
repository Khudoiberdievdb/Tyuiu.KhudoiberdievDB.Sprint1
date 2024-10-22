using Tyuiu.KhudoiberdievDB.Sprint1.Task6.V15.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";

Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("Введите строку");
string str = Console.ReadLine();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine(ds.CheckLettersCount(str));
Console.ReadKey();
