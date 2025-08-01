namespace MyWebGameShop.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string UserAgent { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int WalletBalance { get; set; }
}