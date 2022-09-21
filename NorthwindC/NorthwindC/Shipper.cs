// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Shipper // making class
    {
          // variables
        public int shipperId = -1;
        public string companyName = "n/a";
        public string phone = "n/a";



        //gets and sets
        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                }
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //Empty Constructor
        public Shipper() : this(-1, "n/a", "n/a")
        {

        }

        //Partial Constructor
        public Shipper(int aShipperId) : this(aShipperId, "n/a", "n/a")
        {

        }



        //Constructor
        public Shipper(int aShipperId, string aCompanyName, string aPhone)
        {
            this.ShipperId = aShipperId;
            this.CompanyName = aCompanyName;
            this.Phone = aPhone;

        }


        public override string ToString() //ToString methods
        {
            string message = " ";
            message = message + "ShipperID" + this.ShipperId + "\n";
            message = message + "Company Name" + this.CompanyName + "\n";
            message = message + "Phone" + this.Phone + "\n";
            return message;

        }


    }

}
