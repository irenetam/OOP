// See https://aka.ms/new-console-template for more information

using PizzaStore.Store;

Console.WriteLine("Hello, World!");

var hcmPizza = new HCMPizzaStore();
hcmPizza.OrderPizza(PizzaStore.Enums.TypeOfPizza.CheesePizza);
var huePizza = new HuePizzaStore();
huePizza.OrderPizza(PizzaStore.Enums.TypeOfPizza.CheesePizza);
var dnPizza = new DNPizzaStore();
dnPizza.OrderPizza(PizzaStore.Enums.TypeOfPizza.CheesePizza);

