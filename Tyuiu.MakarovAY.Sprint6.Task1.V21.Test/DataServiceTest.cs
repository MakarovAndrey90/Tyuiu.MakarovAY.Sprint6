using Tyuiu.MakarovAY.Sprint6.Task1.V21.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task1.V21.Test
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
            double[] wait = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.60 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
