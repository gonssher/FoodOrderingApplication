using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace OnlineFoodOrderingApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            emptyTable();
            password.MaxLength=12;


        }
      
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        void emptyTable()
        {
          

          
                string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
                string Query = "delete from studentinformation.food_orders ;";

                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;


                try
                {
                    conDatabase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {
                        

                    }


                }
                catch (Exception ex)
                {

                }
            

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (email.Text == string.Empty || !email.Text.Contains("@"))
               
            {
                errors.Text=("Please enter valid Email");
            }

            else if (password.Text == string.Empty)
            {
                errors.Text = ("Please enter your Password");
            }
            else if (email.Text.Length > 0 && password.Text.Length > 0)
            {
                string constring = ("datasource=localhost; port=3306; username=root; password=shannonnA4");


                try
                {
                    if (email.Text == "" && password.Text == "")
                    {
                        errors.Text = ("Please enter username and password");
                    }
                    else
                    {

                        MySqlConnection condDatabase = new MySqlConnection(constring);

                        MySqlCommand cmddDataBase = new MySqlCommand("Select * from studentinformation.verification where Email=@emaill and Password=@pswd", condDatabase);



                        cmddDataBase.Parameters.AddWithValue("@emaill", email.Text);
                        cmddDataBase.Parameters.AddWithValue("@pswd", password.Text);
                        condDatabase.Open();
                        MySqlDataAdapter adpt = new MySqlDataAdapter(cmddDataBase);
                       
                        DataSet ds = new DataSet();
                        adpt.Fill(ds);
                        condDatabase.Close();

                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1)
                        {
                            
                            User.Email = (string)ds.Tables[0].Rows[0]["Email"];
                            User.FirstName = (string)ds.Tables[0].Rows[0]["FirstName"];
                            User.LastName = (string)ds.Tables[0].Rows[0]["LastName"];
                            User.PhoneNumber = (string)ds.Tables[0].Rows[0]["PhoneNumber"];
                            User.Address = (string)ds.Tables[0].Rows[0]["Address"];
                            User.UserID = User.Email;
                            MessageBox.Show("Succesful login" +"  " + User.FirstName);
                           
                            this.Hide();
                            Home f = new Home();
                            f.ShowDialog();
                           




                        }
                        else 
                        {
                            errors.Text = ("Incorrect Username or Password");

                        }
                   

                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignUp signup = new SignUp();
            signup.Show();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            errors.Text = "";
          
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            errors.Text = "";
        }
    }
}
