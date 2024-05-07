using PizzaOrder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Business.Services;
public class PizzaDeteailService: IPizzaDeteailService
{
    private PizzaDBContext _context;
    public PizzaDeteailService()
    {
        
    }
    public PizzaDeteailService(PizzaDBContext context)
    {
        _context = context;
        
    }

}
