using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.MakarovAY.Sprint6.Task2.V15.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3.0 * x + 1.2) == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round(((2.0 * Math.Sin(x) / (3.0 * x + 1.2)) + Math.Cos(x) - 7.0 * x * 2.0), 2);
                    count++;
                }
            }
            return res;
        }
    }
}
