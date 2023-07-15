using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace registration.Pages.User;




public class LogoutModel : PageModel
{
    // private readonly ILogger<LogoutModel> _logger;

    // public LogoutModel(ILogger<LogoutModel> logger)
    // {
    //     _logger = logger;
    // }


 

    public async Task<IActionResult> OnPostAsync()
    {
        await HttpContext.SignOutAsync("UserCookieAuth");
        return RedirectToPage("/Index");

    }
}


