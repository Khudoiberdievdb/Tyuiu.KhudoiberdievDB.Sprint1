using Tyuiu.KhudoiberdievDB.Sprint1.Task4.V12.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
           
            double x = 90;
            double y = 4;
            double wait = 0.01;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            



        }
    }
}