using PizzaStore.Pizzas.Base;

namespace PizzaStore.Pizzas;

public class HCMPepperonPizza: Pizza
{
    public HCMPepperonPizza()
    {
        Name = "The best pepperon pizza";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Tomato);
    }
}
