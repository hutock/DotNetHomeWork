using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    [Serializable]
    public class Order
    {
        public static int autoNum = 10001;  
        public int orderNum { get; set; }

        public List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int priceSum { get
            {
                int sum = 0;
                foreach(OrderDetail i in this.orderDetails)
                {
                    sum += i.item.price * i.itemNum;
                }
                return sum;
            } }

        public Customer customer = new Customer();

        public Order() { }

        public Order(string customer, List<OrderDetail> newDetails)
        {
            this.orderNum = Order.autoNum;
            Order.autoNum++;
            this.customer.name = customer;
            this.orderDetails = newDetails;
        }

        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetail item in this.orderDetails)
            {
                details.Append(item.ToString());
            }
            return "NO." + this.orderNum + "\t" + "客户:" + this.customer + "\t" 
                    + "总金额:" + this.priceSum + "￥\n" +
                    "商家\t商品名\t商品数量\t商品单价(/￥)\n" + details.ToString();
        }

        public override bool Equals(object obj)
        {
            
            if(obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            if(this == obj)
            {
                return true;
            }
            var order1 = obj as Order;
            if(this.priceSum == order1.priceSum &&
               this.orderDetails.Except(order1.orderDetails).Count() == 0 &&
               order1.orderDetails.Except(this.orderDetails).Count() == 0 &&
               this.customer.Equals(order1.customer)
               )
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 2130280754;
            hashCode = hashCode * -1521134295 + orderNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(orderDetails);
            hashCode = hashCode * -1521134295 + priceSum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            return hashCode;
        }
    }
}
