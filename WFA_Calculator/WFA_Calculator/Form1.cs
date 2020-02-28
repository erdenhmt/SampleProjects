using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) + Convert.ToInt32(txtnumber2.Text);
            lblCalculatorResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) - Convert.ToInt32(txtnumber2.Text);
            lblCalculatorResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) * Convert.ToInt32(txtnumber2.Text);
            lblCalculatorResult.Text = result.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) / Convert.ToInt32(txtnumber2.Text);
            lblCalculatorResult.Text = result.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtnumber2.Text = "";
            lblCalculatorResult.Text = "";
        }
    }
}
