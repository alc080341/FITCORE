namespace FitCoreDOMAIN;

public class User
{

    private int UserID { get; }
    private string Username { get; }

    public User(int userID, string username)
    {
        UserID = userID;
        Username = username;
    }
}

