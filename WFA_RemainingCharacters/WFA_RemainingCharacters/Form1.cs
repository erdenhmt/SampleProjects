using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RemainingCharacters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int characterNumber =450;
        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {

            int currentNumberofCharacters = txtCharacter.Text.Length;
            int difference = characterNumber - currentNumberofCharacters;
            lblCharacter.Text = difference.ToString();
        }
    }
}