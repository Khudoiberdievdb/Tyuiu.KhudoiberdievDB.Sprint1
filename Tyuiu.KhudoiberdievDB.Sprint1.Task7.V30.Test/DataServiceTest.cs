using Tyuiu.KhudoiberdievDB.Sprint1.Task7.V30.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 5.472;
            var res = ds.Calculate(x,y);
            Math.Round(res, 3);
            Assert.AreEqual(wait,res);
        }
    }
}