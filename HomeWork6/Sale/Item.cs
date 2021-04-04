using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    public class Item
    {
        public string name { get; set; }
        public int price { get; set; }
        public string store { get; set; }

        public Item() { }

        public override string ToString()
        {
            return this.store + "\t" + this.name + "\t" + this.price;
        }
    }
}
