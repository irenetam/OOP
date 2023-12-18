using PizzaStore.Pizzas.Base;

namespace PizzaStore.Pizzas.HuePizza
{
    public class HueCheesePizza : Pizza
    {
        public HueCheesePizza()
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
