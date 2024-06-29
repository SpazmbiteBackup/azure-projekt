using System.ComponentModel.DataAnnotations;

namespace AzureWebsite.Api.Models;

public class SignInVm
{
    [Required]
    public string UserName { get; set; }
}