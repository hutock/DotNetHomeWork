using System;
using System.Collections.Generic;

namespace OrderWeb.OrderModel
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public Order order { get; set; }
        public int itemNum { get; set; }

        public string itemName { get; set; }

        public int itemPrice { get; set; }

        public string itemStore { get; set; }

        public override string ToString()
        {
            return this.itemStore + "\t" + this.itemName + "\t" + this.itemPrice
                                  + "\t" + this.itemPrice + "￥\n";
        }

        public OrderDetail()
        {
        }

        public OrderDetail(string detail)
        {
            string[] d = new string[4];
            d = detail.Split(' ');
            this.itemStore = d[0];
            this.itemName = d[1];
            try
            {
                this.itemNum = int.Parse(d[2]);
                this.itemPrice = int.Parse(d[3]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("格式错误！！！" + e.Message);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   this.itemName == detail.itemName &&
                   itemNum == detail.itemNum &&
                   this.itemPrice == detail.itemPrice &&
                   this.itemStore == detail.itemStore;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderDetailID, OrderID, order, itemNum, itemName, itemPrice, itemStore);
        }
    }

}