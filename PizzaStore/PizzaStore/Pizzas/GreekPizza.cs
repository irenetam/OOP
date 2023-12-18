namespace PizzaStore.Pizzas;

public class GreekPizza: Pizza
{
    public GreekPizza()
    {
        Name = "The best cheese greek";
        Sauce = Enums.Sauce.Pepper;
        Dough = Enums.Dough.Thick;
        Toppings.Add(Enums.Topping.BlackOlives);
        Toppings.Add(Enums.Topping.Onions);
    }
}
