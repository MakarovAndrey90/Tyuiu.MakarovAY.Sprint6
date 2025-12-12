using Tyuiu.MakarovAY.Sprint6.Task7.V5.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\InPutFileTask7V5.txt";
            if (File.Exists(path))
            {
                int[,] result = ds.GetMatrix(path);
                Assert.IsNotNull(result);
            }
        }
    }
}
