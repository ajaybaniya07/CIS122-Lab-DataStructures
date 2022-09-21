// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    internal class Supplier // making class
    {

        // variables
        public int supplierId = -1;
        public string companyName = "n/a";
        public string contactName = "n/a";
        public string contactTitle = "n/a";
        public string address = "n/a";
        public string city = "n/a";
        public string region = "n/a";
        public string postalCode = "n/a";
        public string country = "n/a";
        public string phone = "n/a";
        public string fax = "n/a";
        public string homePage = "n/a";




        //gets and setts
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { companyName = value; }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }

        }

        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { contactTitle = value; }
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
            get { return this.Region; }
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

        public string Homepage
        {
            get { return this.homePage; }
            set { homePage = value; }
        }

        public Supplier() : this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //Empty constructors
        }




        public Supplier(int aSupplierId, string aCompanyName, string aContactName) : this(aSupplierId, 
        aCompanyName, aContactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //Partial Constructor
        }




        //Constructor
        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, 
        string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry,
        string aPhone, string aFax, string aHomepage)
        {
            this.SupplierId = aSupplierId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
            this.Homepage = aHomepage;
        }


        public override string ToString() //ToString methods
        {
            string message = " ";
            message = message + "SupplierID" + this.SupplierId + "\n";
            message = message + "CompanyName" + this.CompanyName + "\n";
            message = message + "ContactName" + this.ContactName + "\n";
            message = message + "ContactTitle" + this.ContactTitle + "\n";
            message = message + "Address" + this.Address + "\n";
            message = message + "City" + this.City + "\n";
            message = message + "Region" + this.Region + "\n";
            message = message + "Country" + this.Country + "\n";
            message = message + "Phone" + this.Phone + "\n";
            message = message + "Fax" + this.Fax + "\n";
            message = message + "HomePage" + this.Homepage + "\n";

            return message;

        }



    }

}
