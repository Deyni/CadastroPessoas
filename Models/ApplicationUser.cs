using Microsoft.AspNetCore.Identity;


public class ApplicationUser : IdentityUser
{
    public string NomeCompleto { get; set; } = string.Empty;
}
