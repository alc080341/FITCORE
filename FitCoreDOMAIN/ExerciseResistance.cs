namespace FitCoreDOMAIN;

public class ExerciseResistance: IExercise
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Equipment { get; set;}
    public string? Difficulty { get; set;}

    public ExerciseResistance(string name, string description)
    {
        Name = name;
        Description = description;
    }

   string IExercise.getName()
    {
        return this.Name;
    }
}
