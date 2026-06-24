namespace Astrena.Website.Services;

public class UserSession
{
    public string? Email { get; private set; }
    public string? Role { get; private set; }

    public bool IsAuthenticated => !string.IsNullOrEmpty(Role);

    public void SignIn(string email, string role)
    {
        Email = email;
        Role = role;
    }

    public void SignOut()
    {
        Email = null;
        Role = null;
    }
}
