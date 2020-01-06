using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrderingApplication
{
    class SignUpc
    {
        private string employeFirstName;
        private string employeLastName;
        private string emailId;
        private string phoneNumber;
        private string address;
        private string password;


        public SignUpc(string employeFirstName, string employeLastName, string emailId, string phoneNumber, string address, string password)
        {
            this.employeFirstName = employeFirstName;
            this.employeLastName = employeLastName;
            this.emailId = emailId;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.password = password;
        }

        





        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        public string EmployeLastName
        {
            get { return employeLastName; }
            set { employeLastName = value; }
        }

        public string EmployeFirstName
        {
            get { return employeFirstName; }
            set { employeFirstName = value; }
        }

       


    }
}
