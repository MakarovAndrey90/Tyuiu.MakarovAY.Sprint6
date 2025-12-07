using Tyuiu.MakarovAY.Sprint6.Task6.V17.Lib;

namespace Tyuiu.MakarovAY.Sprint6.Task6.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_MAY_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult_MAY.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonOpenFIle_MAY_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAY.ShowDialog();
            openFilePath = openFileDialogTask_MAY.FileName;
            textBoxCondition_MAY.Text = File.ReadAllText(openFilePath);
            groupBoxOpenFile_MAY.Text = groupBoxOpenFile_MAY.Text + " " + openFileDialogTask_MAY.FileName;
            buttonDone_MAY.Enabled = true;
        }

        private void buttonHelpClick_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
