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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (optyes.Checked)
            {
                MessageBox.Show("Well done");
                int x = Globals.Score;

                Globals.SetScore(x + 1);
            }
            else
            {
                MessageBox.Show("Not there yet!!!");
            }
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                MessageBox.Show("Wrong!!!"+"\n"+"Option B is correct");
            }
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
