namespace FitCoreDOMAIN;

public class ExerciseStretch: IExercise
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Equipment { get; set;}
    public string? Difficulty { get; set;}

    public ExerciseStretch(string name, string description)
    {
        Name = name;
        Description = description;
    }

    string IExercise.getName()
    {
        return this.Name;
    }
}
