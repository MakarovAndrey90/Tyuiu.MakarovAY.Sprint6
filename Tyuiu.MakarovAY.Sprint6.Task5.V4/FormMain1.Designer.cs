namespace Tyuiu.MakarovAY.Sprint6.Task5.V4
{
    partial class FormMain1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttongetDone_MAY = new Button();
            buttonOpenFile_MAY = new Button();
            buttonHelp_MAY = new Button();
            groupBoxCondition_MAY = new GroupBox();
            textBoxConditioin_MAY = new TextBox();
            panel2 = new Panel();
            chartdiagram_MAY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            panel3 = new Panel();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxCondition_MAY.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartdiagram_MAY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttongetDone_MAY);
            panel1.Controls.Add(buttonOpenFile_MAY);
            panel1.Controls.Add(buttonHelp_MAY);
            panel1.Controls.Add(groupBoxCondition_MAY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 100);
            panel1.TabIndex = 0;
            // 
            // buttongetDone_MAY
            // 
            buttongetDone_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttongetDone_MAY.BackColor = Color.SeaGreen;
            buttongetDone_MAY.Cursor = Cursors.Hand;
            buttongetDone_MAY.Location = new Point(679, 48);
            buttongetDone_MAY.Name = "buttongetDone_MAY";
            buttongetDone_MAY.Size = new Size(106, 46);
            buttongetDone_MAY.TabIndex = 2;
            buttongetDone_MAY.Text = "Выполнить";
            buttongetDone_MAY.UseVisualStyleBackColor = false;
            buttongetDone_MAY.Click += buttongetDone_MAY_Click;
            // 
            // buttonOpenFile_MAY
            // 
            buttonOpenFile_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_MAY.BackColor = SystemColors.ActiveCaption;
            buttonOpenFile_MAY.Cursor = Cursors.Hand;
            buttonOpenFile_MAY.Location = new Point(791, 48);
            buttonOpenFile_MAY.Name = "buttonOpenFile_MAY";
            buttonOpenFile_MAY.Size = new Size(100, 46);
            buttonOpenFile_MAY.TabIndex = 1;
            buttonOpenFile_MAY.Text = "Открыть файл";
            buttonOpenFile_MAY.UseVisualStyleBackColor = false;
            buttonOpenFile_MAY.Click += buttonOpenFile_MAY_Click;
            // 
            // buttonHelp_MAY
            // 
            buttonHelp_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MAY.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_MAY.Cursor = Cursors.Hand;
            buttonHelp_MAY.Location = new Point(897, 48);
            buttonHelp_MAY.Name = "buttonHelp_MAY";
            buttonHelp_MAY.Size = new Size(75, 46);
            buttonHelp_MAY.TabIndex = 1;
            buttonHelp_MAY.Text = "Справка";
            buttonHelp_MAY.UseVisualStyleBackColor = false;
            buttonHelp_MAY.Click += buttonHelp_MAY_Click;
            // 
            // groupBoxCondition_MAY
            // 
            groupBoxCondition_MAY.Controls.Add(textBoxConditioin_MAY);
            groupBoxCondition_MAY.Location = new Point(12, 12);
            groupBoxCondition_MAY.Name = "groupBoxCondition_MAY";
            groupBoxCondition_MAY.Size = new Size(326, 82);
            groupBoxCondition_MAY.TabIndex = 0;
            groupBoxCondition_MAY.TabStop = false;
            groupBoxCondition_MAY.Text = "Условие";
            // 
            // textBoxConditioin_MAY
            // 
            textBoxConditioin_MAY.BackColor = SystemColors.Control;
            textBoxConditioin_MAY.BorderStyle = BorderStyle.None;
            textBoxConditioin_MAY.ForeColor = SystemColors.ControlText;
            textBoxConditioin_MAY.Location = new Point(6, 22);
            textBoxConditioin_MAY.Multiline = true;
            textBoxConditioin_MAY.Name = "textBoxConditioin_MAY";
            textBoxConditioin_MAY.ReadOnly = true;
            textBoxConditioin_MAY.Size = new Size(314, 54);
            textBoxConditioin_MAY.TabIndex = 0;
            textBoxConditioin_MAY.Text = "Прочитать данные из файла InputFileTask5V4.txt. Вывести в dataGridView все целые числа и построить диаграмму по этим значениям ";
            // 
            // panel2
            // 
            panel2.Controls.Add(chartdiagram_MAY);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(180, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 561);
            panel2.TabIndex = 0;
            // 
            // chartdiagram_MAY
            // 
            chartArea1.Name = "ChartArea1";
            chartdiagram_MAY.ChartAreas.Add(chartArea1);
            chartdiagram_MAY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartdiagram_MAY.Legends.Add(legend1);
            chartdiagram_MAY.Location = new Point(0, 0);
            chartdiagram_MAY.Name = "chartdiagram_MAY";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartdiagram_MAY.Series.Add(series1);
            chartdiagram_MAY.Size = new Size(804, 561);
            chartdiagram_MAY.TabIndex = 0;
            chartdiagram_MAY.Text = "chart1";
            chartdiagram_MAY.Click += chartdiagram_MAY_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.Location = new Point(3, 3);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult.Size = new Size(174, 555);
            dataGridViewResult.TabIndex = 0;
            dataGridViewResult.CellContentClick += dataGridViewResult_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewResult);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(180, 561);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(180, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 561);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 700);
            Name = "FormMain1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain1_Load;
            panel1.ResumeLayout(false);
            groupBoxCondition_MAY.ResumeLayout(false);
            groupBoxCondition_MAY.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartdiagram_MAY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxCondition_MAY;
        private TextBox textBoxConditioin_MAY;
        private Panel panel2;
        private Button buttonOpenFile_MAY;
        private Button buttonHelp_MAY;
        private Button buttongetDone_MAY;
        private DataGridView dataGridViewResult;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartdiagram_MAY;
        private Splitter splitter1;
    }
}
