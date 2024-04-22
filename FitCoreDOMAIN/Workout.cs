namespace FitCoreDOMAIN;

public class Workout
{
    public string Title { get; }
    private List<Exercise> Exercises { get; }

    public Workout(string title)
    {
        Title = title;
        Exercises = new List<Exercise>();
    }


    public void AddExercise(string exerciseName = "NO EXERCISE NAME", string exerciseDescription = "NO DESCRIPTION")
    {
        this.Exercises.Add(new Exercise(exerciseName, exerciseDescription));
    }
    public void GetListOfExercises(int programID)    
    {
        // ### SAMPLE TEST WORKOUT - THIS WILL COME FROM DB EVENTUALLY. HOWEVER, THIS IS JUST FOR TESTING ENVIRONMENT
        switch (programID)
        {
            case 1:
                this.AddExercise("Running", "Interval 1 - 200metres");
                this.AddExercise("Running", "Interval 2 - 400metres");
            break;
            case 2:
                this.AddExercise("Push Up", "Bodyweight exercise targeting chest and arms.");
                this.AddExercise("Squats", "Lower body exercise that targets legs.");
            break;
        }
    }

}
