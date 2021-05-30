using Microsoft.EntityFrameworkCore;

namespace OrderWeb.OrderModel
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            //this.Database.EnsureCreated();
        }

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}