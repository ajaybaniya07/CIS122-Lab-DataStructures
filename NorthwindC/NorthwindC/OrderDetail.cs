// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class OrderDetail  //making class 
    {
        // variables
        private int orderId = -1;
        private int productId = -1;
        private int unitPrice = -1;
        private int quantity = 0;
        private double discount = 0.0;

        


        //gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                {
                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }


        }

        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = 0;
                }
            }


        }

        public int UnitPrice
        {
            get { return this.unitPrice.; }
            set
            {
                if (value > -1)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0;
                }
            }


        }

        public int Quanity
        {
            get { return this.quanity; }
            set
            {
                if(value > 0)
                {
                    this.quanity = value;

                }
                else
                {
                    this.quanity = 0;
                }
            }
        }

        public double Discount
        {
            get { return this.Discount; }
            set
            {
                if (value > -1)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = 0;
                }
            }


        }

        public OrderDetail() : this(-1, -1, -1, 0, 0.0)
        {
            //empty constructor
        }

        public OrderDetail(int aOrderId, int aQuanitiy) : this(aOrderId, -1, -1, aQuanitiy, 0.0)
        {
            //partial constructor 
        }

        public OrderDetail(int aOrderId, int aProductId, int aUnitPrice, int aQuantity, double aDiscount)
        {
            //full constructor
            this.OrderId = aOrderId;
            this.ProductId = aProductId;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }

        //TOSting methods
        public override string ToString()
        {
            string message = " ";
            message = message + "OrderId" + this.OrderId + "\n";
            message = message + "ProductId" + this.ProductId + "\n";
            message = message + "UnitPrice" + this.UnitPrice + "\n";
            message = message + "Discount" + this.Discount + "\n";
        }



    }

}
