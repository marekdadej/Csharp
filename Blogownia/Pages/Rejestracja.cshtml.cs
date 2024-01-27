using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;
using Blogownia.Data;
using Blogownia.Models;

namespace Blogownia.Pages
{
    public class RejestracjaModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RejestracjaModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User RegistrationUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Sprawdzenie, czy użytkownik z takim emailem już istnieje
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == RegistrationUser.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("RegistrationUser.Email", "Email już istnieje w bazie danych.");
                return Page();
            }

            // Hashowanie hasła
            RegistrationUser.Password = HashPassword(RegistrationUser.Password);

            // Dodanie użytkownika do bazy danych
            _context.Users.Add(RegistrationUser);
            await _context.SaveChangesAsync();

            // Przekierowanie do strony logowania
            return RedirectToPage("/Logowanie");
        }

        private string HashPassword(string password)
        {
            // Tu użyj rzeczywistego algorytmu hashowania, np. BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
