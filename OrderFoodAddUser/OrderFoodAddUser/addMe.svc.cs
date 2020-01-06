using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
namespace OrderFoodAddUser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "addMe" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select addMe.svc or addMe.svc.cs at the Solution Explorer and start debugging.
    public class addMe : IaddMe
    {
       

        public string AddUSer(userADD useradd)
        {

            string message;
            string constring = "datasource=localhost; port=3306; username=root; password=shannonnA4";
            string Query = "insert into studentinformation.verification(Email,Password,FirstName,LastName,PhoneNumber,Address) values ('" + useradd.EmailId + "','" + useradd.Password + "','" + useradd.EmployeFirstName + "','" + useradd.EmployeLastName + "','" + useradd.PhoneNumber + "','" + useradd.Address + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {

                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                message=("Your Registration has been Completed");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                message=(ex.Message);
            }
         
            return message; 
        }
    }
}
