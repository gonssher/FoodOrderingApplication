using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using OnlineFoodOrderingApplication.ServiceReference1;


namespace OnlineFoodOrderingApplication
{
    public partial class SignUp : Form
    {
        ServiceReference1.IaddMeClient objServiceClientobjService = new ServiceReference1.IaddMeClient();
        public SignUp()
        {
            InitializeComponent();
            maxAndMinReqTexboxes();
        }
        string pass;

        void maxAndMinReqTexboxes()
        {
            fname.MaxLength = 12;
           Lname.MaxLength = 12;
            email.MaxLength = 40;
            pnumber.MaxLength = 12;
            address.MaxLength = 60;
            password.MaxLength = 12;
           

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();           
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (fname.Text == string.Empty)
            {
                nameFiels.Text = ("Please enter your First Name");

            }

            else if (Lname.Text == string.Empty)
            {
                nameFiels.Text = ("Please enter your Last Name");

            }

            else if (email.Text == string.Empty || !email.Text.Contains("@"))

            {
                emailField.Text = ("Please enter a valid Email address");

            }

            else if (pnumber.Text == string.Empty)
            {
                mobileField.Text = ("Please enter your Phone Number");

            }
            else if (address.Text == String.Empty)
            {
                addrField.Text = ("Please enter address");

            }
            else if (password.Text == string.Empty)
            {
                passField.Text = ("Please enter an appropriate password Maximum 12 characters");
            }
            else if (cPassword.Text == string.Empty)
            {
                cpassFiel.Text = ("Field cant be left empty");
                pass = password.Text;

            }
            else if (password.Text != cPassword.Text)
            {
                mainErrors.Text = ("Password doesnt Match Please check");
            }
            else if (fname.Text.Length > 0 && Lname.Text.Length > 0 && email.Text.Length > 0 && pnumber.Text.Length > 0 && address.Text.Length > 0 && password.Text.Length > 0 && cPassword.Text.Length > 0)
             {
                string constring = ("datasource=localhost; port=3306; username=root; password=shannonnA4");
                string Query = "Select COUNT(*) from studentinformation.verification where Email='" + this.email.Text + "';";
                MySqlConnection conDatabase = new MySqlConnection(constring);
          
                MySqlDataReader myReader;
                try
                {

                    conDatabase.Open();
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);

                    int temp = Convert.ToInt32(cmdDataBase.ExecuteScalar().ToString());



                    if (temp > 0)
                    {
                        MessageBox.Show("User exists");

                    }
                    else
                    {
                     
                            userADD userInfo = new userADD();
                            userInfo.EmployeFirstName = fname.Text;
                            userInfo.EmployeLastName = Lname.Text;
                            userInfo.EmailId = email.Text;
                            userInfo.PhoneNumber = pnumber.Text;
                            userInfo.Address = address.Text;
                            userInfo.Password = password.Text;
                            userInfo.PhoneNumber = pnumber.Text;
                            string result = objServiceClientobjService.AddUSer(userInfo);
                            MessageBox.Show("" + result);
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conDatabase.Close();


            



           

            }
   
            
           
        }

        private void Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            
            }
        }

        private void Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
               

            }
        }

        private void Pnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fname_KeyDown(object sender, KeyEventArgs e)
        {
            nameFiels.Text = "";
        }

        private void Lname_KeyDown(object sender, KeyEventArgs e)
        {
            nameFiels.Text = "";
        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            emailField.Text = "";
        }

        private void Pnumber_KeyDown(object sender, KeyEventArgs e)
        {
            mobileField.Text = "";
        }

        private void Address_KeyDown(object sender, KeyEventArgs e)
        {
            addrField.Text = "";
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            passField.Text = "";
            mainErrors.Text = "";
        }

        private void CPassword_TextChanged(object sender, EventArgs e)
        {
            cpassFiel.Text = "";
            mainErrors.Text = "";
        }
    }
}
