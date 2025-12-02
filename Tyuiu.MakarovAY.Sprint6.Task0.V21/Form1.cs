using Tyuiu.MakarovAY.Sprint6.Task0.V21.Lib;
namespace Tyuiu.MakarovAY.Sprint6.Task0.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxVarX.Text);
                DataService ds = new DataService();
                double result = ds.Calculate(x);
                TextBoxRes.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введите целое число в поле X!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxRes_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonHelpClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППБ25-1 Макаров Андрей Ярославович",
                    "Информация о студенте",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
