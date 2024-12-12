using Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();





            int number = 123;

            int wait = 6;




            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res);

        }
    }
}