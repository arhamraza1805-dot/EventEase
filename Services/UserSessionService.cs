namespace EventEase.Services;

public class UserSessionService
{
    public string? UserName { get; private set; }
    public string? UserEmail { get; private set; }
    public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);

    public event Action? OnChange;

    public void Login(string name, string email)
    {
        UserName = name;
        UserEmail = email;
        NotifyStateChanged();
    }

    public void Logout()
    {
        UserName = null;
        UserEmail = null;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}