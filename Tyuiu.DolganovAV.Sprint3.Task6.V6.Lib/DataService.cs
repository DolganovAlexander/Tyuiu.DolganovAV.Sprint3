using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAV.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 10) count++;
                    }
                }
            }
            return count;
        }
    }
}
