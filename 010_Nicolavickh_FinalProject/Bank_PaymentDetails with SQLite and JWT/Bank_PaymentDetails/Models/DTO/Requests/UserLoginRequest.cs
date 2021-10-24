using System.ComponentModel.DataAnnotations;

namespace Bank_PaymentDetails.Models.DTO.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email{get; set;}
        [Required]
        public string Password{get; set;}
    }
}