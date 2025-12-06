using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MakarovAY.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                res[count] = Math.Round(2 * x - 4.0 + (2.0 * x - 1.0) / (Math.Sin(x) + 1.0), 2);
                count++;
            }
            return res;
        }
    }
}
