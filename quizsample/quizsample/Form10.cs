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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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
            this.Hide();


            int x1 = Globals.Score;
            if (x1 == 10)
            {
                Form23 f23 = new Form23();
                f23.Show();
            }
            else
            {
                // MessageBox.Show("Your score is " + x1);
                if (x1 == 0)
                {
                    Form13 f13 = new Form13();
                    f13.Show();
                }

                if (x1 == 1)
                {
                    Form14 f14 = new Form14();
                    f14.Show();
                }
                if (x1 == 2)
                {
                    Form15 f15 = new Form15();
                    f15.Show();
                }
                if (x1 == 3)
                {
                    Form16 f16 = new Form16();
                    f16.Show();
                }

                if (x1 == 4)
                {
                    Form17 f17 = new Form17();
                    f17.Show();
                }

                if (x1 == 5)
                {
                    Form18 f18 = new Form18();
                    f18.Show();
                }

                if (x1 == 6)
                {
                    Form19 f19 = new Form19();
                    f19.Show();
                }

                if (x1 == 7)
                {
                    Form20 f20 = new Form20();
                    f20.Show();
                }

                if (x1 == 8)
                {
                    Form21 f21 = new Form21();
                    f21.Show();
                }

                if (x1 == 9)
                {
                    Form22 f22 = new Form22();
                    f22.Show();
                }
            }
        }
    }
}
