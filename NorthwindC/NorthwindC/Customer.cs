// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Customer // making class
    {
        private string customerID = "n/a";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";


    


        //gets and sets
        public string CustomerID
        {
            get { return this.customerID; }
            set { customerID = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactTitle = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { city = value; }
        }

        public string Region
        {
            get { return this.region; }
            set { region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { postalCode = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { country = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { fax = value; }
        }


        public Customer() : this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //empty constructor
        }

        public Customer(string aCustomerID, string aContactTitle, string aPhone,
        string aFax) : this(aCustomerID, "n/a", "n/a", aContactTitle, "n/a", "n/a", "n/a", "n/a", "n/a", aPhone, "n/a")
        {
            //partial constructor
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle,
        string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone,
        string aFax)
        {
            this.customerID = aCustomerID;
            this.companyName = aCompanyName;
            this.contactName = aContactName;
            this.contactTitle = aContactTitle;
            this.address = aAddress;
            this.city = aCity;
            this.region = aRegion;
            this.postalCode = aPostalCode;
            this.country = aCountry;
            this.phone = aPhone;
            this.fax = aFax;

        }

        //toString methods
        public override string ToString()
        {
            string message = " ";
            message = message + "customerID" + this.CustomerID + "\n";
            message = message + "CompanyName" + this.CompanyName + "\n";
            message = message + "ContactName" + this.ContactName + "\n";
            message = message + "Address" + this.Address + "\n";
            message = message + "City" + this.City + "\n";
            message = message + "Region" + this.Region + "\n";
            message = message + "Country" + this.Country + "\n";
            message = message + "Phone" + this.Phone + "\n";
            message = message + "Fax" + this.Fax + "\n";


            return message;

        }

    }

}
