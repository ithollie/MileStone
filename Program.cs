using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryItemApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Inserting Inventory");

            InventoryItemClass app = new InventoryItemClass();

             //insert  inventory
             app.Insert("Apple","100", "new", "d", "It is a great product", false);
             app.Insert("dell", "200", "new", "ui" ,"It is for real",  false);
             app.Insert("msi", "3000", "new",  "73h" , "for real it",  false);
             app.Insert("esprone", "200", "new",  "p3" ,  "nice one", false);
             app.Insert("Mics", "500", "new", "cfr", "It is a great product", false);
             app.Insert("tvs", "100", "new", "yt", "It is for real", false);
             app.Insert("phone", "900", "new", "73h", "for real it", false);
             app.Insert("keyboard", "400", "new", "p3", "nice one", false);
            
            //display inventory
            app.DisplayInventoryItems();

            Console.WriteLine(" ");
            //number of  inventory
            Console.WriteLine("current Inventory  count is = " + app.GetCount());

            Console.WriteLine(" ");

            //customers
            Customer customer1 = new Customer("1234" , "Ibrahim", "unitedStates", app.first);
            Customer customer2 = new Customer("32324", "John", "Germany" ,app.first);
            Customer customer3 = new Customer("3443" , "Jee", "Mexcio", app.first);

            //buying inventory
            customer1.BuyItem("Apple", 50, app);
            customer2.BuyItem("Apple", 50, app);
            customer3.BuyItem("dell",  50, app); 

            Console.WriteLine("Sold Inventory ------>");

            Console.WriteLine(" ");

            //The number of inventory
            Console.WriteLine("Inventory  count is = " + app.GetCount());

            //display inventory
            Console.WriteLine("Sold items");
            app.DisplaySoldInventoryItems();


            Console.WriteLine("");
            Console.WriteLine("Deleted Items ");

            string item1 = "Apple";
            string item2 = "dell";
            string item3 = "phone";

            Console.WriteLine("Removing " + item1 + "  is =>  " +  app.DeleteFunction(item1));
            Console.WriteLine("Removing " + item2 + "  is =>  " +  app.DeleteFunction(item2));
            Console.WriteLine("Removing " + item3 + "  is =>  " +  app.DeleteFunction(item3));
            Console.WriteLine("Removing " + "keyboard" + " is =>  " +  app.DeleteFunction("keyboard"));
            Console.WriteLine("Removing " + "tvs" + " is =>  " + app.DeleteFunction("tvs"));
            Console.WriteLine("");
            
            Console.WriteLine("Current Inventory  count is = " + app.GetCount());

            Console.WriteLine(" ");
            Console.WriteLine("Updating price");
          

            app.UpdatePrice("msi", "1500" , app.first);
            app.UpdatePrice("esprone","2400", app.first);

            Console.WriteLine(" ");
            //display inventory
            app.DisplayInventoryItems();
        }
    }
}
