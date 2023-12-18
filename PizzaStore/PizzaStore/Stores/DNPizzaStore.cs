using PizzaStore.Enums;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.DNPizza;

namespace PizzaStore.Store
{
    public class DNPizzaStore : Base.PizzaStore
    {
        protected override Pizza CreatePizza(TypeOfPizza type)
        {
            switch (type)
            {
                case TypeOfPizza.CheesePizza:
                    return new DNCheesePizza();
                case TypeOfPizza.GreekPizza:
                    return new DNGreekPizza();
                case TypeOfPizza.PepperonPizza:
                    return new DNPepperonPizza();
                default:
                    return null;
            }
        }
    }
}
