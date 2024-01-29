using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Blogownia.Data;
using Blogownia.Models;

namespace Blogownia.Pages
{
    public class LogowanieModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LogowanieModel(ApplicationDbContext context)
        {
            _context = context;
            LoginData = new LoginViewModel(); 
        }

        [BindProperty]
        public LoginViewModel LoginData { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = _context.Users
                .FirstOrDefault(u => u.Email == LoginData.Email && u.PasswordHashed == LoginData.PasswordHashed);

            if (user == null)
            {
                ModelState.AddModelError("", "Niepoprawny email lub hasło");
                return Page();
            }


            return RedirectToPage("Index");
        }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; 

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty; 

        public string PasswordHashed { get; set; } = string.Empty; 
    }
}
