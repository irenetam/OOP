using PizzaStore.Pizzas.Base;

namespace PizzaStore.Pizzas.HuePizza;

public class HuePepperonPizza : Pizza
{
    public HuePepperonPizza()
    {
        Name = "The best pepperon pizza";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Tomato);
    }
}
