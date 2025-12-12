namespace Tyuiu.MakarovAY.Sprint6.Task7.V5
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            labelAbout_MAY = new Label();
            buttonOK_MAY = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelAbout_MAY
            // 
            labelAbout_MAY.AutoSize = true;
            labelAbout_MAY.Location = new Point(219, 12);
            labelAbout_MAY.Name = "labelAbout_MAY";
            labelAbout_MAY.Size = new Size(303, 150);
            labelAbout_MAY.TabIndex = 2;
            labelAbout_MAY.Text = resources.GetString("labelAbout_MAY.Text");
            // 
            // buttonOK_MAY
            // 
            buttonOK_MAY.Cursor = Cursors.Hand;
            buttonOK_MAY.Location = new Point(447, 226);
            buttonOK_MAY.Name = "buttonOK_MAY";
            buttonOK_MAY.Size = new Size(75, 23);
            buttonOK_MAY.TabIndex = 3;
            buttonOK_MAY.Text = "Ok";
            buttonOK_MAY.UseVisualStyleBackColor = true;
            buttonOK_MAY.Click += buttonOK_MAY_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 261);
            Controls.Add(buttonOK_MAY);
            Controls.Add(labelAbout_MAY);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(550, 300);
            MinimumSize = new Size(550, 300);
            Name = "FormAbout";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAbout_MAY;
        private Button buttonOK_MAY;
    }
}