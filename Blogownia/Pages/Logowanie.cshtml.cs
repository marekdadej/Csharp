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
            LoginData = new LoginViewModel(); // Inicjalizacja LoginData wartością domyślną
        }

        [BindProperty]
        public LoginViewModel LoginData { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = _context.Users
                .FirstOrDefault(u => u.Email == LoginData.Email && u.PasswordHashed == LoginData.PasswordHashed); // Użyj hashowanego hasła

            if (user == null)
            {
                ModelState.AddModelError("", "Niepoprawny email lub hasło");
                return Page();
            }

            // TODO: Ustaw sesję lub ciasteczko użytkownika

            return RedirectToPage("Index"); // Przekieruj na stronę główną po pomyślnym logowaniu
        }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; // Inicjalizacja wartością domyślną

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty; // Inicjalizacja wartością domyślną

        // Dodaj pole do przechowywania hasła zahaszowanego (np. do porównywania w bazie danych)
        public string PasswordHashed { get; set; } = string.Empty; // Inicjalizacja wartością domyślną
    }
}
