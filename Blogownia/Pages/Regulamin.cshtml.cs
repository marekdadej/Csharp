using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogownia.Pages;

public class RegulaminModel : PageModel
{
    private readonly ILogger<RegulaminModel> _logger;

    public RegulaminModel(ILogger<RegulaminModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
