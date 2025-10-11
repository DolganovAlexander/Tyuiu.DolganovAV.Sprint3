using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAV.Sprint3.Task7.V3.Lib
{
        public class DataService : ISprint3Task7V3
        {
            public double[] GetMassFunction(int startValue, int stopValue)
            {
                double[] valueArray;
                int len = stopValue - startValue + 1;
                valueArray = new double[len];
                double y;
                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    var numerator = (3 * x - 1.5);
                    var denominator = (Math.Sin(x) - 3 + x);
                    if (Math.Abs(denominator) < 0) y = 0;
                    else y = Math.Round((numerator / denominator) + 2, 2);
                    valueArray[count] = y;
                    count++;
                }
                return valueArray;
            }
        }
}
