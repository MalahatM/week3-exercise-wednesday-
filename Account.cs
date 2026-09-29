// Register and Login uppgift

// Class for user account
class Account
{
    // Properties for username and password
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";

    // Method for registration
    public bool Register(string username, string password)
    {
        // Check if the password is strong enough
        if (CheckPasswordStrength(password))
        {
            Username = username;
            Password = password;

            return true;
        }

        return false;
    }

    // Method for login
    public bool Login(string username, string password)
    {
        // Check if username and password are correct
        if (Username == username && Password == password)
        {
            return true;
        }

        return false;
    }

    // Method for checking password strength
    public bool CheckPasswordStrength(string password)
    {
        // Password must have at least 6 characters
        bool hasLength = password.Length >= 6;

        // Password must have at least one number
        bool hasNumber = password.Any(char.IsDigit);

        // Password must have at least one uppercase letter
        bool hasUppercase = password.Any(char.IsUpper);

        // Password must have at least one special character
        bool hasSpecialCharacter = password.Any(ch => !char.IsLetterOrDigit(ch));

        // All conditions must be true
        return hasLength && hasNumber && hasUppercase && hasSpecialCharacter;
    }
}