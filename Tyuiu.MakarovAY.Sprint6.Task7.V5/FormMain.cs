using Tyuiu.MakarovAY.Sprint6.Task7.V5.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath) 
        {
            string FileData = File.ReadAllText(filePath);
            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
           rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int r = 0; r < rows; r++) 
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_MAY_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutPut_MAY_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonInformation_MAY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonInputFile_MAY_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_MAY1.ColumnCount = cols;
            dataGridViewIn_MAY1.RowCount = rows;
            dataGridViewOut_MAY1.ColumnCount = cols;
            dataGridViewOut_MAY1.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn_MAY1.Columns[i].Width = 25;
                dataGridViewOut_MAY1.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn_MAY1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonDoneOpenFile_MAY.Enabled = true;
        }

        private void button2OpenFile_MAY_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++) 
            {
                for (int c = 0; c < cols; c++) 
                {
                    dataGridViewOut_MAY1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSafeFile_MAY.Enabled = true;

        }

        private void buttonSafeFile_MAY_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_MAY1.Rows.Count;
            int cols = dataGridViewOut_MAY1.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < cols; j++) 
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOut_MAY1.Rows[i].Cells[j].Value + ";";
                    }
                    else 
                    {
                        str = str + dataGridViewOut_MAY1.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }

        }
    }
}
