namespace FitCoreDOMAIN;

public class Exercise
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Equipment { get; set;}
    public string? Difficulty { get; set;}
    
    public Exercise(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
