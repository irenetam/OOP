using PizzaStore.Enums;
using PizzaStore.Pizzas.Base;

namespace PizzaStore.Store.Base;

public abstract class PizzaStore
{
    public void OrderPizza(TypeOfPizza type)
    {
        Pizza pizza;
        pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }

    protected abstract Pizza CreatePizza(TypeOfPizza type);
}
