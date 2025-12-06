using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.MakarovAY.Sprint6.Task4.V14.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_MAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void textBoxStartStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep.Text);
                int stop = Convert.ToInt32(textBoxStopStep.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value;
                value = new double[len];
                value = ds.GetMassFunction(start, stop);
                this.chartFunction_MAY.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MAY.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_MAY.Text = "";
                chartFunction_MAY.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_MAY.Series[0].Points.AddXY(start, value[i]);
                    textBoxResult_MAY.AppendText(value[i] + Environment.NewLine);
                    start++;

                }
            }
            catch
            {
                MessageBox.Show("Введите целое число в поле X!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_MAY_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSafe_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V14.txt";
                File.WriteAllText(path, textBoxResult_MAY.Text);
                DialogResult = DialogResult = MessageBox.Show("Файл " + path + " успешно сохранен!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information );
                if (DialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch 
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
    }
    }
}
