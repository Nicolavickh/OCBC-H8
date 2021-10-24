using System.ComponentModel.DataAnnotations;

namespace Bank_PaymentDetails
{
    public class TokenRequest
    {
        [Required]
        public string Token{get; set;}
        [Required]
        public string RefreshToken {get; set;}
    }
}