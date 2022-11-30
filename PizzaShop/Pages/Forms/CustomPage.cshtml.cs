using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    public class CustomPageModel : PageModel
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

            if (Pizza.TomatoSauce) PizzaPrice++;
            if (Pizza.Cheese) PizzaPrice++;
            if (Pizza.Peperoni) PizzaPrice++;
            if (Pizza.Mushroom) PizzaPrice++;
            if (Pizza.Tuna) PizzaPrice++;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice++;
            if (Pizza.Beef) PizzaPrice++;

            return RedirectToPage("/CheckOut/CheckOut", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
