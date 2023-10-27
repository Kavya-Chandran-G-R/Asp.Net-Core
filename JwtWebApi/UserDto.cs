using System.ComponentModel.DataAnnotations;

namespace JwtWebApi
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
