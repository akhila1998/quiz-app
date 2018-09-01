using System;
using System.Windows.Forms;
using quizsample1;
using System.Drawing;

namespace quizsample
{
    public  partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         void button1_Click(object sender, EventArgs e)
        {
           
            if (optyes.Checked)
            {
                MessageBox.Show("Well done");
                int x = Globals.Score;

                Globals.SetScore(x+1);
            }
            else
            {
                MessageBox.Show("Not there yet!!!");
            }
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
            if (optyes.Checked)
            {
                MessageBox.Show("Well done");
                int x = Globals.Score;

                Globals.SetScore(x + 1);
            }
            else
            {
                MessageBox.Show("Wrong!!!" + "\n\n" + "Option B is correct");
            }
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
