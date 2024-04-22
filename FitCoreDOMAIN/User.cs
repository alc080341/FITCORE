namespace FitCoreDOMAIN;

public class User
{

    public int UserID { get; }
    public string Username { get; }

    public User(int userID, string username)
    {
        UserID = userID;
        Username = username;
    }
}

