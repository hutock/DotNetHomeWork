using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace OrderForm
{
    public class OrderService
    {
        public bool addOrder(Order newOrder)
        {            
            using(var db = new OrderContext())
            {
                var query = db.Orders.Where(order => order.OrderNum == newOrder.OrderNum);
                if(query.Any())
                {
                    return false;
                }
                else
                {
                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public void changeOrder(int orderNum, Order newOrder)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.FirstOrDefault(or => or.OrderNum == orderNum);
                if (order != null)
                {
                    db.Orders.Remove(order);
                }

                db.Orders.Add(newOrder);
                db.SaveChanges();
            }
        }

        public List<Order> checkAllOrders()
        {
            using(var db = new OrderContext())
            {
                var orderList = db.Orders.Include("OrderDetails")
                                .OrderBy(o => o.OrderNum);

                return orderList.ToList();
            }

        }

        public List<Order> checkByOrderNum(int orderNum)
        {
            using (var db = new OrderContext())
            {
                var orderList = db.Orders.Include("OrderDetails")
                                .Where(o=>o.OrderNum == orderNum)
                                .OrderBy(o => o.OrderNum);

                return orderList.ToList();
            }
        }

        public List<Order> checkByItemName(string ItemName)
        {
            using (var db = new OrderContext())
            {
                var orderListAll = db.Orders.Include("OrderDetails");
                    //Include("orderDetails");
                var orderList = from i in orderListAll
                                where (from s in i.orderDetails
                                       where s.itemName == ItemName
                                       select s).Any()
                                orderby i.priceSum
                                select i;
                return orderList.ToList();
            }
        }

        public List<Order> checkByCustomerName(string c_Name)
        {
            using (var db = new OrderContext())
            {
                var orderList = db.Orders.Include("OrderDetails")
                                .Where(o => o.customerName == c_Name)
                                .OrderBy(o => o.OrderNum);

                return orderList.ToList();
            }
        }

        public List<Order> checkBySum(int sum)
        {
            using (var db = new OrderContext())
            {
                int a = sum;
                var orderList = db.Orders.Include("OrderDetails")
                                .Where(o => o.priceSum == a)
                                .OrderBy(o => o.OrderNum);

                return orderList.ToList();
            }
        }

        public bool deleteOrder(int orderNum)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("OrderDetails").FirstOrDefault(or => or.OrderNum == orderNum);
                if (query != null)
                {
                    db.Orders.Remove(query);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Export(string filepath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

                using (FileStream fs = new FileStream(filepath, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this.checkAllOrders());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public List<Order> Import(string filepath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
               

                using (FileStream fs = new FileStream(filepath, FileMode.Open))
                {
                    List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fs);
                    foreach (var item in temp)
                    {
                        this.addOrder(item);
                    }
                    return temp;
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("没找到文件！");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
