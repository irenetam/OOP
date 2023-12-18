using PizzaStore.Enums;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.Base;

namespace PizzaStore.Store
{
    internal class HCMPizzaStore : Base.PizzaStore
    {
        protected override Pizza CreatePizza(TypeOfPizza type)
        {
            switch (type)
            {
                case TypeOfPizza.CheesePizza:
                    return new HCMCheesePizza();
                case TypeOfPizza.GreekPizza:
                    return new HCMGreekPizza();
                case TypeOfPizza.PepperonPizza:
                    return new HCMPepperonPizza();
                default:
                    return null;
            }
        }
    }
}
