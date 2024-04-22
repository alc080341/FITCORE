namespace FitCoreDOMAIN;

public class Exercise
{
    public string Name { get; }
    public string Description { get; }
    public string? Equipment { get; }
    public string? Difficulty { get; }

    public Exercise(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
