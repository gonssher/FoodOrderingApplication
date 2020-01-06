using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineFoodOrderingApplication
{
    class Restaurant
    {
        private System.Collections.ArrayList list;

        private String ChickenNoodle;
        private String priceSalad;
        private String chickenFry;
        private String garlicBread;
        private String subWayChickenSandwhich;
        private String subWayBeefSandwhich;
        private String subWayVegSandWhich;
        private String subWayComboSandwhich;
        private String samosa;
        private String channaBhatura;
        private String channaTikka;
        private String kebab;
        private String name;
        private String dosa;
        private String rajma;
        private String biryani;
        private String dalChaawal;

        private double price;
     
        string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
        public String PriceSalad
        {
            get { return priceSalad; }
            set { priceSalad = value; }
        }
        public Restaurant()
        {
            list = new System.Collections.ArrayList();
        }
        public System.Collections.ArrayList CreateCollectionOfItems()

        {
            list.Add("Thai Express");
            list.Add("Subway");
            list.Add("Indian House");

            return list;
        }
        //Filling the price of the items in the thai restaurnat

        public String fillLabelSalad()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Salad' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string saladAmount = myReader.GetDouble("Unit_Price").ToString();
                    priceSalad = saladAmount;


                }
            }
            catch (Exception ex)
            {

            }
            return priceSalad;
        }
        public String fillLabelChickenNoodle()
        {
            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Chicken Noodles' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string chickenNoodleAmount = myReader.GetDouble("Unit_Price").ToString();
                    ChickenNoodle = chickenNoodleAmount;


                }
            }
            catch (Exception ex)
            {

            }
            return ChickenNoodle;
        }
        public String fillLabelChickenFry()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Chicken Fry' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string chcickenFryAmount = myReader.GetDouble("Unit_Price").ToString();
                    chickenFry = chcickenFryAmount;


                }
            }
            catch (Exception ex)
            {

            }
            return chickenFry;
        }
        public String fillGarlicBread()
        {


            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Garlic Bread' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string garlicBreadAmount = myReader.GetDouble("Unit_Price").ToString();
                    garlicBread = garlicBreadAmount;


                }
            }
            catch (Exception ex)
            {

            }
            return garlicBread;
        }
        public String fillLabelChickenSandwhich()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Chicken Sandwhich' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string chickenSandwhichPrice = myReader.GetInt32("Unit_Price").ToString();
                    subWayChickenSandwhich = chickenSandwhichPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return subWayChickenSandwhich;



        }
        public String fillLabelBeefSandwhich()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Beef Sandwhich' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string beefSandwhichPrice = myReader.GetInt32("Unit_Price").ToString();
                    subWayBeefSandwhich = beefSandwhichPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return subWayBeefSandwhich;
        }

        public String fillLabelVeggieSandwhich()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Veggie Sandwhich' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string vegSandwhichPrice = myReader.GetInt32("Unit_Price").ToString();
                    subWayVegSandWhich = vegSandwhichPrice;

                }

            }
            catch (Exception ex)
            {

            }

            return subWayVegSandWhich;
        }
        public String fillLabelComboSandwhich()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Chicken/beef/fish Combo' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string comboSandwhichPrice = myReader.GetInt32("Unit_Price").ToString();
                    subWayComboSandwhich = comboSandwhichPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return subWayComboSandwhich;
        }

        public String fillLabelSamosa()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Samosa' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string samosaPrice = myReader.GetInt32("Unit_Price").ToString();
                    samosa = samosaPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return samosa;


        }
        public String fillLabelChanna()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Channa Bhatura' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string ChannaBhaturaPrice = myReader.GetInt32("Unit_Price").ToString();
                    channaBhatura = ChannaBhaturaPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return channaBhatura;
        }
        public String fillLabelChannaTikka()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Channa Tikka' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string channaTikkaPrice = myReader.GetInt32("Unit_Price").ToString();
                    channaTikka = channaTikkaPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return channaTikka;
        }
        public String fillLabelKebabs()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Kebabs' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string kebabPrice = myReader.GetInt32("Unit_Price").ToString();
                    kebab = kebabPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return kebab;

        }



      

        public String fillLabelDosa()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Dosa' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string DosaPrice = myReader.GetInt32("Unit_Price").ToString();
                    dosa = DosaPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return dosa;


        }

        public String fillLabelRajma()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Rajma' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string RajmaPrice = myReader.GetInt32("Unit_Price").ToString();
                    rajma = RajmaPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return rajma;


        }



        public String fillLabelDalChaawal()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Dal Chaawal' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string DalChaawalPrice = myReader.GetInt32("Unit_Price").ToString();
                    dalChaawal = DalChaawalPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return dalChaawal;


        }




        public String fillLabelBiryani()
        {

            string Query = "select Unit_Price from studentinformation.food where Food_Name Like 'Biryani' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string BiryaniPrice = myReader.GetInt32("Unit_Price").ToString();
                    biryani = BiryaniPrice;

                }

            }
            catch (Exception ex)
            {

            }
            return biryani;


        }


    }

}

















