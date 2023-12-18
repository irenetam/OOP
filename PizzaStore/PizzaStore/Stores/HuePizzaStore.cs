using PizzaStore.Enums;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.HuePizza;

namespace PizzaStore.Store
{
    public class HuePizzaStore : Base.PizzaStore
    {
        protected override Pizza CreatePizza(TypeOfPizza type)
        {
            switch (type)
            {
                case TypeOfPizza.CheesePizza:
                    return new HueCheesePizza();
                case TypeOfPizza.GreekPizza:
                    return new HueGreekPizza();
                case TypeOfPizza.PepperonPizza:
                    return new HuePepperonPizza();
                default:
                    return null;
            }
        }
    }
}
