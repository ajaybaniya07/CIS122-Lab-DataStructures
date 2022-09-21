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
        public string quantityPerUnit = "n/a";
        public double unitPrice = 0.0;
        public int unitInStock = -1;
        public int unitInOrder = -1;
        public int reorderLevel = -1;
        public discontinued = false;


        // gets and set
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

        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { quantityPerUnit = value; }
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

        public int UniteInOrder
        {
            get { return this.unitInOrder; }
            set
            {
                if (value > -1)
                {
                    this.unitInOrder = value;
                }
                else
                {
                    this.unitInOrder = 0;
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
            set { this.discontinued = value; }
            
        }

        public Product(): this(-1,"n/a" ,-1,-1,"n/a",0.0,-1,-1,9999,true)
        {
            //This is an empty constructor
        }


        public Product(int aProductID, string aProductName) : this(aProductID, aProductName,-1,-1,"n/a",0.0,-1,-1,9999,true)
        {
            //Partial Constructor
        }

        public Product(int aProductID, string aProductName, int aSupplierId, int aCategoryId, 
        string aQuantityPerUnit, double aUnitPrice, int aUnitsInStock, int aUnitInOrder, 
        int aReorderLevel, int aDiscontinued)
        {
            this.ProductId = aProductID;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitInStock = aUnitsInStock;
            this.UnitInOrder = aUnitInOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;
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
