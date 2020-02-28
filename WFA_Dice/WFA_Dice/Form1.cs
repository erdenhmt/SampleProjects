using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int randomnumber1;
        int randomnumber2;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDice2.Enabled = false;
        }

        private void btnDice1_Click(object sender, EventArgs e)
        {
            randomnumber1 = rnd.Next(1, 7);
            lblDice1.Text = randomnumber1.ToString();
            btnDice1.Enabled = false;
            btnDice2.Enabled = true;

        }

        private void btnDice2_Click(object sender, EventArgs e)
        {
            randomnumber2 = rnd.Next(1, 7);
            lblDice2.Text = randomnumber2.ToString();
            btnDice2.Enabled = false;
            if (randomnumber1>randomnumber2)
            {
                MessageBox.Show("First Won");
            }
           else  if (randomnumber1 == randomnumber2)
            {
                MessageBox.Show("Draw");
                
            }
           else  if(randomnumber1<randomnumber2)
            {
                MessageBox.Show("Second Won");
            }

        }
    }
}
