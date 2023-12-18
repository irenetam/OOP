using PizzaStore.Pizzas.Base;

namespace PizzaStore.Pizzas.DNPizza;

public class DNGreekPizza : Pizza
{
    public DNGreekPizza()
    {
        Name = "The best greek pizza";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Onions);
    }
}
