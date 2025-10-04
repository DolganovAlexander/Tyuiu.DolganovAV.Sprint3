using Tyuiu.DolganovAV.Sprint3.Task0.V27.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 13;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(16.016, res);
        }
    }
}
