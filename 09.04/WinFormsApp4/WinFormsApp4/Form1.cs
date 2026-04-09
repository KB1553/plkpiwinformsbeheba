namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            bool isLengthValid = double.TryParse(textBox1.Text, out double length);
            bool isWidthValid = double.TryParse(textBox2.Text, out double width);

            if (!isLengthValid || !isWidthValid)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (length <= 0 || width <= 0)
            {
                MessageBox.Show("Довжина та ширина повинні бути більшими за нуль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double area = length * width;
            double perimeter = 2 * (length + width);

            lblResult.Text = $"Площа: {area}\nПериметр: {perimeter}";
        }
    }
}
