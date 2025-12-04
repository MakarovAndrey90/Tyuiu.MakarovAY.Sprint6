using Tyuiu.MakarovAY.Sprint6.Task1.V21.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task1.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelpClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void buttonAction_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |    f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введите целое число в поле X!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStopStep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
