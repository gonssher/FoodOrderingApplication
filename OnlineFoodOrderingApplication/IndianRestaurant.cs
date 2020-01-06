using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineFoodOrderingApplication
{
    public partial class IndianRestaurant : Form
    {
        public IndianRestaurant()
        {
            InitializeComponent();
            samosaPrice.Text = rest.fillLabelSamosa();
            chanaBhaPrice.Text = rest.fillLabelChanna();
            channaTikaPrice.Text = rest.fillLabelChannaTikka();
            KebabPrice.Text = rest.fillLabelKebabs();

        }
        Restaurant rest = new Restaurant();

        private void IndianItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IndiadnPlacesF_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SamosAdd_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Samosa" + "','" + 6.25 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                itemsConfirmation.Text = (" Samosa has been added to cart");

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChannaBAdd_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Channa Bhatura" + "','" + 8.25 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                itemsConfirmation.Text = (" Channa Bhatura has been added to cart");

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChannaTAdd_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Channa Tikka" + "','" + 11.25 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                itemsConfirmation.Text = (" Channa Tikka has been added to cart");

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KebabAdd_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Kebabs" + "','" + 15.25 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                itemsConfirmation.Text = (" Kebab has been added to cart");

                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            Ghst checkk = new Ghst();
            checkk.ShowDialog();
        }
    }
}
