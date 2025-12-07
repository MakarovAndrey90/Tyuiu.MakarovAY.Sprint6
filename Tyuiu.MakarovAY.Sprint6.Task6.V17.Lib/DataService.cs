using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MakarovAY.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        // Добавляем КАЖДОЕ третье слово (индексы 2, 5, 8...)
                        for (int i = 2; i < words.Length; i += 3)
                        {
                            resStr += (words[i] + " ");
                        }
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
