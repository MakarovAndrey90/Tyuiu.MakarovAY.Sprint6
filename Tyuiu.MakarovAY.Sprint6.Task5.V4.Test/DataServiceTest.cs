using System.Text;
using Tyuiu.MakarovAY.Sprint6.Task5.V4.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string inputPath = Path.GetTempFileName();
            // Используем запятые для десятичных чисел
            File.WriteAllText(inputPath, "1,23456\n2,5\n3\n4,78901", Encoding.UTF8);

            double[] result = ds.LoadFromDataFile(inputPath);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Length); // 3 вещественных числа (3 остается целым)

            Assert.AreEqual(1.235, result[0], 0.001);
            Assert.AreEqual(2.5, result[1]);
            Assert.AreEqual(4.789, result[2], 0.001);

            File.Delete(inputPath);
        }
    }
}
