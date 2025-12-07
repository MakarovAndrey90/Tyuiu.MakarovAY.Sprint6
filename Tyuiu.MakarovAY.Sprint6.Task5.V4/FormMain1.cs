using Tyuiu.MakarovAY.Sprint6.Task5.V4.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task5.V4
{
    public partial class FormMain1 : Form
    {
        public FormMain1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V4.txt";
        private void FormMain1_Load(object sender, EventArgs e)
        {

        }

        private void chartdiagram_MAY_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttongetDone_MAY_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 45;
            dataGridViewResult.Columns[1].Width = 139;
            this.chartdiagram_MAY.ChartAreas[0].AxisX.Title = "ось X";
            this.chartdiagram_MAY.ChartAreas[0].AxisY.Title = "ось Y";
            chartdiagram_MAY.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartdiagram_MAY.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_MAY_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
