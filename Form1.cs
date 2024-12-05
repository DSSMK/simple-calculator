namespace day4
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            result = num1 + num2;
            label4.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            result = num1 - num2;
            label4.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            result = num1 * num2;
            label4.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            result = num1 / num2;
            label4.Text = Convert.ToString(result);
        }
    }
}
