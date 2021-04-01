using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    class OrderService
    {
        List<Order> orders = new List<Order>();

        public void service()
        {
            bool goOut = false;
            while(true)
            {
                if (goOut)
                    break;
                
                this.mainScreen();
                int _input = Console.ReadLine()[0];
                
                switch (_input)
                { 
                    case 'a':this.addOrder();
                        Console.Clear();
                        break;
                    case 'b':this.changeOrder();
                        Console.Clear();
                        break;
                    case 'c':this.checkOrder();
                        Console.Clear();
                        break;
                    case 'd':this.deleteOrder();
                        Console.Clear();
                        break;
                    case 'q':goOut = true;
                        Console.WriteLine("感谢使用");
                        break;
                    default:Console.WriteLine("请输入正确的字母");
                        Console.WriteLine("按下任意键返回菜单...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                
            }
        }

        private void sortList()
        {
            orders.Sort((p1, p2) => p1.orderNum - p2.orderNum);
        }

        private void mainScreen()
        {
            Console.WriteLine("订单管理");
            Console.WriteLine("请选择功能(输入对应前置字母)：");
            Console.WriteLine("a.添加订单\tb.修改订单");
            Console.WriteLine("c.查询订单\td.删除订单\nq.退出程序");
        }

        private void addOrder()
        {
            try
            {
                Console.Clear();
                List<OrderDetail> orderdetails = new List<OrderDetail>();

                Console.WriteLine("请在下一行输入您的名字：");

                string _name;

                _name = Console.ReadLine();

                Console.WriteLine("请输入订单明细（格式：店家 商品名 数量 价格，一行一条，输入q结束）:");
                string detail;
                while ((detail = Console.ReadLine()) != "q")
                {
                    OrderDetail orderDetail = new OrderDetail(detail);
                    orderdetails.Add(orderDetail);
                }

                Order newOrder = new Order(_name, orderdetails);

                var checkOrder = from i in orders
                                 where newOrder.Equals(i)
                                 select i;

                if (checkOrder.Any())
                {
                    Console.WriteLine("添加订单失败！错误：此订单已存在");
                }
                else
                {
                    Console.WriteLine("订单添加成功！");
                    Console.WriteLine("订单号为："+newOrder.orderNum);
                    orders.Add(newOrder);
                    this.sortList();
                }
                Console.WriteLine("按下任意键返回菜单...");
                Console.ReadKey();
                Console.Clear();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void changeOrder()
        {
            Console.Clear();
            Console.WriteLine("请输入要修改的订单的订单号：");
            string o_num = Console.ReadLine();
            int _num = int.Parse(o_num);

            Order newOrder = null;//全局变量存储处理结果
            
            bool find = true, change = false;//find：有没有找到订单     change：是否修改成功
            foreach (Order item in this.orders)
            {
                //找到才处理
                if(item.orderNum == _num)
                {
                    find = false;
                    Console.WriteLine("请输入修改后的订单明细（格式：店家 商品名 数量 价格，一行一条，输入q结束）:");
                    string detail;
                    List<OrderDetail> orderdetails = new List<OrderDetail>();
                    while ((detail = Console.ReadLine()) != "q")
                    {
                        OrderDetail orderDetail = new OrderDetail(detail);
                        orderdetails.Add(orderDetail);
                    }

                    //生成修改后订单
                    newOrder = new Order(item.customer.name, orderdetails);

                    //判断是否存在重复订单
                    var checkOrder = from i in orders
                                     where newOrder.Equals(i)
                                     select i;
                    
                    if (checkOrder.Any())
                    {
                        Console.WriteLine("修改订单失败！错误：订单明细存在重复");
                    }
                    else
                    {
                        newOrder.orderNum = item.orderNum;
                        this.orders.Remove(item);
                        change = true;
                    }
                    break;

                }
            }

            if(find)
            {
                Console.WriteLine("未找到订单，请重新核查输入的订单号\n按下任意键返回菜单...");
                Console.ReadKey();
            }
            else
            {
                if(change)
                {
                    this.orders.Add(newOrder);
                    this.sortList();
                    Console.WriteLine("修改成功！\n按下任意键返回菜单...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("按下任意键返回菜单...");
                    Console.ReadKey();
                }
            }
        }

        private void checkOrder()
        {
            Console.Clear();
            Console.WriteLine("请选择查询方式：");
            Console.WriteLine("1.订单号\t2.商品名称");
            Console.WriteLine("3.客户\t4.订单金额");

            int _input = Console.ReadLine()[0];
            switch (_input)
            {
                case '1':useOrderNum();
                    break;
                case '2':useItemName();
                    break;
                case '3':useCustomerName();
                    break;
                case '4':useMoney();
                    break;
                default: Console.WriteLine("输入无效");
                    Console.WriteLine("按下任意键返回菜单...");
                    Console.ReadKey();
                    break;
            }
        }

        private void useOrderNum()
        {
            try
            {
                Console.WriteLine("请输入要查询的订单号：");
                string in_num = Console.ReadLine();
                int num = int.Parse(in_num);

                var orderList = from i in this.orders
                                where i.orderNum == num
                                orderby i.priceSum
                                select i;
                
                if (orderList.Any())
                {
                    Console.WriteLine("查询到的订单如下：");
                    foreach (Order item in orderList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("无匹配项");
                }
                Console.WriteLine("按下任意键返回菜单...");
                Console.ReadKey();

            }
            catch(FormatException e)
            {
                Console.WriteLine("输入的订单号不合法！" + e.Message);
            }
            
        }

        private void useItemName()
        {
            Console.WriteLine("请输入要查询的商品名：");
            string name = Console.ReadLine();
            var orderList = from i in this.orders
                            where (from s in i.orderDetails
                                   where s.item.name == name
                                   select s).Any()
                            orderby i.priceSum
                            select i;

            if (orderList.Any())
            {
                Console.WriteLine("查询到的订单如下：");
                foreach (Order item in orderList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("无匹配项");
            }
            Console.WriteLine("按下任意键返回菜单...");
            Console.ReadKey();
        }

        private void useCustomerName()
        {
            Console.WriteLine("请输入要查询的客户名：");
            string name = Console.ReadLine();

            var orderList = from i in this.orders
                            where i.customer.name == name
                            orderby i.priceSum
                            select i;

            if (orderList.Any())
            {
                Console.WriteLine("查询到的订单如下：");
                foreach (Order item in orderList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("无匹配项");
            }
            Console.WriteLine("按下任意键返回菜单...");
            Console.ReadKey();
        }

        private void useMoney()
        {
            try
            {
                Console.WriteLine("请输入要查询的订单金额：");
                string in_sum = Console.ReadLine();
                int sum = int.Parse(in_sum);

                var orderList = from i in this.orders
                                where i.priceSum == sum
                                orderby i.priceSum
                                select i;

                if (orderList.Any())
                {
                    Console.WriteLine("查询到的订单如下：");
                    foreach (Order item in orderList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("无匹配项");
                }
                Console.WriteLine("按下任意键返回菜单...");
                Console.ReadKey();

            }
            catch (FormatException e)
            {
                Console.WriteLine("输入的金额数字不合法！" + e.Message);
            }
        }

        private void deleteOrder()
        {
            Console.Clear();
            bool flag = false;
            Console.WriteLine("请输入您要删除的订单的订单号：");
            string o_num = Console.ReadLine();
            int _num = int.Parse(o_num);
            foreach (Order item in this.orders)
            {
                if (item.orderNum == _num)
                {
                    orders.Remove(item);
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.sortList();
                Console.WriteLine("删除成功\n按下任意键返回菜单...");
            }
            else
            {
                Console.WriteLine("无此订单，删除失败\n按下任意键返回菜单...");
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
