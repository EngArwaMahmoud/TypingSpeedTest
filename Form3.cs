using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowProject
{
    public partial class Form3 : Form
    {
    int counter = 30;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0x0600 && e.KeyChar <= 0x06FF)
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Enabled = true;
            timer1.Enabled = true;
            counter = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label3.Text = counter.ToString();
            if (counter == 0)
            {
                timer1 .Enabled = false;
                textBox1 .Enabled = false;
                Console.Beep();
                MessageBox.Show("Time up! Great work 😍");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 30;
            label3.Text = counter.ToString();
            textBox1.Enabled = false;
            timer1 .Enabled = false;
        }
    }
}
