
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
              /*  int fno=int.Parse(textBox1.Text);
                int sno=int.Parse(textBox2.Text);
                SimpleMath sm = new SimpleMath();
                int sum=sm.Add(fno,sno);
                MessageBox.Show($"{fno} + {sno} = {sum}");*/
                textBox3.Text = InputOutput.input(double.Parse(textBox1.Text), double.Parse(textBox2.Text),'+').ToString();//sum.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Enter small numbers only");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = InputOutput.input(double.Parse(textBox1.Text), double.Parse(textBox2.Text),'-').ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Enter small numbers only");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
      
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = InputOutput.input(double.Parse(textBox1.Text), double.Parse(textBox2.Text), '*').ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Enter small numbers only");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = InputOutput.input(double.Parse(textBox1.Text), double.Parse(textBox2.Text), '/').ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Enter small numbers only");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}