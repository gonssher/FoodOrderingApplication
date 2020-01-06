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
    public partial class Ghst : Form
    {
        public Ghst()
        {
           
            InitializeComponent();
            fillme();
            fillLabelTotalPrices();
            fillLabelGstHst();
            fillLabelDeliverFee();
            fillLabelGrandTotal();
            diablingButtons();



        }
        void diablingButtons()
        {
            if (dgvCart.Rows.Count > 0 && dgvCart.Rows.Count < 2)
            {
                pp.Enabled = false;
                deleteItem.Enabled = false;
            }
            else
            {
                pp.Enabled = true;
                deleteItem.Enabled = true;
            }

        }


        void fillme()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from studentinformation.food_orders ORDER BY Food_Name; ", conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open(); 
                myReader = cmdDataBase.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(myReader);

                DataTable tempDt = new DataTable();
                tempDt = dt.DefaultView.ToTable(false, "Order_ID", "Food_Name", "Unit_Price", "CustomOptions");
                dgvCart.DataSource = tempDt;
            }
            catch (Exception ex)
            {

            }
            conDatabase.Close();
        }
        void fillLabelTotalPrices()

        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "select sum(Unit_price) from studentinformation.food_orders where Email='" + User.UserID + "';;";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string totalPrice = myReader.GetDouble("sum(Unit_price)").ToString();
                    Tprices.Text = totalPrice;

                }


            }
            catch (Exception ex)
            {
              
            }
        }

        void fillLabelGstHst()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "select sum(Unit_price)*0.13 as GST from studentinformation.food_orders where Email='" + User.UserID + "';;";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string GstHst = myReader.GetDouble("GST").ToString();
                    GsHst.Text = GstHst;

                }


            }
            catch (Exception ex)
            {
           
            }
        }
        void fillLabelDeliverFee()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "select Delivery_fee from studentinformation.food ;";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string GstHst = myReader.GetDouble("Delivery_fee").ToString();
                    dfee.Text = GstHst;

                }


            }
            catch (Exception ex)
            {
                
            }

        }
        void fillLabelGrandTotal()
        {
            /*SELECT
             sum(((Unit_price) + (Unit_price * 0.13))) + 3 as 'Grand Total'
            FROM studentinformation.food_orders*/
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "SELECT sum(((Unit_price) + (Unit_price * 0.13))) + 3 as 'Grand Total'  FROM studentinformation.food_orders where Email='" + User.UserID + "';;";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string GrandTotals = myReader.GetDouble("Grand Total").ToString();
                    grandTotal.Text = GrandTotals;
                  
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }

  
        
        private void ProccedToPayment_Click(object sender, EventArgs e)
        {
           
           
            Payment pyy = new Payment();
            pyy.ShowDialog();
         
        }

        private void Tprices_Click(object sender, EventArgs e)
        {

        }

       
            private void DeleteItem_Click(object sender, EventArgs e)
        {

            int order_id = (int) dgvCart.CurrentRow.Cells[0].Value;

           /* string name = selectedItems.SelectedItem.ToString();
            Console.WriteLine(name);
            */
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("delete from studentinformation.food_orders where Order_ID = @Order_ID" , conDatabase);
            cmdDataBase.Parameters.AddWithValue("@Order_ID", order_id);

            try
            {
                conDatabase.Open();
                cmdDataBase.ExecuteNonQuery();
                fillme();
                fillLabelTotalPrices();
                fillLabelGstHst();
                fillLabelDeliverFee();
                fillLabelGrandTotal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

     
    }
            
            
           
        
    
}
