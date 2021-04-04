using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService a = new OrderService();

            if (new FileInfo("orders.xml").Exists)
                a.Import();

            bool goOut = false;
            while (true)
            {
                if (goOut)
                    break;

                Console.WriteLine("订单管理");
                Console.WriteLine("请选择功能(输入对应前置字母)：");
                Console.WriteLine("a.添加订单\tb.修改订单");
                Console.WriteLine("c.查询订单\td.删除订单\nq.退出程序");

                int _input = Console.ReadLine()[0];

                switch (_input)
                {
                    case 'a':
                        add(a);
                        Console.Clear();
                        break;
                    case 'b':
                        change(a);
                        Console.Clear();
                        break;
                    case 'c':
                        check(a);
                        Console.Clear();
                        break;
                    case 'd':
                        delete(a);
                        Console.Clear();
                        break;
                    case 'q':
                        goOut = true;
                        a.Export();
                        Console.WriteLine("感谢使用");
                        break;
                    default:
                        Console.WriteLine("请输入正确的字母");
                        Console.WriteLine("按下任意键返回菜单...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            }

        }

        static void add(OrderService o_Service)
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

                bool flag = o_Service.addOrder(newOrder);

                if (!flag)
                {
                    Console.WriteLine("添加订单失败！错误：此订单已存在");
                }
                else
                {
                    Console.WriteLine("订单添加成功！");
                    Console.WriteLine("订单号为：" + newOrder.orderNum);
                }
                Console.WriteLine("按下任意键返回菜单...");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void change(OrderService o_Service)
        {
            Console.Clear();
            Console.WriteLine("请输入要修改的订单的订单号：");
            string o_num = Console.ReadLine();
            int _num = int.Parse(o_num);

            if (o_Service.orders.Exists(o => o.orderNum == _num))
            {
                Console.WriteLine("请输入修改后的订单明细（格式：店家 商品名 数量 价格，一行一条，输入q结束）:");

                string _name = o_Service.orders.Find(o => o.orderNum == _num).customer.name;

                string detail;
                List<OrderDetail> orderdetails = new List<OrderDetail>();
                while ((detail = Console.ReadLine()) != "q")
                {
                    OrderDetail orderDetail = new OrderDetail(detail);
                    orderdetails.Add(orderDetail);
                }

                //生成修改后订单
                Order newOrder = new Order(_name, orderdetails);

                o_Service.changeOrder(_num, newOrder);

                Console.WriteLine("修改成功！\n按下任意键返回菜单...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("未找到订单，请重新核查输入的订单号\n按下任意键返回菜单...");
                Console.ReadKey();
            }
        }

        static void check(OrderService o_Service)
        {
            Console.Clear();
            Console.WriteLine("请选择查询方式：");
            Console.WriteLine("1.订单号\t2.商品名称");
            Console.WriteLine("3.客户\t4.订单金额");

            int _input = Console.ReadLine()[0];
            switch (_input)
            {
                case '1':
                    Console.WriteLine("请输入要查询的订单号：");
                    string in_num = Console.ReadLine();
                    int num = int.Parse(in_num);
                    List<Order> newList1 = o_Service.checkByOrderNum(num);

                    if (newList1.Any())
                    {
                        Console.WriteLine("查询到的订单如下：");
                        foreach (Order item in newList1)
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
                    break;
                case '2':
                    Console.WriteLine("请输入要查询的商品名：");
                    string Iname = Console.ReadLine();
                    List<Order> newList2 = o_Service.checkByItemName(Iname);

                    if (newList2.Any())
                    {
                        Console.WriteLine("查询到的订单如下：");
                        foreach (Order item in newList2)
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
                    break;
                case '3':
                    Console.WriteLine("请输入要查询的客户名：");
                    string Cname = Console.ReadLine();

                    List<Order> newList3 = o_Service.checkByCustomerName(Cname);

                    if (newList3.Any())
                    {
                        Console.WriteLine("查询到的订单如下：");
                        foreach (Order item in newList3)
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
                    break;
                case '4':
                    Console.WriteLine("请输入要查询的订单金额：");
                    string in_sum = Console.ReadLine();
                    int sum = int.Parse(in_sum);

                    List<Order> newList4 = o_Service.checkBySum(sum);

                    if (newList4.Any())
                    {
                        Console.WriteLine("查询到的订单如下：");
                        foreach (Order item in newList4)
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
                    break;
                default:
                    Console.WriteLine("输入无效");
                    Console.WriteLine("按下任意键返回菜单...");
                    Console.ReadKey();
                    break;
            }
        }

        static void delete(OrderService o_Service)
        {
            Console.Clear();


            Console.WriteLine("请输入您要删除的订单的订单号：");
            string o_num = Console.ReadLine();
            int _num = int.Parse(o_num);

            if (o_Service.deleteOrder(_num))
            {

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





