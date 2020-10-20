using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace inventoryItemApplication
{
    internal class NodeClass
    {
        public string name;
        public string price;
        public string discription;
        public string condition;
        public string modal;
        public bool soled;
        public NodeClass NextNode;

        public  NodeClass(string name, string price ,  string  condition, string  modal , string discription,bool soled)
        {
            this.name = name;
            this.price = price;
            this.condition = condition;
            this.modal = modal;
            this.discription = discription;
            this.soled = false;
            this.NextNode = null;
          
        }
        public string  GetPrice()
        {
            return  price;
        }

        public string GetDiscription()
        {
            return discription;
        }


        public string GetCondition()
        {
            return condition;
        }


        public void itemSold()
        {
            soled = true;
        }
    }
}