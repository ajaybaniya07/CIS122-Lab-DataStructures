// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Product // making class
    {
        //variables
        public int productId = -1;
        public string productName = "n/a";
        public int supplierId = -1;
        public int categoryId = -1;
        public string qualityPerUnit = "n/a";
        public double unitPrice = 0.0;
        public int unitInStock = -1;
        public int unitInOrder = -1;
        public int reorderLevel = -1;
        public discontinued = true;


        // gets and sets
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


        public string ProductName
        {
            get { return this.productName; }
            set { productName = value; }
        }

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

        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
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

        public int UnitInStock
        {
            get { return this.unitInStock; }
            set
            {
                if (value > -1)
                {
                    this.unitInStock = value;
                }
                else
                {
                    this.UnitInStock = 0;
                }
            }
        }

        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set
            {
                if (value > -1)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = 0;
                }
            }
        }

        public int Discontinued
        {
            get { return this.discontinued; }
            set
            {
                if (value > true)
                {
                    this.discontinued = value;
                }
                else
                {
                    this.discontinued = 0;
                }
            }
        }


        // tostring methods
        public override string ToString()
        {
            string message = " ";
            message = message + "ProductId" + this.ProductId + "\n";
            message = message + "ProductName" + this.ProductName + "\n";
            message = message + "SupplierId" + this.SupplierId + "\n";
            message = message + "CategoryId" + this.CategoryId + "\n";
            message = message + "QuantityPerUnit" + this.qualityPerUnit + "\n";
            message = message + "UnitPrice" + this.UnitPrice + "\n";
            message = message + "UnitInStock" + this.UnitInStock + "\n";
            message = message + "UnitOnOrder" + this.UnitOnOrder + "\n";
            message = message + "RecorderLevel" + this.ReorderLevel + "\n";
            message = message + "Discount" + this.Discontinued + "\n";
        }









    }

}
