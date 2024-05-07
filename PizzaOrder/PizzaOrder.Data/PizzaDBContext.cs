using Microsoft.EntityFrameworkCore;
using PizzaOrder.Data.Entities;

namespace PizzaOrder.Data;
public class PizzaDBContext : DbContext
{
    public PizzaDBContext()
    {

    }
    public PizzaDBContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<PizzaDetails> PizzaDetails { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
}
