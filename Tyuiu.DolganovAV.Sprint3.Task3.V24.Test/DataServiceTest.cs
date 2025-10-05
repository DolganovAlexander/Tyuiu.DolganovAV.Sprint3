using Tyuiu.DolganovAV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.DolganovAV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';
            Assert.AreEqual("*ft h**t nt*", ds.ReplaceCharInString(value, replaceable, replacement));
        }
    }
}
