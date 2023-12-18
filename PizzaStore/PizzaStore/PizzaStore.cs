using PizzaStore.Enums;
using PizzaStore.Pizzas;

namespace PizzaStore;

public class PizzaStore
{
    public void OrderPizza(TypeOfPizza type)
    {
        Pizza pizza;
        switch (type)
        {
            case TypeOfPizza.CheesePizza:
                pizza = new CheesePizza();
                break;
            case TypeOfPizza.GreekPizza:
                pizza = new GreekPizza();
                break;
            case TypeOfPizza.PepperonPizza:
                pizza = new PepperonPizza();
                break;
            default:
                return;
        }

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}
