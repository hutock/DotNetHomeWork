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

        public override string ToString()
        {
            return this.item.ToString() + "\t" + this.item.price + "￥\n";
        }

        public OrderDetail() { }

        public OrderDetail(string detail)
        {
            string[] d = new string[4];
            d = detail.Split(' ');
            this.item.store = d[0];
            this.item.name = d[1];
            try
            {
                this.itemNum = int.Parse(d[2]);
                this.item.price = int.Parse(d[3]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("格式错误！！！" + e.Message);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   item.name == detail.item.name &&
                   itemNum == detail.itemNum &&
                   item.price == detail.item.price &&
                   item.store == detail.item.store;
        }

        public override int GetHashCode()
        {
            int hashCode = -576236847;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(item.name);
            hashCode = hashCode * -1521134295 + itemNum.GetHashCode();
            hashCode = hashCode * -1521134295 + item.price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(item.store);
            return hashCode;
        }
    }
}
