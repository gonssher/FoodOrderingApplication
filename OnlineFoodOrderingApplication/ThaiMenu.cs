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
    public partial class ThaiMenu : Form
    {
        public ThaiMenu()
        {
            InitializeComponent();
           saladAmt.Text=rest.fillLabelSalad();
            chickenNoodlesAmt.Text = rest.fillLabelChickenNoodle();
            chickenFryAmt.Text = rest.fillLabelChickenFry();
            garlicBreadAmt.Text = rest.fillGarlicBread();
        }
        Restaurant rest = new Restaurant();
        
        private void ThaiMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void ChickenFryCart_Click(object sender, EventArgs e)
        {


            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Chicken Fry" + "','" + 15 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                thaiConfirm.Text = ("Chicken Fry has been added to Cart");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ChickenNoodleCart_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Chicken Noodle" + "','" + 12.5 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                thaiConfirm.Text = ("Chicken Noodles has been added to Cart");
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChickenSaladCart_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Salad" + "','" + 8 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                thaiConfirm.Text = ("Chicken Salad has been added to Cart");
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GarlicBreadCart_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Garlic Bread" + "','" + 7 + "','" + User.UserID + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                thaiConfirm.Text=("Garlic Bread has been added to Cart");
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            Ghst checkk = new Ghst();
            checkk.ShowDialog();
        }
    }
}

