using Tyuiu.KhudoiberdievDB.Sprint1.Task6.V15.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public bool ValidString()
        {
            string strTest = "пароль - Маруся_99";
            DataService ds = new DataService();
            return ds.CheckLettersCount(strTest);
        }
    }
}