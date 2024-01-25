using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.Pages
{
    public class ProstyModel : PageModel
    {

        [BindProperty]
        public CalculatorModel Calculator { get; set; } = new CalculatorModel();

        public void OnGet()
        {
            Calculator.oper = ""; 
        }

        public IActionResult OnPost()
        {
            Calculator.Dzialanie();
            return Page();
        }
    }
}
