namespace Tyuiu.MakarovAY.Sprint6.Task2.V15
{
    partial class Main
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
            Grafik = new ScottPlot.WinForms.FormsPlot();
            groupBoxTextCondition = new GroupBox();
            Condition2 = new Label();
            condition1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxEndStep = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStartStep = new TextBox();
            buttonHelpClick = new Button();
            buttonDone = new Button();
            dataGridView1 = new DataGridView();
            Y = new DataGridViewTextBoxColumn();
            X = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBoxTextCondition.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // Grafik
            // 
            Grafik.DisplayScale = 1F;
            Grafik.Location = new Point(738, 29);
            Grafik.Name = "Grafik";
            Grafik.Size = new Size(367, 486);
            Grafik.TabIndex = 0;
            Grafik.Load += formsPlot1_Load;
            // 
            // groupBoxTextCondition
            // 
            groupBoxTextCondition.Controls.Add(Condition2);
            groupBoxTextCondition.Controls.Add(condition1);
            groupBoxTextCondition.Location = new Point(12, 29);
            groupBoxTextCondition.Name = "groupBoxTextCondition";
            groupBoxTextCondition.Size = new Size(492, 365);
            groupBoxTextCondition.TabIndex = 1;
            groupBoxTextCondition.TabStop = false;
            groupBoxTextCondition.Text = "Условие";
            // 
            // Condition2
            // 
            Condition2.AutoSize = true;
            Condition2.Location = new Point(6, 34);
            Condition2.Name = "Condition2";
            Condition2.Size = new Size(362, 15);
            Condition2.TabIndex = 1;
            Condition2.Text = "результат вывести в DataGridView и построить график функции. ";
            // 
            // condition1
            // 
            condition1.AutoSize = true;
            condition1.Location = new Point(6, 19);
            condition1.Name = "condition1";
            condition1.Size = new Size(368, 15);
            condition1.TabIndex = 0;
            condition1.Text = "протабулировать функции sin(x) и cos(x) на заданном диапозоне ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxEndStep);
            groupBox3.Location = new Point(172, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(150, 57);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Конец шага";
            // 
            // textBoxEndStep
            // 
            textBoxEndStep.Location = new Point(6, 22);
            textBoxEndStep.Name = "textBoxEndStep";
            textBoxEndStep.Size = new Size(138, 23);
            textBoxEndStep.TabIndex = 0;
            textBoxEndStep.TextChanged += textBoxEndStep_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStartStep);
            groupBox2.Location = new Point(6, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 57);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Старт шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 22);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(138, 23);
            textBoxStartStep.TabIndex = 3;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.BackColor = SystemColors.ActiveCaption;
            buttonHelpClick.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelpClick.Location = new Point(348, 449);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(60, 66);
            buttonHelpClick.TabIndex = 3;
            buttonHelpClick.Text = "справка";
            buttonHelpClick.UseVisualStyleBackColor = false;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.ForestGreen;
            buttonDone.Location = new Point(414, 449);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 66);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "выполнить ";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Y, X });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(204, 430);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Y
            // 
            Y.HeaderText = "X";
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 101;
            // 
            // X
            // 
            X.HeaderText = "F(X)";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(510, 29);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(222, 486);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ввод Данных";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(6, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(210, 458);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Результат";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 527);
            Controls.Add(groupBox4);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelpClick);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTextCondition);
            Controls.Add(Grafik);
            Name = "Main";
            Text = "Form1";
            groupBoxTextCondition.ResumeLayout(false);
            groupBoxTextCondition.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot Grafik;
        private GroupBox groupBoxTextCondition;
        private Label condition1;
        private Label Condition2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox textBoxEndStep;
        private GroupBox groupBox2;
        private TextBox textBoxStartStep;
        private Button buttonHelpClick;
        private Button buttonDone;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn X;
    }
}
