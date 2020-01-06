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
    public partial class CustomizedForm : Form
    {
        string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";

        public CustomizedForm()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox b = (CheckBox)c;
                    if (b.Checked)
                    {
                        s = b.Text + s;
                    }
                    
                }
            }

            string f = "";
            foreach (Control a in this.groupBox2.Controls)
            {
                if (a is CheckBox)
                {
                    CheckBox d = (CheckBox)a;
                    if (d.Checked)
                    {
                        f = d.Text + f;
                    }
                  
                }
            }

            string s1 = "";
            foreach (Control c1 in this.groupBox3.Controls)
            {
                if (c1 is CheckBox)
                {
                    CheckBox b1 = (CheckBox)c1;
                    if (b1.Checked)
                    {
                        s1 = b1.Text + s1;
                    }
                }
                
            }
            string Query = "insert into studentinformation.food_orders(food_name,Unit_Price,Email,CustomOptions) values ('" + s + "','" + 11 + "','" + User.UserID + "','" + s1 +","+ "'); ";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                subwayItem.Text = ("Sandwhich has been added to cart");
                while (myReader.Read())
                {
                    //cmdDataBase.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
