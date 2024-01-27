using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogownia.Data;
using Blogownia.Models;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Post> Posts { get; set; } = new List<Post>();

    public async Task OnGetAsync()
    {
        Posts = await _context.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
                .ThenInclude(c => c.User)
            .ToListAsync();
    }

    public IActionResult OnPostAddPost(string title, string content)
    {
        if (!User.Identity.IsAuthenticated)
        {
            return Unauthorized();
        }

        var user = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
        if (user == null)
        {
            // Możliwe, że warto tutaj dodać jakiś komunikat błędu lub logikę obsługi błędu.
            return RedirectToPage("Error"); // Przykładowa strona błędu
        }

        var newPost = new Post
        {
            Title = title,
            Content = content,
            DatePosted = DateTime.Now,
            UserId = user.UserId
        };

        _context.Posts.Add(newPost);
        _context.SaveChanges();

        return RedirectToPage();
    }

    public IActionResult OnPostAddComment(int postId, string content)
    {
        if (!User.Identity.IsAuthenticated)
        {
            return Unauthorized();
        }

        var user = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
        if (user == null)
        {
            return RedirectToPage("Error");
        }

        var newComment = new Comment
        {
            Content = content,
            DatePosted = DateTime.Now,
            PostId = postId,
            UserId = user.UserId
        };

        _context.Comments.Add(newComment);
        _context.SaveChanges();

        return RedirectToPage();
    }
}
