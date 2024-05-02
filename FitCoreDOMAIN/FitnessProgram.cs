namespace FitCoreDOMAIN;

// ### PROGRAM IS A SET OF WORKOUTS - FOR EXAMPLE, CARIO WORKOUT, FOLLOWED BY RESISTANCE, FOLLOWED BY STRETCHING
// THIS GIVES US THE FLEXBILITY OF TAILORING WORKOUTS TO THE NEEDS OF THE CLIENT 
public class FitnessProgram: IFitnessProgram
{
    public int UserID { get; }
    public int ProgramID { get; }
    public string ProgramTitle {get; }
    public List<Workout> Workouts { get; set; }
    public FitnessProgram (int userID, int programID, string programTitle)
    {
        UserID = userID;
        ProgramID = programID;
        ProgramTitle = programTitle;
        Workouts = new List<Workout>();
    }

    public List<Workout> GetProgramWorksouts()
    {
        // ### THESE WORKOUTS WILL COME FROM DB EVENTUALLY, BUT HARD CODE THEM IN NOW
        // TO SET UP TESTING ENVIRONMENT FOR API ...

        Workout workout1 = new Workout("20 MINUTE INTERVALS");
        //workout1.GetListOfExercises(this.ProgramID);
        workout1.GetListOfExercises(1);
        this.Workouts.Add(workout1);

        Workout workout2 = new Workout("RESISTANCE AND WEIGHTS");
        workout2.GetListOfExercises(2);
        this.Workouts.Add(workout2);
        return Workouts;
    }
}