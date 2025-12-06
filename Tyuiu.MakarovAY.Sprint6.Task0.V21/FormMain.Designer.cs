namespace Tyuiu.MakarovAY.Sprint6.Task0.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonDone = new Button();
            TextBoxRes = new TextBox();
            textBoxVarX = new TextBox();
            buttonHelpClick = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonDone
            // 
            ButtonDone.Location = new Point(669, 399);
            ButtonDone.Name = "ButtonDone";
            ButtonDone.Size = new Size(100, 23);
            ButtonDone.TabIndex = 0;
            ButtonDone.Text = "Выполнить";
            ButtonDone.UseVisualStyleBackColor = true;
            ButtonDone.Click += ButtonDone_Click;
            // 
            // TextBoxRes
            // 
            TextBoxRes.Location = new Point(669, 370);
            TextBoxRes.Name = "TextBoxRes";
            TextBoxRes.ReadOnly = true;
            TextBoxRes.Size = new Size(100, 23);
            TextBoxRes.TabIndex = 1;
            TextBoxRes.TextChanged += TextBoxRes_TextChanged;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(53, 399);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.FlatStyle = FlatStyle.Flat;
            buttonHelpClick.Location = new Point(629, 392);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(34, 29);
            buttonHelpClick.TabIndex = 3;
            buttonHelpClick.Text = "?";
            buttonHelpClick.UseVisualStyleBackColor = true;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(506, 286);
            textBox1.TabIndex = 4;
            textBox1.Text = "вычислить значение выражения";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 40);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "условие";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(587, 290);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 149);
            textBox3.TabIndex = 6;
            textBox3.Text = "ввод данных";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(53, 370);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "переменная х";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(669, 341);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            textBox5.Text = "результат";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonHelpClick);
            Controls.Add(textBoxVarX);
            Controls.Add(TextBoxRes);
            Controls.Add(ButtonDone);
            Controls.Add(textBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonDone;
        private TextBox TextBoxRes;
        private TextBox textBoxVarX;
        private Button buttonHelpClick;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox1;
    }
}
