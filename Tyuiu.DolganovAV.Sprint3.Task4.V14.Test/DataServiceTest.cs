using Tyuiu.DolganovAV.Sprint3.Task4.V14.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(6.263, res);
        }
    }
}
