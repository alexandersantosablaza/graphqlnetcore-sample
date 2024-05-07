using PizzaOrder.Data;
namespace PizzaOrder.Business.Services;

public class OrderDetailsService : IOrderDetailService
{
    private readonly PizzaDBContext _context;
    public OrderDetailsService()
    {
        
    }
    public OrderDetailsService(PizzaDBContext context)
    {
        _context = context;
    }
}
