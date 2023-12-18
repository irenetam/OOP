using PizzaStore.Enums;

namespace PizzaStore.Pizzas.Base
{
    public abstract class Pizza
    {
        protected string? Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected List<Topping> Toppings = new List<Topping>();

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

        public virtual void Box()
        {
            Console.WriteLine("Box " + Name);
        }
    }
}
