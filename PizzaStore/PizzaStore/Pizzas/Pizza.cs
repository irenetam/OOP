using PizzaStore.Enums;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        protected string? Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected List<Topping> Toppings { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");

            Toppings?.ForEach(p => Console.WriteLine("\t" + p));
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + Name + " in 30 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Box " + Name);
        }
    }
}
