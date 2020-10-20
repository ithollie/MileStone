using System;
using System.Data;
using System.Threading;

namespace inventoryItemApplication
{
    internal class Customer: Payment
    {
        public int id;
        public string name;
        public string customerLocation;

        public string[] itemBought;

        public NodeClass inventoryItem;

        public Customer(string id, string name,  string customerLocation, NodeClass inventoryItem)
        {
            this.name = name;
            this.id =   Int32.Parse(id);
            this.customerLocation = customerLocation;
            this.inventoryItem    = inventoryItem;
            this.itemBought = new string[12];
        }


        internal void BuyItem(string item, int paymentAmount, InventoryItemClass counter)
        {
            int temp = 0;
            NodeClass tempNode = null;

            NodeClass data = inventoryItem;

            while (data != null)
            {
            
                if (data.name == item && data.soled == false)
                {
                   
                    if (PaymentSuccess(paymentAmount) ==  true)
                    {
                         itemBought[0] = item;
                         tempNode = data;
                         temp++;
                         counter.count--;
                         data.itemSold(); 
                    }
                }

                data = data.NextNode;
            }

            if(temp == 1)
            {
                Console.WriteLine(name + " just bought an or a " + " [ " + tempNode.name + " ] " + " computer");
            }

            if(temp == 0)
            {
                Console.WriteLine( name + " tries to buy an item,  but it is " + " 0ut  of  stock");
            }
            
        }

        public  void deleteCustomer()
        {

        }
        public void updateCustomer()
        {

        }
        public   void  addCustomer()
        {


        }
    }
}