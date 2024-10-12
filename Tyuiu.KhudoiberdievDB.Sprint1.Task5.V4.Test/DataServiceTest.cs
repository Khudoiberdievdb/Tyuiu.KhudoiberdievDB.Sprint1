using Tyuiu.KhudoiberdievDB.Sprint1.Task5.V4.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 6653;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(time);
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);

        }
    }
}