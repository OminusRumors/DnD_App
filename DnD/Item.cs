using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    [Serializable]
    public class Item
    {
        private string itemName;
        private string itemEffect;

        public Item()
        {

        }
        
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemEffect
        {
            get { return itemEffect; }
            set { itemEffect = value; }
        }
    }
}
