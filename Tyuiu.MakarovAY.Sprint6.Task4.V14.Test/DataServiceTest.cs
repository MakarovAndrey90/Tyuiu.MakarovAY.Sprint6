using Tyuiu.MakarovAY.Sprint6.Task4.V14.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task4.V14.Test
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
            double[] wait = { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11  };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
