namespace PizzaStore.Pizzas;

public class PepperonPizza: Pizza
{
    public PepperonPizza()
    {
        Name = "The best pepperon pizza";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Tomato);
    }
}
