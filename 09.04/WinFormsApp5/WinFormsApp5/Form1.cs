namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;        
            lblColorName.Text = "Червоний";
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            lblColorName.Text = "Зелений";
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            lblColorName.Text = "Синій";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            lblColorName.Text = "Жовтий";
        }
    }
}
