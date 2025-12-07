namespace Tyuiu.MakarovAY.Sprint6.Task6.V17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonHelpClick = new Button();
            buttonDone_MAY = new Button();
            buttonOpenFIle_MAY = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            groupBoxOpenFile_MAY = new GroupBox();
            textBoxCondition_MAY = new TextBox();
            panel3 = new Panel();
            groupBoxCondition_MAY = new GroupBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            groupBoxResult_MAY = new GroupBox();
            textBoxResult_MAY = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask_MAY = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOpenFile_MAY.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxCondition_MAY.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxResult_MAY.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelpClick);
            panel1.Controls.Add(buttonDone_MAY);
            panel1.Controls.Add(buttonOpenFIle_MAY);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 84);
            panel1.TabIndex = 0;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelpClick.Cursor = Cursors.Hand;
            buttonHelpClick.Image = (Image)resources.GetObject("buttonHelpClick.Image");
            buttonHelpClick.Location = new Point(878, 12);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(75, 60);
            buttonHelpClick.TabIndex = 2;
            toolTip3.SetToolTip(buttonHelpClick, "Сведения о программе");
            buttonHelpClick.UseVisualStyleBackColor = true;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // buttonDone_MAY
            // 
            buttonDone_MAY.Cursor = Cursors.Hand;
            buttonDone_MAY.Image = Properties.Resources.page_go;
            buttonDone_MAY.Location = new Point(121, 12);
            buttonDone_MAY.Name = "buttonDone_MAY";
            buttonDone_MAY.Size = new Size(75, 60);
            buttonDone_MAY.TabIndex = 1;
            toolTip2.SetToolTip(buttonDone_MAY, "производит поиск файла, загружает его ");
            buttonDone_MAY.UseVisualStyleBackColor = true;
            buttonDone_MAY.Click += buttonDone_MAY_Click;
            // 
            // buttonOpenFIle_MAY
            // 
            buttonOpenFIle_MAY.Cursor = Cursors.Hand;
            buttonOpenFIle_MAY.Image = Properties.Resources.folder_page_white;
            buttonOpenFIle_MAY.Location = new Point(40, 12);
            buttonOpenFIle_MAY.Name = "buttonOpenFIle_MAY";
            buttonOpenFIle_MAY.Size = new Size(75, 60);
            buttonOpenFIle_MAY.TabIndex = 1;
            toolTip1.SetToolTip(buttonOpenFIle_MAY, "Открыть файл. Выберите нужный файл для обработки\r\n\r\n\r\n");
            buttonOpenFIle_MAY.UseVisualStyleBackColor = true;
            buttonOpenFIle_MAY.Click += buttonOpenFIle_MAY_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(230, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOpenFile_MAY);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 440);
            panel2.TabIndex = 0;
            // 
            // groupBoxOpenFile_MAY
            // 
            groupBoxOpenFile_MAY.Controls.Add(textBoxCondition_MAY);
            groupBoxOpenFile_MAY.Dock = DockStyle.Fill;
            groupBoxOpenFile_MAY.Location = new Point(0, 0);
            groupBoxOpenFile_MAY.Name = "groupBoxOpenFile_MAY";
            groupBoxOpenFile_MAY.Size = new Size(458, 440);
            groupBoxOpenFile_MAY.TabIndex = 0;
            groupBoxOpenFile_MAY.TabStop = false;
            groupBoxOpenFile_MAY.Text = "Ввод";
            // 
            // textBoxCondition_MAY
            // 
            textBoxCondition_MAY.Dock = DockStyle.Bottom;
            textBoxCondition_MAY.Location = new Point(3, 41);
            textBoxCondition_MAY.Multiline = true;
            textBoxCondition_MAY.Name = "textBoxCondition_MAY";
            textBoxCondition_MAY.ReadOnly = true;
            textBoxCondition_MAY.ScrollBars = ScrollBars.Vertical;
            textBoxCondition_MAY.Size = new Size(452, 396);
            textBoxCondition_MAY.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxCondition_MAY);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 87);
            panel3.TabIndex = 0;
            // 
            // groupBoxCondition_MAY
            // 
            groupBoxCondition_MAY.Controls.Add(textBox1);
            groupBoxCondition_MAY.Dock = DockStyle.Fill;
            groupBoxCondition_MAY.Location = new Point(0, 0);
            groupBoxCondition_MAY.Name = "groupBoxCondition_MAY";
            groupBoxCondition_MAY.Size = new Size(984, 87);
            groupBoxCondition_MAY.TabIndex = 0;
            groupBoxCondition_MAY.TabStop = false;
            groupBoxCondition_MAY.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(978, 65);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxResult_MAY);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(458, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(526, 440);
            panel4.TabIndex = 0;
            // 
            // groupBoxResult_MAY
            // 
            groupBoxResult_MAY.Controls.Add(textBoxResult_MAY);
            groupBoxResult_MAY.Dock = DockStyle.Fill;
            groupBoxResult_MAY.Location = new Point(0, 0);
            groupBoxResult_MAY.Name = "groupBoxResult_MAY";
            groupBoxResult_MAY.Size = new Size(526, 440);
            groupBoxResult_MAY.TabIndex = 0;
            groupBoxResult_MAY.TabStop = false;
            groupBoxResult_MAY.Text = "Вывод";
            // 
            // textBoxResult_MAY
            // 
            textBoxResult_MAY.Dock = DockStyle.Bottom;
            textBoxResult_MAY.Location = new Point(3, 41);
            textBoxResult_MAY.Multiline = true;
            textBoxResult_MAY.Name = "textBoxResult_MAY";
            textBoxResult_MAY.ReadOnly = true;
            textBoxResult_MAY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MAY.Size = new Size(520, 396);
            textBoxResult_MAY.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(458, 171);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 440);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_MAY
            // 
            openFileDialogTask_MAY.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Подсказка";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Информация";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxOpenFile_MAY.ResumeLayout(false);
            groupBoxOpenFile_MAY.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxCondition_MAY.ResumeLayout(false);
            groupBoxCondition_MAY.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxResult_MAY.ResumeLayout(false);
            groupBoxResult_MAY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBoxCondition_MAY;
        private Panel panel4;
        private Splitter splitter1;
        private TextBox textBox1;
        private GroupBox groupBoxOpenFile_MAY;
        private TextBox textBoxCondition_MAY;
        private GroupBox groupBoxResult_MAY;
        private TextBox textBoxResult_MAY;
        private Button buttonDone_MAY;
        private Button buttonOpenFIle_MAY;
        private Button buttonHelpClick;
        private OpenFileDialog openFileDialogTask_MAY;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
    }
}
