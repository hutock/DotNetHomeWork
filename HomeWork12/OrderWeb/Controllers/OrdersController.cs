using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderWeb.OrderModel;

namespace OrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext oc;

        public OrdersController(OrderContext orderContext)
        {
            this.oc = orderContext;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult<List<Order>> Getorders()
        {
            IQueryable<Order> query = oc.orders.Include(o => o.orderDetails);

            return query.ToList();
        }

        // GET: api/Orders/5
        [HttpGet("{ordernum}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var orders = oc.orders.Include(o => o.orderDetails).ToList();


            if (orders == null)
            {
                return NotFound();
            }

            return orders.Find(o => o.OrderNum == id);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{ordernum}")]
        public ActionResult<Order> PutOrder(int ordernum, Order order)
        {
            Console.WriteLine($"{ordernum},,{order.OrderNum}");
            if (ordernum != order.OrderNum)
            {
                return BadRequest("Id cannot be modified!");
            }

            try
            {
                oc.Entry(order).State = EntityState.Modified;
                oc.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException!=null)
                {
                    error = e.InnerException.Message;
                }
                return BadRequest(error);
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                oc.orders.Add(order);
                oc.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // DELETE: api/Orders/5
        [HttpDelete("{ordernum}")]
        public ActionResult DeleteOrder(int ordernum)
        {
            try
            {
                var order = oc.orders.FirstOrDefault(o => o.OrderNum == ordernum);
                if(order!=null)
                {
                    oc.Remove(order);
                    oc.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return (oc.orders.ToList().Find(o => o.OrderNum == id) != null);
        }
    }
}
