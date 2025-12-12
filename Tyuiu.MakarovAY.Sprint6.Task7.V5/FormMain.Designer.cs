namespace Tyuiu.MakarovAY.Sprint6.Task7.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonInformation_MAY = new Button();
            buttonSafeFile_MAY = new Button();
            buttonDoneOpenFile_MAY = new Button();
            buttonInputFile_MAY = new Button();
            panel2 = new Panel();
            groupBoxCondition_MAY = new GroupBox();
            textBoxCondition_MAY = new TextBox();
            panel3 = new Panel();
            groupBox1InPut_MAY = new GroupBox();
            dataGridViewIn_MAY1 = new DataGridView();
            splitter1 = new Splitter();
            panel4 = new Panel();
            groupBox1OutPut_MAY = new GroupBox();
            dataGridViewOut_MAY1 = new DataGridView();
            toolTip2 = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxCondition_MAY.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1InPut_MAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MAY1).BeginInit();
            panel4.SuspendLayout();
            groupBox1OutPut_MAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MAY1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInformation_MAY);
            panel1.Controls.Add(buttonSafeFile_MAY);
            panel1.Controls.Add(buttonDoneOpenFile_MAY);
            panel1.Controls.Add(buttonInputFile_MAY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 73);
            panel1.TabIndex = 0;
            // 
            // buttonInformation_MAY
            // 
            buttonInformation_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInformation_MAY.Cursor = Cursors.Hand;
            buttonInformation_MAY.FlatStyle = FlatStyle.Flat;
            buttonInformation_MAY.Image = (Image)resources.GetObject("buttonInformation_MAY.Image");
            buttonInformation_MAY.Location = new Point(886, 12);
            buttonInformation_MAY.Name = "buttonInformation_MAY";
            buttonInformation_MAY.Size = new Size(75, 55);
            buttonInformation_MAY.TabIndex = 3;
            toolTip4.SetToolTip(buttonInformation_MAY, "сведения о программе");
            buttonInformation_MAY.UseVisualStyleBackColor = true;
            buttonInformation_MAY.Click += buttonInformation_MAY_Click;
            // 
            // buttonSafeFile_MAY
            // 
            buttonSafeFile_MAY.Cursor = Cursors.Hand;
            buttonSafeFile_MAY.Enabled = false;
            buttonSafeFile_MAY.FlatStyle = FlatStyle.Flat;
            buttonSafeFile_MAY.Image = (Image)resources.GetObject("buttonSafeFile_MAY.Image");
            buttonSafeFile_MAY.Location = new Point(212, 12);
            buttonSafeFile_MAY.Name = "buttonSafeFile_MAY";
            buttonSafeFile_MAY.Size = new Size(75, 55);
            buttonSafeFile_MAY.TabIndex = 2;
            buttonSafeFile_MAY.Text = "\r\n\r\n";
            toolTip3.SetToolTip(buttonSafeFile_MAY, "сохранить обработанные данные в файл в формате CSV");
            buttonSafeFile_MAY.UseVisualStyleBackColor = true;
            buttonSafeFile_MAY.Click += buttonSafeFile_MAY_Click;
            // 
            // buttonDoneOpenFile_MAY
            // 
            buttonDoneOpenFile_MAY.Cursor = Cursors.Hand;
            buttonDoneOpenFile_MAY.Enabled = false;
            buttonDoneOpenFile_MAY.FlatStyle = FlatStyle.Flat;
            buttonDoneOpenFile_MAY.Image = (Image)resources.GetObject("buttonDoneOpenFile_MAY.Image");
            buttonDoneOpenFile_MAY.Location = new Point(118, 12);
            buttonDoneOpenFile_MAY.Name = "buttonDoneOpenFile_MAY";
            buttonDoneOpenFile_MAY.Size = new Size(75, 55);
            buttonDoneOpenFile_MAY.TabIndex = 1;
            toolTip2.SetToolTip(buttonDoneOpenFile_MAY, "Выполнить обработку данных");
            buttonDoneOpenFile_MAY.UseVisualStyleBackColor = true;
            buttonDoneOpenFile_MAY.Click += button2OpenFile_MAY_Click;
            // 
            // buttonInputFile_MAY
            // 
            buttonInputFile_MAY.Cursor = Cursors.Hand;
            buttonInputFile_MAY.FlatStyle = FlatStyle.Flat;
            buttonInputFile_MAY.Image = (Image)resources.GetObject("buttonInputFile_MAY.Image");
            buttonInputFile_MAY.Location = new Point(23, 12);
            buttonInputFile_MAY.Name = "buttonInputFile_MAY";
            buttonInputFile_MAY.Size = new Size(75, 55);
            buttonInputFile_MAY.TabIndex = 0;
            toolTip1.SetToolTip(buttonInputFile_MAY, "открыть файл для обработки данных в формате CSV\r\n");
            buttonInputFile_MAY.UseVisualStyleBackColor = true;
            buttonInputFile_MAY.Click += buttonInputFile_MAY_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxCondition_MAY);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 73);
            panel2.TabIndex = 0;
            // 
            // groupBoxCondition_MAY
            // 
            groupBoxCondition_MAY.Controls.Add(textBoxCondition_MAY);
            groupBoxCondition_MAY.Dock = DockStyle.Fill;
            groupBoxCondition_MAY.Location = new Point(0, 0);
            groupBoxCondition_MAY.Name = "groupBoxCondition_MAY";
            groupBoxCondition_MAY.Size = new Size(984, 73);
            groupBoxCondition_MAY.TabIndex = 0;
            groupBoxCondition_MAY.TabStop = false;
            groupBoxCondition_MAY.Text = "Условие";
            // 
            // textBoxCondition_MAY
            // 
            textBoxCondition_MAY.BackColor = SystemColors.ButtonFace;
            textBoxCondition_MAY.BorderStyle = BorderStyle.None;
            textBoxCondition_MAY.Dock = DockStyle.Fill;
            textBoxCondition_MAY.ForeColor = SystemColors.ActiveCaptionText;
            textBoxCondition_MAY.Location = new Point(3, 19);
            textBoxCondition_MAY.Multiline = true;
            textBoxCondition_MAY.Name = "textBoxCondition_MAY";
            textBoxCondition_MAY.ReadOnly = true;
            textBoxCondition_MAY.Size = new Size(978, 51);
            textBoxCondition_MAY.TabIndex = 0;
            textBoxCondition_MAY.Text = resources.GetString("textBoxCondition_MAY.Text");
            textBoxCondition_MAY.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1InPut_MAY);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 146);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(471, 515);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint_1;
            // 
            // groupBox1InPut_MAY
            // 
            groupBox1InPut_MAY.Controls.Add(dataGridViewIn_MAY1);
            groupBox1InPut_MAY.Dock = DockStyle.Fill;
            groupBox1InPut_MAY.Location = new Point(3, 3);
            groupBox1InPut_MAY.Name = "groupBox1InPut_MAY";
            groupBox1InPut_MAY.Padding = new Padding(20);
            groupBox1InPut_MAY.Size = new Size(465, 509);
            groupBox1InPut_MAY.TabIndex = 0;
            groupBox1InPut_MAY.TabStop = false;
            groupBox1InPut_MAY.Text = "Ввод";
            // 
            // dataGridViewIn_MAY1
            // 
            dataGridViewIn_MAY1.AllowUserToAddRows = false;
            dataGridViewIn_MAY1.AllowUserToDeleteRows = false;
            dataGridViewIn_MAY1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MAY1.ColumnHeadersVisible = false;
            dataGridViewIn_MAY1.Dock = DockStyle.Fill;
            dataGridViewIn_MAY1.Location = new Point(20, 36);
            dataGridViewIn_MAY1.Name = "dataGridViewIn_MAY1";
            dataGridViewIn_MAY1.ReadOnly = true;
            dataGridViewIn_MAY1.RowHeadersVisible = false;
            dataGridViewIn_MAY1.Size = new Size(425, 453);
            dataGridViewIn_MAY1.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(471, 146);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 515);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1OutPut_MAY);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(474, 146);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(3);
            panel4.Size = new Size(510, 515);
            panel4.TabIndex = 3;
            // 
            // groupBox1OutPut_MAY
            // 
            groupBox1OutPut_MAY.Controls.Add(dataGridViewOut_MAY1);
            groupBox1OutPut_MAY.Dock = DockStyle.Fill;
            groupBox1OutPut_MAY.Location = new Point(3, 3);
            groupBox1OutPut_MAY.Name = "groupBox1OutPut_MAY";
            groupBox1OutPut_MAY.Padding = new Padding(20);
            groupBox1OutPut_MAY.Size = new Size(504, 509);
            groupBox1OutPut_MAY.TabIndex = 0;
            groupBox1OutPut_MAY.TabStop = false;
            groupBox1OutPut_MAY.Text = "Вывод";
            // 
            // dataGridViewOut_MAY1
            // 
            dataGridViewOut_MAY1.AllowUserToAddRows = false;
            dataGridViewOut_MAY1.AllowUserToDeleteRows = false;
            dataGridViewOut_MAY1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MAY1.ColumnHeadersVisible = false;
            dataGridViewOut_MAY1.Dock = DockStyle.Fill;
            dataGridViewOut_MAY1.Location = new Point(20, 36);
            dataGridViewOut_MAY1.Name = "dataGridViewOut_MAY1";
            dataGridViewOut_MAY1.ReadOnly = true;
            dataGridViewOut_MAY1.RowHeadersVisible = false;
            dataGridViewOut_MAY1.Size = new Size(464, 453);
            dataGridViewOut_MAY1.TabIndex = 0;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Выполнить";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Открыть файл";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Сохранить файл";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipTitle = "Справка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 700);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxCondition_MAY.ResumeLayout(false);
            groupBoxCondition_MAY.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1InPut_MAY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MAY1).EndInit();
            panel4.ResumeLayout(false);
            groupBox1OutPut_MAY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MAY1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBoxCondition_MAY;
        private TextBox textBoxCondition_MAY;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel4;
        private GroupBox groupBox1InPut_MAY;
        private DataGridView dataGridViewIn_MAY1;
        private GroupBox groupBox1OutPut_MAY;
        private DataGridView dataGridViewOut_MAY1;
        private Button buttonInformation_MAY;
        private Button buttonSafeFile_MAY;
        private Button buttonDoneOpenFile_MAY;
        private Button buttonInputFile_MAY;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
