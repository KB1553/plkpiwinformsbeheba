namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
     
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            counter++; 
            lblCount.Text = counter.ToString(); 
        }

      
        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0; 
            lblCount.Text = counter.ToString(); 
        }
    }
}