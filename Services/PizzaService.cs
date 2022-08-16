using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;

public static class PizzaService{
    static List<Pizza> Pizzas {get;}

    static PizzaService(){
        Pizzas = {
            new Pizza { Id = 1, Name = "Classic Italian", Price=20.00M, Size=PizzaSize.    Large, IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", Price=15.00M, Size=PizzaSize.Small,     IsGlutenFree = true }
        }
    }
}