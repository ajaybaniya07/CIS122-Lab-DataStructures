// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Order // making class
    {

        // variables
        private int orderId = -1;
        private string customerId = "n/a";
        private int employedId = -1;
        private date oderDate = -1;
        private date requiredDate = -1;
        private date shippedDate = -1;
        private int shipVia = -1;
        private double freight = 0.0;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";


        public Order() : this(-1, "n/a", -1, -1, -1, -1, -1, 0.0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //empty constructor
        }

        public Order(string aShipName, string aShipAdress) : this(-1, "n/a", -1, -1, -1, -1, -1, 0.0, aShipName, aShipAdress, "n/a", "n/a", "n/a", "n/a")
        {
            //partial constructor
        }


      // full constructor

        public Order(int aOrderId, string aCustomerId, int aEmployedId, date aOderDate, 
        date aRequiredDate, date aShippedDate, int aShipVia, double aFreight, string aShipName, 
        string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, 
        string aShipCountry, )
        {
            this.OrderId = aOrderId;
            this.CustomerId = aCustomerId;
            this.EmployedId = aEmployedId;
            this.OderDate = aOderDate;     
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipName = aShipName;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
           this. ShipRegion = aShipRegion;
           this. ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;
           
        }






        // gets and sets

        public int OrderId
        {
            get { return orderId; }
            set
            {
                if (orderId < -1)
                {
                    this.orderId = -1;
                }
                else
                {
                    this.orderId = value;
                }
            }

        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int EmployedId
        {
            get { return employedId; }
            set
            {
                if (orderId < -1)
                {
                    this.employedId = -1;
                }
                else
                {
                    this.employedId = value;
                }
            }

        }

        public int OderDate
        {
            get { return employedId; }
            set
            {
                if (orderId < -1)
                {
                    this.employedId = -1;
                }
                else
                {
                    this.employedId = value;
                }
            }

        }

        public int RequiredDate
        {
            get { return requiredDate; }
            set
            {
                if (value < -1)
                {
                    this.requiredDate = -1;
                }
                else
                {
                    this.requiredDate = value;
                }
            }

        }


        public int ShippedDate
        {
            get { return shippedDate; }
            set
            {
                if (orderId < -1)
                {
                    this.shippedDate = -1;
                }
                else
                {
                    this.shippedDate = value;
                }
            }

        }

        public int ShipVia
        {
            get { return shipVia; }
            set
            {
                if (shipVia < -1)
                {
                    this.shipVia = -1;
                }
                else
                {
                    this.shipVia = value;
                }
            }
        }

        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (freight < 0)
                {
                    freight = 0.0;

                }
                else
                {
                    freight = value;
                }
            }
        }

        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }

        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }

        public string ShipCity
        {
            get { return this.ShipCity; }
            set { this.ShipCity = value; }
        }

        public string ShipRegion
        {
            get { return this.ShipRegion; }
            set { this.ShipRegion = value; }
        }

        public string ShipPostalCode
        {
            get { return this.ShipPostalCode; }
            set { this.ShipPostalCode = value; }
        }

        public string ShipCounrty
        {
            get { return this.ShipCounrty; }
            set { this.ShipCounrty = value; }
        }



        public override string ToString() //ToString methods
        {
            string message = " ";
            message = message + "OrderId" + this.OrderId + "\n";
            message = message + "EmployedId" + this.EmployedId + "\n";
            message = message + "CustomeId" + this.CustomerId + "\n";
            message = message + "OrderDate" + this.OrderDate + "\n";
            message = message + "RequiredDate" + this.RequiredDate + "\n";
            message = message + "ShippedDate" + this.shippedDate + "\n";
            message = message + "ShipVia" + this.ShipVia + "\n";
            message = message + "Freight" + this.Freight + "\n";
            message = message + "ShipName" + this.ShipName + "\n";
            message = message + "ShipAddress" + this.ShipAddress + "\n";
            message = message + "ShipCity" + this.ShipCity + "\n";
            message = message + "ShipRegion" + this.ShipRegion + "\n";
            message = message + "ShipPostalCode" + this.ShipPostalCode + "\n";
            message = message + "ShipCountry" + this.ShipCounrty + "\n";
            return message;

        }








    }


}
