using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Sale
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        private void sortList()
        {
            orders.Sort((p1, p2) => p1.orderNum - p2.orderNum);
        }

        public bool addOrder(Order newOrder)
        {
            var checkOrder = from i in orders
                             where newOrder.Equals(i)
                             select i;

            if(checkOrder.Any())
            {
                return false;
            }
            else
            {
                orders.Add(newOrder);
                this.sortList();
                return true;
            }
        }

        public void changeOrder(int orderNum, Order newOrder)
        {
            this.orders.RemoveAll(obj => obj.orderNum == orderNum);
            
            orders.Add(newOrder);

            this.sortList();
        }

        public List<Order> checkByOrderNum(int orderNum)
        {
            var orderList = from i in this.orders
                            where i.orderNum == orderNum
                            orderby i.priceSum
                            select i;

            return orderList.ToList();

        }

        public List<Order> checkByItemName(string itemName)
        {
            var orderList = from i in this.orders
                            where (from s in i.orderDetails
                                   where s.item.name == itemName
                                   select s).Any()
                            orderby i.priceSum
                            select i;
            return orderList.ToList();
        }

        public List<Order> checkByCustomerName(string c_Name)
        {
            var orderList = from i in this.orders
                            where i.customer.name == c_Name
                            orderby i.priceSum
                            select i;
            return orderList.ToList();
        }

        public List<Order> checkBySum(int sum)
        {
            var orderList = from i in this.orders
                            where i.priceSum == sum
                            orderby i.priceSum
                            select i;

            return orderList.ToList();
        }

        public bool deleteOrder(int orderNum)
        {
            var checkOrder = from i in orders
                             where i.orderNum == orderNum
                             select i;
            if(checkOrder.Any())
            {
                this.orders.RemoveAll(obj => obj.orderNum == orderNum);
                this.sortList();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Export()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));

                Order[] temp = this.orders.ToArray();

                using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, temp);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Import()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
                Order[] temp;
                
                using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
                {
                    temp = (Order[])xmlSerializer.Deserialize(fs);
                }
                this.orders = temp.ToList();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("没找到文件！");
                Console.WriteLine(e.Message);
            }
        }
    }
}
