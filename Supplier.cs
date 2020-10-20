using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace inventoryItemApplication
{   
    
    internal class Supplier
    {
        public  string supplierName;
        public string supplierId;
        public  string items;

        public bool getItems;

        public Supplier(string supplierId, string supplierName, bool getItems)
        {
            this.supplierName = supplierName;
            this.supplierId = supplierId;
            this.getItems = getItems;
            this.items = null;
        }

        public bool  GetSupply(bool condition)
        {
            bool tempValue = condition;

            if (tempValue == true)
            {
                return tempValue;
            }
            return getItems;
        }
        public bool ValidSuppplier()
        {
            return true;
        }

        public string lookForSupplier()
        {
            return "";
        }

    }
}