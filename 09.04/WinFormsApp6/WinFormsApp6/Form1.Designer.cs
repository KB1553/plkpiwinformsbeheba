namespace WinFormsApp6
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
            btnIncrement = new Button();
            btnReset = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnIncrement
            // 
            btnIncrement.Location = new Point(111, 176);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(75, 23);
            btnIncrement.TabIndex = 0;
            btnIncrement.Text = "+1";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(230, 176);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(187, 130);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(41, 15);
            lblCount.TabIndex = 3;
            lblCount.Text = "число";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCount);
            Controls.Add(btnReset);
            Controls.Add(btnIncrement);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncrement;
        private Button btnReset;
        private Label lblCount;
    }
}
