namespace Tyuiu.MakarovAY.Sprint6.Task3.V2
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
            groupBox_MAY = new GroupBox();
            textBoxCondition_MAY = new TextBox();
            buttonHelpClick_MAY = new Button();
            buttonDone_MAY = new Button();
            dataGridViewMatrix = new DataGridView();
            groupBoxRes_MAY = new GroupBox();
            dataGridViewResult_MAY = new DataGridView();
            groupBox_MAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxRes_MAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAY).BeginInit();
            SuspendLayout();
            // 
            // groupBox_MAY
            // 
            groupBox_MAY.Controls.Add(textBoxCondition_MAY);
            groupBox_MAY.Location = new Point(12, 12);
            groupBox_MAY.Name = "groupBox_MAY";
            groupBox_MAY.Size = new Size(364, 470);
            groupBox_MAY.TabIndex = 0;
            groupBox_MAY.TabStop = false;
            groupBox_MAY.Text = "Условие";
            // 
            // textBoxCondition_MAY
            // 
            textBoxCondition_MAY.BorderStyle = BorderStyle.None;
            textBoxCondition_MAY.Location = new Point(6, 22);
            textBoxCondition_MAY.Multiline = true;
            textBoxCondition_MAY.Name = "textBoxCondition_MAY";
            textBoxCondition_MAY.ReadOnly = true;
            textBoxCondition_MAY.Size = new Size(352, 365);
            textBoxCondition_MAY.TabIndex = 0;
            textBoxCondition_MAY.Text = "дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n-12  -4 -20   5  -5\r\n\r\n   2  15   1 -20   7\r\n\r\n  15 -15   2  11   5\r\n\r\n -19  -9  16   0   1\r\n\r\n  17  16   5  12  -8";
            // 
            // buttonHelpClick_MAY
            // 
            buttonHelpClick_MAY.BackColor = SystemColors.ActiveCaption;
            buttonHelpClick_MAY.Location = new Point(770, 434);
            buttonHelpClick_MAY.Name = "buttonHelpClick_MAY";
            buttonHelpClick_MAY.Size = new Size(75, 48);
            buttonHelpClick_MAY.TabIndex = 1;
            buttonHelpClick_MAY.Text = "?";
            buttonHelpClick_MAY.UseVisualStyleBackColor = false;
            buttonHelpClick_MAY.Click += buttonHelpClick_MAY_Click;
            // 
            // buttonDone_MAY
            // 
            buttonDone_MAY.BackColor = Color.DarkSeaGreen;
            buttonDone_MAY.Location = new Point(851, 434);
            buttonDone_MAY.Name = "buttonDone_MAY";
            buttonDone_MAY.Size = new Size(153, 48);
            buttonDone_MAY.TabIndex = 2;
            buttonDone_MAY.Text = "Выполнить ";
            buttonDone_MAY.UseVisualStyleBackColor = false;
            buttonDone_MAY.Click += buttonDone_MAY_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(408, 34);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(273, 365);
            dataGridViewMatrix.TabIndex = 3;
            dataGridViewMatrix.CellContentClick += dataGridViewMatrix_CellContentClick;
            // 
            // groupBoxRes_MAY
            // 
            groupBoxRes_MAY.Controls.Add(dataGridViewResult_MAY);
            groupBoxRes_MAY.Location = new Point(710, 12);
            groupBoxRes_MAY.Name = "groupBoxRes_MAY";
            groupBoxRes_MAY.Size = new Size(294, 470);
            groupBoxRes_MAY.TabIndex = 4;
            groupBoxRes_MAY.TabStop = false;
            groupBoxRes_MAY.Text = "Вывод данных";
            groupBoxRes_MAY.Enter += groupBoxRes_MAY_Enter;
            // 
            // dataGridViewResult_MAY
            // 
            dataGridViewResult_MAY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MAY.Location = new Point(9, 22);
            dataGridViewResult_MAY.Name = "dataGridViewResult_MAY";
            dataGridViewResult_MAY.ReadOnly = true;
            dataGridViewResult_MAY.RowHeadersVisible = false;
            dataGridViewResult_MAY.Size = new Size(273, 365);
            dataGridViewResult_MAY.TabIndex = 0;
            dataGridViewResult_MAY.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 494);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(buttonDone_MAY);
            Controls.Add(buttonHelpClick_MAY);
            Controls.Add(groupBox_MAY);
            Controls.Add(groupBoxRes_MAY);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox_MAY.ResumeLayout(false);
            groupBox_MAY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxRes_MAY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_MAY;
        private TextBox textBoxCondition_MAY;
        private Button buttonHelpClick_MAY;
        private Button buttonDone_MAY;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxRes_MAY;
        private DataGridView dataGridViewResult_MAY;
    }
}
