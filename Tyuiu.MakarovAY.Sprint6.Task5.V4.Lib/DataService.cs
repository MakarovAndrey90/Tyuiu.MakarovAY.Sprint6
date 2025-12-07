using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MakarovAY.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Заменяем точку на запятую
                    line = line.Replace(".", ",");

                    // Разбиваем строку на отдельные числа
                    string[] tokens = line.Split(new char[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string token in tokens)
                    {
                        if (double.TryParse(token, out double value))
                        {
                            numbers.Add(value);
                        }
                    }
                }
            }

            // Округляем вещественные числа
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i] % 1) > 0.0000001) // если вещественное
                {
                    numbers[i] = Math.Round(numbers[i], 3);
                }
            }

            return numbers.ToArray();
        }
    }
}
