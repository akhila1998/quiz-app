using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizsample1;


namespace quizsample
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void optyes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
