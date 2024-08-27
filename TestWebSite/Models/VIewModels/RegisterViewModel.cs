namespace TestWebSite.Models.VIewModels
{
    public class RegisterViewModel
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string CopyPassword { get; set; } = null!;
        public string? Email { get; set; }
    }
}
