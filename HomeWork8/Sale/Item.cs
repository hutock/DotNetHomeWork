using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    public class Item
    {
        
        public string Name { get; set; }
        public int Price { get; set; }
        public string Store { get; set; }

        public Item() { }

        public override string ToString()
        {
            return this.Store + "\t" + this.Name + "\t" + this.Price;
        }
    }
}
