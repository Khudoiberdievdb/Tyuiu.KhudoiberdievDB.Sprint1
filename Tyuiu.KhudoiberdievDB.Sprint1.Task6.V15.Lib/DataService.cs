using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            
            int CountLetter = 0;
            int CountOther = 0;
           

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    CountLetter++;
                }
                else
                {
                    CountOther++;
                }
                
            }
            
            
            if (CountLetter > CountOther)
            {
                Console.WriteLine("В тексте больше букв чем символов!");
            }
            else
            {
                Console.WriteLine("В тексте больше символов чем букв!");

            }
            return true;
             
           

        }
    }
}
