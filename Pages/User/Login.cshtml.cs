using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace registration.Pages.User;



public class User
{   
    public int Id { get; set; }

    [Required]
    [Display(Name = "User Name")]
    public string UserName { get; set; }

    [Required]
    public string Email { get; set;}

    [DataType(DataType.Password)]
    public string Password { get; set; }

    //     public string? FirstName { get; set; }

    //     public string? LastName { get; set; }

    //     public DateTime DateOfBirth { get; set; }
}

public class LoginModel : PageModel
{
    // private readonly ILogger<LoginModel> _logger;

    // public LoginModel(ILogger<LoginModel> logger)
    // {
    //     _logger = logger;
    // }


    [BindProperty]
    public User User { get; set; }

    

    // Cookie persists while browser is open unless cookie is deleted.
    public void OnGet()
    {

        //return Page();

    }


    public async Task<IActionResult> OnPostAsync()
    {

        // TODO: fix this
        // if (!ModelState.IsValid)
        // {
        //     return Page();
        // }

        //Authenticate user
        if (User.UserName == "username" && User.Password == "password")
        {
            //Create security context
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "test"),
                new Claim(ClaimTypes.Email, "test@test.com"),
                new Claim("Role", "Admin"),
                //new Claim()

            };

            var identity = new ClaimsIdentity(claims, "UserCookieAuth");
            var claimsPrincipal = new ClaimsPrincipal(identity);

            //serialize claims principal to a string and encrypt as a cookie saved in HttpContext
            await HttpContext.SignInAsync("UserCookieAuth", claimsPrincipal);

            return RedirectToPage("/Index");

            
        }

        return Page();

    }
}


