﻿namespace PizzaStore.Pizzas
{
    public class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            Name = "The best cheese pizza";
            Sauce = Enums.Sauce.Chili;
            Dough = Enums.Dough.Thin;
            Toppings.Add(Enums.Topping.BlackOlives);
            Toppings.Add(Enums.Topping.Cheese);
        }

        public override void Box()
        {
            base.Box();
            Console.WriteLine(Dough);
        }
    }
}
