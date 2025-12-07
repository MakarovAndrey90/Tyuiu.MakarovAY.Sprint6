using Tyuiu.MakarovAY.Sprint6.Task6.V17.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\InPutFileTask6V17.txt";
            if (File.Exists(path))
            {
                string result = ds.CollectTextFromFile(path);
                Assert.IsNotNull(result);
            }
        }
    }
}
