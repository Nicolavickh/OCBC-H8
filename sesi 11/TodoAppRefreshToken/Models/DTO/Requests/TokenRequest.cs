using System.ComponentModel.DataAnnotations;

namespace TodoAppRefreshToken
{
    public class TokenRequest
    {
        [Required]
        public string Token{get; set;}
        [Required]
        public string RefreshToken {get; set;}
    }
}