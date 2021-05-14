using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderForm
{
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    [Serializable]
    public class Order
    {
        public int OrderID { get; set; }

        public int OrderNum { get; set; }

        public List<OrderDetail> orderDetails { get; set; } = new List<OrderDetail>();

        public int sum;

        public int priceSum
        {
            get
            {
                int _sum = 0;
                foreach (OrderDetail i in this.orderDetails)
                {
                    _sum += i.itemPrice * i.itemNum;
                }
                this.sum = _sum;
                return this.sum;
            }
            set { this.sum = value; }
        }

        public string customerName { get; set; }

        public Order() { }

        public Order(string customer, List<OrderDetail> newDetails, int orderNum)
        {
            this.OrderNum = orderNum;
            this.customerName = customer;
            this.orderDetails = newDetails;
        }

        public List<OrderDetail> showDetail()
        {
            var detail = from i in this.orderDetails
                         select i;
            return detail.ToList();
        }

        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetail item in this.orderDetails)
            {
                details.Append(item.ToString());
            }
            return "NO." + this.OrderNum + "\t" + "客户:" + this.customerName + "\t"
                    + "总金额:" + this.priceSum + "￥\n" +
                    "商家\t商品名\t商品数量\t商品单价(/￥)\n" + details.ToString();
        }

        public override bool Equals(object obj)
        {

            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            if (this == obj)
            {
                return true;
            }
            var order1 = obj as Order;
            if (this.priceSum == order1.priceSum &&
               this.orderDetails.Except(order1.orderDetails).Count() == 0 &&
               order1.orderDetails.Except(this.orderDetails).Count() == 0 &&
               this.customerName.Equals(order1.customerName)
               )
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -814085947;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(orderDetails);
            hashCode = hashCode * -1521134295 + priceSum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(customerName);
            return hashCode;
        }
    }

}