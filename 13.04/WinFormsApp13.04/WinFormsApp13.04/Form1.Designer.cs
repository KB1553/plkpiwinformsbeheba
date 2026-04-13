namespace WinFormsApp13._04
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
            btnRun = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            btnOpen = new Button();
            btnSave = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(85, 99);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(105, 57);
            btnRun.TabIndex = 0;
            btnRun.Text = "зара втечу";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // button1
            // 
            button1.Location = new Point(411, 164);
            button1.Name = "button1";
            button1.Size = new Size(51, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += GameButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(484, 164);
            button2.Name = "button2";
            button2.Size = new Size(51, 40);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += GameButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(554, 164);
            button3.Name = "button3";
            button3.Size = new Size(51, 40);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += GameButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(411, 220);
            button4.Name = "button4";
            button4.Size = new Size(51, 40);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += GameButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(484, 220);
            button5.Name = "button5";
            button5.Size = new Size(51, 40);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += GameButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(554, 220);
            button6.Name = "button6";
            button6.Size = new Size(51, 40);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += GameButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(411, 275);
            button7.Name = "button7";
            button7.Size = new Size(51, 40);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += GameButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(484, 275);
            button8.Name = "button8";
            button8.Size = new Size(51, 40);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += GameButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(554, 275);
            button9.Name = "button9";
            button9.Size = new Size(51, 40);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += GameButtonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 120);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 10;
            label1.Text = "хрестики нолики";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(883, 181);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 11;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1038, 181);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(883, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 646);
            Controls.Add(textBox1);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button btnOpen;
        private Button btnSave;
        private TextBox textBox1;
    }
}
