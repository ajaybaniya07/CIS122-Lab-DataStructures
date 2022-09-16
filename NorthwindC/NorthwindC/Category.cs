// written by ajay
// aug 29,2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Category // making class
    {
        // class variabls (instance)
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";


        // accessores and mutators (gets and sets)
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

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }


        public override string ToString() // ToString methods
        {
            string message = " ";
            message = message + "CategoryId" + this.CategoryId + "\n";
            message = message + "CategoryId" + this.CategoryName + "\n";
            message = message + "Description" + this.Description + "\n";
            return message;

        }



    }




}
