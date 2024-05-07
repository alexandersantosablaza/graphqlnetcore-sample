namespace PizzaOrder.Data.Enum;

[Flags]
internal enum Toppings
{
    NONE            =   0
    , Pepperoni     =   1
    , Mushroom      =   2
    , Onions        =   4
    , Sausage       =   8
    , Bacon         =   16
    , ExtraCheese   =   32
    , BlackOlives   =   64
}
