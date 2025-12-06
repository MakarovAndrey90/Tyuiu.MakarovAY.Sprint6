using Tyuiu.MakarovAY.Sprint6.Task3.V2.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task3.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5] { { -12, -4, -20, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;
            dataGridViewMatrix.ColumnCount = colums;
            dataGridViewMatrix.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 54;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mas2[i, j]);
                }
            }
        }
        private void groupBoxRes_MAY_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Копируем исходный массив, чтобы не менять оригинал
                int[,] resultArray = ds.Calculate(mas2);
                int rows = resultArray.GetUpperBound(0) + 1;
                int colums = resultArray.Length / rows;
                dataGridViewResult_MAY.ColumnCount = colums;
                dataGridViewResult_MAY.RowCount = rows;
                for (int i = 0; i < colums; i++)
                {
                    dataGridViewResult_MAY.Columns[i].Width = 54;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        dataGridViewResult_MAY.Rows[i].Cells[j].Value = Convert.ToString(resultArray[i, j]);
                    }
                }
                MessageBox.Show("Чётные значения в первой строке заменены на 0",
                               "Готово",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void buttonHelpClick_MAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
