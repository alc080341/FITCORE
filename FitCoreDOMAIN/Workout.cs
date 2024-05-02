namespace FitCoreDOMAIN;

public class Workout
{
    public string Title { get; set;}
    public List<IExercise> Exercises { get; set; }

    public Workout(string title)
    {
        Title = title;
        Exercises = new List<IExercise>();
    }

    public void AddExercise(string type, string exerciseName = "NO EXERCISE NAME", string exerciseDescription = "NO DESCRIPTION")
    {
        ExerciseFactory createExercise = new ExerciseFactory();
        this.Exercises.Add(createExercise.createExercise(type, exerciseName, exerciseDescription));
    }
    public List<IExercise> GetListOfExercises(int programID)    
    {
        // ### SAMPLE TEST WORKOUT - THIS WILL COME FROM DB EVENTUALLY. HOWEVER, THIS IS JUST FOR TESTING ENVIRONMENT
        switch (programID)
        {
            case 1:
                this.AddExercise("AEROBIC", "Running", "Interval 1 - 200metres");
                this.AddExercise("AEROBIC", "Running", "Interval 2 - 400metres");
            break;
            case 2:
                this.AddExercise("RESISTANCE", "Push Up", "Bodyweight exercise targeting chest and arms.");
                this.AddExercise("RESISTANCE", "Squats", "Lower body exercise that targets legs.");
            break;
        }
        return Exercises;
    }

}
