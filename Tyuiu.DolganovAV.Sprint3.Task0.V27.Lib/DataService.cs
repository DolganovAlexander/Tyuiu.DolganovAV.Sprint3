using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAV.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sum = sum + Math.Pow((4/Math.Pow(i,value)),2);
            }
            return Math.Round(sum, 3);
        }
    }
}
