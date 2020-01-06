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

namespace OnlineFoodOrderingApplication
{
    public partial class Home : Form
    {
        string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
        public Home()
        {
            InitializeComponent();
           
        }

  
  

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("You have been logged out ");
            Login lgForm = new Login();
            lgForm.Show();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.ShowDialog();

        }

        private void Checkout_Click(object sender, EventArgs e)
        {
           
            Ghst checkk = new Ghst();
       
            checkk.ShowDialog();
        }

        private void Deal_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "McChicken Combo" + "','" + 12.50 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
               dealss.Text = (" McChicken Combo has been added to cart");
                while (myReader.Read())
                {
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubwayComboC_Click(object sender, EventArgs e)
        {
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Subway Combo" + "','" + 13.00 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                dealss.Text = (" Theo Combo has been added to cart");
                while (myReader.Read())
                {
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThaiCombo_Click(object sender, EventArgs e)
        {
            
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Thai Combo" + "','" + 12.50 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                dealss.Text = (" McChicken Combo has been added to cart");
                while (myReader.Read())
                {
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IndianCom_Click(object sender, EventArgs e)
        {
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Indian Combo" + "','" + 13.50 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                dealss.Text = (" Indian Combo has been added to cart");
                while (myReader.Read())
                {
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
