namespace PizzaStore.Pizzas;

public class GreekPizza: Pizza
{
    public GreekPizza()
    {
        Name = "The best greek pizza";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Onions);
    }
}
