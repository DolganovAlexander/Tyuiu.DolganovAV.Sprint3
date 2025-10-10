using Tyuiu.DolganovAV.Sprint3.Task5.V22.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            var res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            Assert.AreEqual(4.991, res);
        }
    }
}
