using Tyuiu.DolganovAV.Sprint3.Task2.V21.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;
            Assert.AreEqual(0.238, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
