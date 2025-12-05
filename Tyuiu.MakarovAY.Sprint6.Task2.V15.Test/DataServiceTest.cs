using Tyuiu.MakarovAY.Sprint6.Task2.V15.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
