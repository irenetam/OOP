namespace PizzaStore.Pizzas;

public class PepperonPizza: Pizza
{
    public PepperonPizza()
    {
        Name = "The best cheese pepperon";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Tomato);
    }
}
