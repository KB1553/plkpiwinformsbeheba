namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            btnPrev = new Button();
            btnStartSapper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(131, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 107);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(172, 99);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(87, 56);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(172, 320);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(87, 56);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnStartSapper
            // 
            btnStartSapper.Location = new Point(617, 181);
            btnStartSapper.Name = "btnStartSapper";
            btnStartSapper.Size = new Size(179, 108);
            btnStartSapper.TabIndex = 3;
            btnStartSapper.Text = "сапер";
            btnStartSapper.UseVisualStyleBackColor = true;
            btnStartSapper.Click += btnStartSapper_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 589);
            Controls.Add(btnStartSapper);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNext;
        private Button btnPrev;
        private Button btnStartSapper;
    }
}
