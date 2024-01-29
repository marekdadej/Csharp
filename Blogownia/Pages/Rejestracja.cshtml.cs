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

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == RegistrationUser.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("RegistrationUser.Email", "Email już istnieje w bazie danych.");
                return Page();
            }

            RegistrationUser.PasswordHashed = HashPassword(RegistrationUser.PasswordHashed);

            _context.Users.Add(RegistrationUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Logowanie");
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
