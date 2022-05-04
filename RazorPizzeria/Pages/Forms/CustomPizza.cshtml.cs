using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms;

public class CustomPizza : PageModel
{

    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }
    public void OnGet()
    {
    
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;

        if (Pizza.TomatoSauce) PizzaPrice += 1;
        if (Pizza.Cheese) PizzaPrice += 1;
        if (Pizza.Peperoni) PizzaPrice += 2;
        if (Pizza.Mushroom) PizzaPrice += 2;
        if (Pizza.Tuna) PizzaPrice += 2;
        if (Pizza.Pineapple) PizzaPrice += 3;
        if (Pizza.Ham) PizzaPrice += 2;
        if (Pizza.Beef) PizzaPrice += 3;

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});
    }
}
