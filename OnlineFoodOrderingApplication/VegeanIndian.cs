using MySql.Data.MySqlClient;
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
    public partial class VegeanIndian : Form
    {
        string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
        public VegeanIndian()
        {
            InitializeComponent();
            DalChaawalPrice.Text = rest.fillLabelDalChaawal();
            biryaniPrice.Text = rest.fillLabelBiryani();
            RajmaPirce.Text = rest.fillLabelRajma();
            DosaPrice.Text = rest.fillLabelDosa();
        }
        Restaurant rest = new Restaurant();

     

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            Ghst checkk = new Ghst();
            checkk.ShowDialog();
        }

       
    

        private void DalchawAdd_Click_1(object sender, EventArgs e)
        {
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Dal Chaawal" + "','" + 10.25 + "','" + User.UserID + "');";
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
                MessageBox.Show(ex.Message);
            }

        }

        private void BiryaniAdd_Click_1(object sender, EventArgs e)
        {

            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Biryani" + "','" + 9.25 + "','" + User.UserID + "');";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void RajmaAdd_Click_1(object sender, EventArgs e)
        {
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Rajma" + "','" + 7.25 + "','" + User.UserID + "');";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void DosaAdd_Click_1(object sender, EventArgs e)
        {
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email) values ('" + "Dosa" + "','" + 4.25 + "','" + User.UserID + "');";
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
