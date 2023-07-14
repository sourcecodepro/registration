using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

    


    public void OnGet()
    {

        //return Page();

    }


    public void OnPost()
    {

    }
}


