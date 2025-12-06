namespace Tyuiu.MakarovAY.Sprint6.Task4.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            buttonDone_MAY = new Button();
            buttonSafe_MAY = new Button();
            buttonHelp_MAY = new Button();
            StartStopStep_MAY = new GroupBox();
            labelStopStep = new Label();
            labelStartStep = new Label();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            groupBoxCondition_MAY = new GroupBox();
            TextBoxCondition_MAY = new TextBox();
            panel2 = new Panel();
            groupBoxconclusion = new GroupBox();
            textBoxResult_MAY = new TextBox();
            panel3 = new Panel();
            chartFunction_MAY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            StartStopStep_MAY.SuspendLayout();
            groupBoxCondition_MAY.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxconclusion.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAY).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonDone_MAY);
            panel1.Controls.Add(buttonSafe_MAY);
            panel1.Controls.Add(buttonHelp_MAY);
            panel1.Controls.Add(StartStopStep_MAY);
            panel1.Controls.Add(groupBoxCondition_MAY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 100);
            panel1.TabIndex = 0;
            // 
            // buttonDone_MAY
            // 
            buttonDone_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_MAY.BackColor = Color.ForestGreen;
            buttonDone_MAY.Location = new Point(712, 30);
            buttonDone_MAY.Name = "buttonDone_MAY";
            buttonDone_MAY.Size = new Size(109, 58);
            buttonDone_MAY.TabIndex = 4;
            buttonDone_MAY.Text = "Выполнить";
            buttonDone_MAY.UseVisualStyleBackColor = false;
            buttonDone_MAY.Click += buttonDone_MAY_Click;
            // 
            // buttonSafe_MAY
            // 
            buttonSafe_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSafe_MAY.BackColor = Color.DarkOrange;
            buttonSafe_MAY.Location = new Point(827, 30);
            buttonSafe_MAY.Name = "buttonSafe_MAY";
            buttonSafe_MAY.Size = new Size(82, 58);
            buttonSafe_MAY.TabIndex = 3;
            buttonSafe_MAY.Text = "Сохранить";
            buttonSafe_MAY.UseVisualStyleBackColor = false;
            buttonSafe_MAY.Click += buttonSafe_MAY_Click;
            // 
            // buttonHelp_MAY
            // 
            buttonHelp_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MAY.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MAY.Location = new Point(915, 30);
            buttonHelp_MAY.Name = "buttonHelp_MAY";
            buttonHelp_MAY.Size = new Size(66, 58);
            buttonHelp_MAY.TabIndex = 2;
            buttonHelp_MAY.Text = "справка";
            buttonHelp_MAY.UseVisualStyleBackColor = false;
            buttonHelp_MAY.Click += buttonHelp_MAY_Click;
            // 
            // StartStopStep_MAY
            // 
            StartStopStep_MAY.Controls.Add(labelStopStep);
            StartStopStep_MAY.Controls.Add(labelStartStep);
            StartStopStep_MAY.Controls.Add(textBoxStopStep);
            StartStopStep_MAY.Controls.Add(textBoxStartStep);
            StartStopStep_MAY.Location = new Point(431, 7);
            StartStopStep_MAY.Name = "StartStopStep_MAY";
            StartStopStep_MAY.Size = new Size(275, 87);
            StartStopStep_MAY.TabIndex = 1;
            StartStopStep_MAY.TabStop = false;
            StartStopStep_MAY.Text = "Ввод Данных";
            // 
            // labelStopStep
            // 
            labelStopStep.AutoSize = true;
            labelStopStep.Location = new Point(156, 24);
            labelStopStep.Name = "labelStopStep";
            labelStopStep.Size = new Size(71, 15);
            labelStopStep.TabIndex = 1;
            labelStopStep.Text = "конец шага";
            // 
            // labelStartStep
            // 
            labelStartStep.AutoSize = true;
            labelStartStep.Location = new Point(6, 24);
            labelStartStep.Name = "labelStartStep";
            labelStartStep.Size = new Size(78, 15);
            labelStartStep.TabIndex = 1;
            labelStartStep.Text = "начало шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(156, 42);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(113, 23);
            textBoxStopStep.TabIndex = 0;
            textBoxStopStep.TextChanged += textBoxStopStep_TextChanged;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 42);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(113, 23);
            textBoxStartStep.TabIndex = 0;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            // 
            // groupBoxCondition_MAY
            // 
            groupBoxCondition_MAY.Controls.Add(TextBoxCondition_MAY);
            groupBoxCondition_MAY.Location = new Point(13, 7);
            groupBoxCondition_MAY.Name = "groupBoxCondition_MAY";
            groupBoxCondition_MAY.Size = new Size(412, 87);
            groupBoxCondition_MAY.TabIndex = 0;
            groupBoxCondition_MAY.TabStop = false;
            groupBoxCondition_MAY.Text = "Условие";
            // 
            // TextBoxCondition_MAY
            // 
            TextBoxCondition_MAY.BackColor = SystemColors.ActiveCaption;
            TextBoxCondition_MAY.BorderStyle = BorderStyle.None;
            TextBoxCondition_MAY.Location = new Point(6, 23);
            TextBoxCondition_MAY.Multiline = true;
            TextBoxCondition_MAY.Name = "TextBoxCondition_MAY";
            TextBoxCondition_MAY.ReadOnly = true;
            TextBoxCondition_MAY.Size = new Size(400, 58);
            TextBoxCondition_MAY.TabIndex = 0;
            TextBoxCondition_MAY.Text = "протабулировать функцию sin(x) на заданном диапозоне от -5 до 5.\r\nРезультат вывести в textBox. Построить график функции и сохранить в файл OutPutFile.txt по нажатию кнопки  ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(groupBoxconclusion);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(273, 461);
            panel2.TabIndex = 0;
            // 
            // groupBoxconclusion
            // 
            groupBoxconclusion.Controls.Add(textBoxResult_MAY);
            groupBoxconclusion.Dock = DockStyle.Fill;
            groupBoxconclusion.Location = new Point(5, 5);
            groupBoxconclusion.Name = "groupBoxconclusion";
            groupBoxconclusion.Size = new Size(263, 451);
            groupBoxconclusion.TabIndex = 0;
            groupBoxconclusion.TabStop = false;
            groupBoxconclusion.Text = "Вывод";
            // 
            // textBoxResult_MAY
            // 
            textBoxResult_MAY.Dock = DockStyle.Fill;
            textBoxResult_MAY.Location = new Point(3, 19);
            textBoxResult_MAY.Multiline = true;
            textBoxResult_MAY.Name = "textBoxResult_MAY";
            textBoxResult_MAY.ReadOnly = true;
            textBoxResult_MAY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MAY.Size = new Size(257, 429);
            textBoxResult_MAY.TabIndex = 0;
            textBoxResult_MAY.TextChanged += textBoxResult_MAY_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(chartFunction_MAY);
            panel3.Controls.Add(splitter2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(273, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(711, 461);
            panel3.TabIndex = 0;
            // 
            // chartFunction_MAY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MAY.ChartAreas.Add(chartArea1);
            chartFunction_MAY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_MAY.Legends.Add(legend1);
            chartFunction_MAY.Location = new Point(3, 0);
            chartFunction_MAY.Name = "chartFunction_MAY";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MAY.Series.Add(series1);
            chartFunction_MAY.Size = new Size(708, 461);
            chartFunction_MAY.TabIndex = 1;
            chartFunction_MAY.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "график функции sin(x)";
            chartFunction_MAY.Titles.Add(title1);
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 461);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(273, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 461);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            StartStopStep_MAY.ResumeLayout(false);
            StartStopStep_MAY.PerformLayout();
            groupBoxCondition_MAY.ResumeLayout(false);
            groupBoxCondition_MAY.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxconclusion.ResumeLayout(false);
            groupBoxconclusion.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxCondition_MAY;
        private TextBox TextBoxCondition_MAY;
        private Button buttonSafe_MAY;
        private Button buttonHelp_MAY;
        private GroupBox StartStopStep_MAY;
        private Button buttonDone_MAY;
        private Label labelStopStep;
        private Label labelStartStep;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private GroupBox groupBoxconclusion;
        private Splitter splitter2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MAY;
        private TextBox textBoxResult_MAY;
    }
}
