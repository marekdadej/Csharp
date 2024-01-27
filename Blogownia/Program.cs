using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Blogownia.Data; // Upewnij się, że ta przestrzeń nazw odpowiada lokalizacji Twojego ApplicationDbContext

var builder = WebApplication.CreateBuilder(args);

// Dodaj usługi do kontenera.
builder.Services.AddRazorPages();

// Rejestruj ApplicationDbContext z Entity Framework Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Konfiguracja potoku żądań HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
