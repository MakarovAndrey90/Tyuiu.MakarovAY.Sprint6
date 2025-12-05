using System.Linq.Expressions;
using Tyuiu.MakarovAY.Sprint6.Task2.V15.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task2.V15
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEndStep_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep.Text);
                int stop = Convert.ToInt32(textBoxEndStep.Text);
                double[] array = ds.GetMassFunction(start, stop);
                int len = array.Length;
                this.dataGridView1.Rows.Clear();
                Grafik.Plot.Clear();
                List<double> xValues = new List<double>();
                List<double> yValues = new List<double>();
                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(start.ToString(), array[i].ToString());
                    xValues.Add(start);
                    yValues.Add(array[i]);
                    start++;
                }
                Grafik.Plot.Add.Scatter(xValues.ToArray(), yValues.ToArray());
                Grafik.Plot.Title("График функции");
                Grafik.Plot.XLabel("Ось X");
                Grafik.Plot.YLabel("Ось Y");
                Grafik.Refresh();
            }
            catch 
            {
                MessageBox.Show("Введите целое число в поле X!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelpClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
