using Tyuiu.DolganovAV.Sprint3.Task6.V6.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            Assert.AreEqual(11, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}
