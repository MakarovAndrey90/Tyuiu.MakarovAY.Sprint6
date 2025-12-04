namespace Tyuiu.MakarovAY.Sprint6.Task1.V21
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
            groupBoxText1 = new GroupBox();
            label2Condition = new Label();
            labelcondition = new Label();
            groupBoxParametres = new GroupBox();
            groupBoxEndStep = new GroupBox();
            textBoxStopStep = new TextBox();
            groupBoxStartStep = new GroupBox();
            textBoxStartStep = new TextBox();
            groupBoxconclusion = new GroupBox();
            groupBoxRes = new GroupBox();
            textBoxResult = new TextBox();
            buttonHelpClick = new Button();
            buttonAction = new Button();
            groupBoxText1.SuspendLayout();
            groupBoxParametres.SuspendLayout();
            groupBoxEndStep.SuspendLayout();
            groupBoxStartStep.SuspendLayout();
            groupBoxconclusion.SuspendLayout();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxText1
            // 
            groupBoxText1.Controls.Add(label2Condition);
            groupBoxText1.Controls.Add(labelcondition);
            groupBoxText1.Location = new Point(12, 12);
            groupBoxText1.Name = "groupBoxText1";
            groupBoxText1.Size = new Size(464, 292);
            groupBoxText1.TabIndex = 0;
            groupBoxText1.TabStop = false;
            groupBoxText1.Text = "Условие";
            // 
            // label2Condition
            // 
            label2Condition.AutoSize = true;
            label2Condition.Location = new Point(6, 34);
            label2Condition.Name = "label2Condition";
            label2Condition.Size = new Size(199, 15);
            label2Condition.TabIndex = 1;
            label2Condition.Text = "результат вывести в виде таблицы ";
            // 
            // labelcondition
            // 
            labelcondition.AutoSize = true;
            labelcondition.Location = new Point(6, 19);
            labelcondition.Name = "labelcondition";
            labelcondition.Size = new Size(458, 15);
            labelcondition.TabIndex = 0;
            labelcondition.Text = "Протабулировать функцию на заданном диапозоне: cos(x) + sin(x) / (2 - 2*x ) - 4*x";
            // 
            // groupBoxParametres
            // 
            groupBoxParametres.Controls.Add(groupBoxEndStep);
            groupBoxParametres.Controls.Add(groupBoxStartStep);
            groupBoxParametres.Location = new Point(12, 310);
            groupBoxParametres.Name = "groupBoxParametres";
            groupBoxParametres.Size = new Size(301, 128);
            groupBoxParametres.TabIndex = 1;
            groupBoxParametres.TabStop = false;
            groupBoxParametres.Text = "Ввод данных";
            // 
            // groupBoxEndStep
            // 
            groupBoxEndStep.Controls.Add(textBoxStopStep);
            groupBoxEndStep.Location = new Point(159, 28);
            groupBoxEndStep.Name = "groupBoxEndStep";
            groupBoxEndStep.Size = new Size(136, 94);
            groupBoxEndStep.TabIndex = 3;
            groupBoxEndStep.TabStop = false;
            groupBoxEndStep.Text = "конец шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(6, 41);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(124, 23);
            textBoxStopStep.TabIndex = 0;
            textBoxStopStep.TextChanged += textBoxStopStep_TextChanged;
            // 
            // groupBoxStartStep
            // 
            groupBoxStartStep.Controls.Add(textBoxStartStep);
            groupBoxStartStep.Location = new Point(6, 28);
            groupBoxStartStep.Name = "groupBoxStartStep";
            groupBoxStartStep.Size = new Size(129, 94);
            groupBoxStartStep.TabIndex = 2;
            groupBoxStartStep.TabStop = false;
            groupBoxStartStep.Text = "начало шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 41);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(117, 23);
            textBoxStartStep.TabIndex = 5;
            textBoxStartStep.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxconclusion
            // 
            groupBoxconclusion.Controls.Add(groupBoxRes);
            groupBoxconclusion.Location = new Point(482, 12);
            groupBoxconclusion.Name = "groupBoxconclusion";
            groupBoxconclusion.Size = new Size(306, 426);
            groupBoxconclusion.TabIndex = 2;
            groupBoxconclusion.TabStop = false;
            groupBoxconclusion.Text = "Вывод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(6, 22);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(294, 398);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(0, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(288, 376);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBox1_TextChanged_1;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.BackColor = SystemColors.ActiveCaption;
            buttonHelpClick.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelpClick.Location = new Point(319, 407);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(40, 31);
            buttonHelpClick.TabIndex = 3;
            buttonHelpClick.Text = "?";
            buttonHelpClick.UseVisualStyleBackColor = false;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // buttonAction
            // 
            buttonAction.BackColor = Color.DarkSeaGreen;
            buttonAction.Location = new Point(365, 310);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(114, 128);
            buttonAction.TabIndex = 4;
            buttonAction.Text = "выполнить";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAction);
            Controls.Add(buttonHelpClick);
            Controls.Add(groupBoxconclusion);
            Controls.Add(groupBoxParametres);
            Controls.Add(groupBoxText1);
            Name = "Form1";
            Text = "Form1";
            groupBoxText1.ResumeLayout(false);
            groupBoxText1.PerformLayout();
            groupBoxParametres.ResumeLayout(false);
            groupBoxEndStep.ResumeLayout(false);
            groupBoxEndStep.PerformLayout();
            groupBoxStartStep.ResumeLayout(false);
            groupBoxStartStep.PerformLayout();
            groupBoxconclusion.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxText1;
        private Label label2Condition;
        private Label labelcondition;
        private GroupBox groupBoxParametres;
        private GroupBox groupBoxEndStep;
        private GroupBox groupBoxStartStep;
        private GroupBox groupBoxconclusion;
        private GroupBox groupBoxRes;
        private Button buttonHelpClick;
        private Button buttonAction;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private TextBox textBoxResult;
    }
}
