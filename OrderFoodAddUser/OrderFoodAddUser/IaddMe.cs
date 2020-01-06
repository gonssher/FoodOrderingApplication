using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderFoodAddUser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IaddMe" in both code and config file together.
    [ServiceContract]
    public interface IaddMe
    {
        [OperationContract]
        string AddUSer(userADD useradd);
    }

    [DataContract]
    public class userADD
    {
        private string employeFirstName;
        private string employeLastName;
        private string emailId;
        private string phoneNumber;
        private string address;
        private string password;

        [DataMember(Order = 6)]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember(Order = 5)]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember(Order = 4)]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [DataMember(Order = 3)]
        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }
        [DataMember(Order = 2)]
        public string EmployeLastName
        {
            get { return employeLastName; }
            set { employeLastName = value; }
        }
        [DataMember(Order = 1)]
        public string EmployeFirstName
        {
            get { return employeFirstName; }
            set { employeFirstName = value; }
        }



    }
}
