using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sale;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addOrderTest()
        {
            OrderService a = new OrderService();
            OrderService b = new OrderService();

            List<OrderDetail> a1 = new List<OrderDetail>();
            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));

            List<OrderDetail> a2 = new List<OrderDetail>();
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));

            Order _a = new Order("lxz", a1);
            Order _b = new Order("lxz", a2);

            a.orders.Add(_a);
            a.orders.Add(_b);

            b.orders.Add(_a);
            bool flag = b.addOrder(_b);

            CollectionAssert.AreEqual(a.orders, b.orders);//比较集合是否相同
            Assert.IsTrue(flag);//比较函数返回值是否正确
            Assert.IsFalse(b.addOrder(_b));//出现重复订单是否正确返回false
        }

        [TestMethod]
        public void changeOrderTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));
            a3.Add(new OrderDetail("e e 5 5"));
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);

            a.changeOrder(_a1.orderNum, _a3);

            Assert.IsTrue(a.orders.Exists(o => o.orderNum == _a3.orderNum));//新订单取代并放入订单集合
            Assert.IsFalse(a.orders.Exists(o => o.orderNum == _a1.orderNum));//删除原订单
        }

        [TestMethod]
        public void checkByOrderNumTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));
            a3.Add(new OrderDetail("e e 5 5"));
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);
            a.orders.Add(_a3);

            List<Order> _a = a.checkByOrderNum(_a1.orderNum);

            Assert.IsFalse(a.checkByOrderNum(114514).Exists(o => o != null));//无此订单号返回的集合中为null订单
            CollectionAssert.Contains(_a, _a1);//返回集合是否包含_a1
        }

        [TestMethod]
        public void checkByItemNameTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));//查询b商品
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));
            a3.Add(new OrderDetail("b b 5 5"));//查询b商品
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);
            a.orders.Add(_a3);

            List<Order> _a = a.checkByItemName("b");

            Assert.IsFalse(a.checkByItemName("asuna").Exists(o => o != null));//无此商品返回的集合只有null订单
            CollectionAssert.Contains(_a, _a1);//a1包含b商品
            CollectionAssert.Contains(_a, _a3);//a3包含b商品
        }

        [TestMethod]
        public void checkByCustomerNameTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));
            a3.Add(new OrderDetail("e e 5 5"));
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);//查询客户lxz的订单
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);
            a.orders.Add(_a3);

            List<Order> _a = a.checkByCustomerName("lxz");

            Assert.IsFalse(a.checkByCustomerName("xianbei").Exists(o => o != null));//无此客户返回的集合只有null订单

            //lxz用户的订单只有a1
            CollectionAssert.Contains(_a, _a1);
            CollectionAssert.DoesNotContain(_a, _a2);
            CollectionAssert.DoesNotContain(_a, _a3);

        }

        [TestMethod]
        public void checkBySumTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));
            //a2总价25
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));

            a3.Add(new OrderDetail("e e 5 5"));
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);
            a.orders.Add(_a3);

            List<Order> _a = a.checkBySum(25);

            CollectionAssert.Contains(_a, _a2);//总价25的是_a2
        }

        [TestMethod]
        public void deleteOrderTest()
        {
            OrderService a = new OrderService();
            OrderService b = new OrderService();

            List<OrderDetail> a1 = new List<OrderDetail>();
            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));

            List<OrderDetail> a2 = new List<OrderDetail>();
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));

            Order _a = new Order("lxz", a1);
            Order _b = new Order("lxz", a2);

            a.orders.Add(_a);
            a.orders.Add(_b);
            b.orders.Add(_a);

            bool flag = a.deleteOrder(_b.orderNum);

            CollectionAssert.AreEqual(a.orders, b.orders);//a删除订单_b后订单集合与b的相同
            Assert.IsTrue(flag);//测试返回值是否为true
            Assert.IsFalse(a.deleteOrder(114514));//测试找不到订单是否返回false
        }

        [TestMethod]
        public void exportAndImportTest()
        {
            List<OrderDetail> a1 = new List<OrderDetail>();
            List<OrderDetail> a2 = new List<OrderDetail>();
            List<OrderDetail> a3 = new List<OrderDetail>();

            a1.Add(new OrderDetail("a a 1 1"));
            a1.Add(new OrderDetail("b b 2 2"));
            //a2总价25
            a2.Add(new OrderDetail("c c 3 3"));
            a2.Add(new OrderDetail("d d 4 4"));

            a3.Add(new OrderDetail("e e 5 5"));
            a3.Add(new OrderDetail("f f 6 6"));

            Order _a1 = new Order("lxz", a1);
            Order _a2 = new Order("xzl", a2);
            Order _a3 = new Order("zlx", a3);

            OrderService a = new OrderService();
            a.orders.Add(_a1);
            a.orders.Add(_a2);
            a.orders.Add(_a3);

            OrderService b = new OrderService();

            a.Export();

            b.Import();

            CollectionAssert.AreEqual(a.orders, b.orders);
        }

    }
}
