namespace PizzaStore;

public class PizzaStore
{
    public void OrderPizza()
    {
        var pizza = new Pizza();
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}
