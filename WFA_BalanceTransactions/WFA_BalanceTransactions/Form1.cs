using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BalanceTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal balance = 500;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Text = balance.ToString();

        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            if (balance>nudWithDraw.Value )
            {
                balance -= nudWithDraw.Value;
                
            }
            else
            {
                MessageBox.Show("The balance is not enough");
            }
            lblBalance.Text = balance.ToString();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (nudDeposit.Value>0)
            {
                balance += nudDeposit.Value;
                lblBalance.Text = balance.ToString();
            }
            else
            {
                MessageBox.Show("Enter a value greater than 0");
            }
            
        }
    }
}
