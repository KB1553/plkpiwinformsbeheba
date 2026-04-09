namespace WinFormsApp5
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
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnYellow = new Button();
            lblColorName = new Label();
            SuspendLayout();
            // 
            // btnRed
            // 
            btnRed.Location = new Point(129, 229);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(75, 130);
            btnRed.TabIndex = 0;
            btnRed.Text = "червоний";
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.Location = new Point(253, 229);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(75, 130);
            btnGreen.TabIndex = 1;
            btnGreen.Text = "зелений";
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(459, 229);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(75, 130);
            btnBlue.TabIndex = 2;
            btnBlue.Text = "синій";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnYellow
            // 
            btnYellow.Location = new Point(574, 229);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(75, 130);
            btnYellow.TabIndex = 3;
            btnYellow.Text = "жовтий";
            btnYellow.UseVisualStyleBackColor = true;
            btnYellow.Click += btnYellow_Click;
            // 
            // lblColorName
            // 
            lblColorName.AutoSize = true;
            lblColorName.Location = new Point(358, 183);
            lblColorName.Name = "lblColorName";
            lblColorName.Size = new Size(86, 15);
            lblColorName.TabIndex = 4;
            lblColorName.Text = "назва кольору";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblColorName);
            Controls.Add(btnYellow);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Form1";
            Click += btnGreen_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private Button btnYellow;
        private Label lblColorName;
    }
}
