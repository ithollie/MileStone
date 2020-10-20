using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace inventoryItemApplication
{
    internal class InventoryItemClass :Supplier
    {
        public NodeClass first;
        public int count;

        public InventoryItemClass() :base("1334", "James", true)
        {
            
            this.first = null;
            this.count = 0;

        }

        public int  GetCount()
        {
            return count;
        }

        public void Insert(string name, string price, string condition, string modal , string discription,  bool  soled)
        {
            NodeClass current = first;

            NodeClass newNode = new NodeClass(name,  price, condition, modal, discription, soled);

            if (current != null)
            {
                newNode.NextNode = first;

                first = newNode;
                count++;
            }
            if(current == null)
            {
                first = newNode;
                count++;
            }
        }

        public void DisplayInventoryItems()
        {
            int increment = 0;

            NodeClass current = first;

            while(current != null)
            {
                increment++;

                if(current.soled == false)
                {
                   
                    Console.WriteLine("Inventory Item "  + increment+  "  => " + " [" + "name:" + current.name + " , " +  " Price:" + " $" + current.price+ ",  Discription:" + current.discription + " , SOLED " + current.soled + " ] ");
                    current = current.NextNode;
                }
                
            }
        }
        public void DisplaySoldInventoryItems()
        {
            

            try
            {
                int increment = 0;

                NodeClass current = first;

                while (current != null)
                {
                    increment++;

                    if (current.soled == true)
                    {
                        increment++;
                        Console.WriteLine("Inventory Item " + increment + "  => " + " [" + "name:" + current.name + " , " + " Price:" + " $" + current.price + ",  Discription:" + current.discription + " , SOLED " + current.soled + " ] ");
                        
                    }
                    current = current.NextNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public bool  FindItem(string name)
        {
            bool temp = false;
            NodeClass current = first;

            while(current != null)
            {
                
                if(current.name == name && current.soled != true)
                {
                    temp = true;
                }

                current = current.NextNode;
            }

            return temp;
        }
        public string findPrice(string name)
        {
            string temp = "";
            NodeClass current = first;

            while (current != null)
            {

                if (current.name == name && current.soled != true)
                {
                    temp = current.price;
                }

                current = current.NextNode;
            }

            return temp;
        }
        public  bool DeleteItem(string name)
        {
            NodeClass current = first;
            NodeClass oldCurrent = first;

            bool temp = false;

            while(current != null)
            {
              
                
                if(current.NextNode != null){
                 
                    
                    
                    oldCurrent = current;

                    current = current.NextNode;

                    if (oldCurrent.NextNode ==  current) {

                        Console.WriteLine("current node  is " + current.name + " && old node is " + oldCurrent.name);

                        if (oldCurrent.name == name)
                        {
                            Console.WriteLine("It is true " + current.name + " is reached ");
                            first = current;
                            temp = true;
                            count--;
                            break;
                        }
                        if (current.name == name)
                        {
                            Console.WriteLine("It is true "  +  current.name + " is reached ");
                            oldCurrent.NextNode  = current.NextNode;
                            temp = true;
                            count--;
                            break;
                        }

                    }
                    

                }else{

                    
                        Console.WriteLine("current node  is " + current.name + " && old node is " + oldCurrent.name);

                        if (current.name == name)
                        {
                            Console.WriteLine("It is true " + current.name + " is reached ");
                            oldCurrent.NextNode = current.NextNode;
                            temp = true;
                            count--;
                            break;
                        }
                    

                }
                    
                

                current = current.NextNode;
            }
            return temp;
        }

        internal string  DeleteFunction(string name)
        {
            string tempValue = null;
            bool item  =  FindItem(name);

            if (item ==  true)
            {
          
                tempValue = name;
                DeleteItem(name);
         
            }
            if(item != true)
            {
                return "not  found or out of stock";
            }
            return tempValue;
        }

        public string  UpdateInventory(string name, string  price,  NodeClass dataBase)
        {
            NodeClass current = dataBase;
            string newPrice = "";

            while (current != null)
            {
                if(current.name == name &&  current.soled != true)
                {
                    current.price = price;
                    return price;

                }
                
                current = current.NextNode;
            }

            return newPrice;
        }

        public void UpdatePrice(string name, string amount, NodeClass DataBase)
        {
            bool item = FindItem(name);
            string  oldPrice   = findPrice(name);

            if (item  == true)
            {
                 Console.WriteLine("Original price of (" + name + ")  is " +  oldPrice + " new Updated  price  is ==> " + UpdateInventory(name, amount, DataBase));
            }
            else
            {
                Console.WriteLine("It is Not found or has  been sold");
            }
            
        }
    }
}