namespace Ders1_hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Serhat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label8.Text = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazýlým Mühendisliði";
            // label9.Text = textBox1.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }
}
