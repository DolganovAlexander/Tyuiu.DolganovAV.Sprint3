using Tyuiu.DolganovAV.Sprint3.Task1.V16.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 15;

            Assert.AreEqual(15.948, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
