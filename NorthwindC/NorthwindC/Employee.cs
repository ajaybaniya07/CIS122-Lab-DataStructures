// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Employee  // making clas
    {
        //variables
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;




        //gets and sets
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = -0;
                }
            }


        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }

        }

        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }

        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                if (value < 0)
                {
                    this.reportsTo = 0;
                }
                else
                {
                    this.reportsTo = value;
                }
            }

        }


        public Employee():this (-1,"n/a","n/a","n/a", "n/a", "n/a","n/a", "n/a", "n/a","n/a", "n/a", 
        "n/a","n/a","n/a", "n/a", -1)
        {
            // empty constructor
        }

        public Employee(int aEmployeeId,string aFirstName) : this(aEmployeeId, "n/a", aFirstName , "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a",
        "n/a", "n/a", "n/a", "n/a", -1)
        {
            // partial constructor
        }


        // full constructor
        public Employee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, 
        string aTitleOfCourtesy, string aBirthDate, string aHireDate,
        string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, 
        string aHomePhone, string aExtension, string aNotes, int aReportsTo)
        {
            this.EmployeeId = aEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;

        }

        public override string ToString()  // To srting methods
        {
            string message = " ";
            message = message + "EmployeeId" + this.EmployeeId + "\n";
            message = message + "LastName" + this.LastName + "\n";
            message = message + "FirstName" + this.FirstName + "\n";
            message = message + "titleOfCourtesy" + this.TitleOfCourtesy + "\n";
            message = message + "BirthDate" + this.BirthDate + "\n";
            message = message + "HireDate" + this.HireDate + "\n";
            message = message + "Address" + this.Address + "\n";
            message = message + "City" + this.City + "\n";
            message = message + "Region" + this.Region + "\n";
            message = message + "Country" + this.Country + "\n";
            message = message + "Phone" + this.Phone + "\n";
            message = message + "Fax" + this.Fax + "\n";
            message = message + "Extension" + this.Extension + "\n";
            message = message + "Notes" + this.Notes + "\n";
            message = message + "ReportsTo" + this.ReportsTo + "\n";

            return message;

        }
    }

}
