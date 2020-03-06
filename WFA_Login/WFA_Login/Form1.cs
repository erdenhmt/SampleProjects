using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int character;
        private void Form1_Load(object sender, EventArgs e)
        {
            character= random.Next(1000000, 10000000);
            lblCharacter.Text = character.ToString();
            timer1.Start();
                

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length>0)
            {
                if (Convert.ToInt32(lblCharacter.Text) == Convert.ToInt32(txtValue.Text))
                {
                    MessageBox.Show("Successful Login");
                }
                else
                {
                    if (lblRemaining.Text != "0")
                    {
                        int remainingInput = Convert.ToInt32(lblRemaining.Text);
                        remainingInput--;
                        lblRemaining.Text = remainingInput.ToString();
                        character = random.Next(1000000, 10000000);
                        lblCharacter.Text = character.ToString();
                    }
                  else
                    {
                        MessageBox.Show("you can't try more");
                        btnSignIn.Enabled = false;
                        txtValue.Enabled = false;

                    }

                }
            }

            else
            {
                MessageBox.Show("please define at least one value");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int duration = Convert.ToInt32(lblTime.Text);
            duration--;
            lblTime.Text = duration.ToString();
            if (duration == 0)
            {
               
                btnSignIn.Enabled = false;
                txtValue.Enabled = false;
                timer1.Stop();
            }
            else if (duration<=5)
            {
                btnSignIn.BackColor = Color.Red;



            }

            

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            if (txtValue.Text.Length==0)
            {

                timer1.Start();
            }
        }
    }
}
