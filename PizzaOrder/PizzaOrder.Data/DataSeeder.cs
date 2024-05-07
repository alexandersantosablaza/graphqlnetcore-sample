using PizzaOrder.Data.Entities;
using PizzaOrder.Data.Enum;
namespace PizzaOrder.Data;
public static class DataSeeder
{
    public static void Seed(this PizzaDBContext context)
    {
        if(!context.OrderDetails.Any())
        {
            context.OrderDetails.AddRange(
                 entities: new List<OrderDetails> {
                    new  ("123 Trash Can", "Bin Avenueze", "1234567890",120m),
                    new  ("553 Mount Poo", "File City", "5551114444",500m),
                    new  ("395 Shh Road", "Droguen", "9391912345",9000m),
                });
            context.SaveChanges();
        }
        if(!context.PizzaDetails.Any())
        {
            context.PizzaDetails.AddRange(
                 entities: new List<PizzaDetails> {
                    new ("Nigg Pizza", 100m, 11,1, Toppings.ExtraCheese | Toppings.Onions),
                    new ("Jumborat Pizza", 500m, 9, 2, Toppings.Mushroom | Toppings.Sausage | Toppings.ExtraCheese),
                    new ("Magic Pizza", 237m, 6, 3, Toppings.Pepperoni),
                    new ("New york Pizza", 5050m, 14, 2, Toppings.BlackOlives | Toppings.Onions),
                    new ("Peperro Sword Pizza", 392m, 11, 1, Toppings.Mushroom | Toppings.Onions),
                }
                );
            context.SaveChanges();  
        }
    }
}
