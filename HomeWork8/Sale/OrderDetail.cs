using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    public class OrderDetail
    {
        public int itemNum { get; set; }
        
        public Item item = new Item();

        
        public string name { get { return this.item.Name; } set { this.item.Name = value; } }
        
        public int price { get { return this.item.Price; } set { this.item.Price = value;  } }

        public string store { get { return this.item.Store; } set { this.item.Store = value;  } }

        public override string ToString()
        {
            return this.item.ToString() + "\t" + this.item.Price + "￥\n";
        }

        public OrderDetail()
        { 
        }

        public OrderDetail(string detail)
        {
            string[] d = new string[4];
            d = detail.Split(' ');
            this.item.Store = d[0];
            this.item.Name = d[1];
            try
            {
                this.itemNum = int.Parse(d[2]);
                this.item.Price = int.Parse(d[3]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("格式错误！！！" + e.Message);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   item.Name == detail.item.Name &&
                   itemNum == detail.itemNum &&
                   item.Price == detail.item.Price &&
                   item.Store == detail.item.Store;
        }

        public override int GetHashCode()
        {
            int hashCode = -576236847;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(item.Name);
            hashCode = hashCode * -1521134295 + itemNum.GetHashCode();
            hashCode = hashCode * -1521134295 + item.Price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(item.Store);
            return hashCode;
        }
    }
}
