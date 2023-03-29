namespace CalculatorBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double result =  x * y;
            MessageBox.Show("Результатом вычислений является число: " + result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double result = x / y;
            if (y == 0)
            {
                MessageBox.Show("Нельзя поделить на ноль!");
            }
            else
            {
                MessageBox.Show("Результатом вычислений является число: " + result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double result = x + y;
            MessageBox.Show("Результатом вычислений является число: " + result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double result = x - y;
            MessageBox.Show("Результатом вычислений является число: " + result);
        }
    }
}
