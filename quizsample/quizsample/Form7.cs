﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }
    }
}
