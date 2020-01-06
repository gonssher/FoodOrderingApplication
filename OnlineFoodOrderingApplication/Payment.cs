using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFoodOrderingApplication
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            cvv.MaxLength = 3;
            cardNumber.MaxLength = 17;
        
        }
     
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CardHolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void Cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ConfirmOrderBtn_Click(object sender, EventArgs e)
        {

            if (cardHolderName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your First Name");
            }

            else if (cardNumber.Text.Length < 17)
            {

                MessageBox.Show("Card Number can't be left incomplete");

            }

            else if (cvv.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Email");
            }
            else
            {
                MessageBox.Show("Your Payment Has Been Accepted ." +
                    "Your Order is on its way");
               
                this.Close();
            }
            }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
