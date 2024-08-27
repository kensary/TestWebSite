using Microsoft.AspNetCore.Identity.Data;

namespace TestWebSite.Models
{
    public class UsersAc
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
    }
}
