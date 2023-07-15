
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace registration.Pages.User;

// [Authorize(Policy = "AdminsOnly")]
[Authorize("AdminsOnly")]
public class AdminModel : PageModel
{
    // private readonly ILogger<AdminModel> _logger;

    // public AdminModel(ILogger<AdminModel> logger)
    // {
    //     _logger = logger;
    // }



    public void OnGet()
    {

        

    }


    
}


