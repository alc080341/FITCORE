﻿using System.Security.Cryptography.X509Certificates;

namespace FitCoreDOMAIN;

// ### PROGRAM IS A SET OF WORKOUTS - FOR EXAMPLE, CARIO WORKOUT, FOLLOWED BY RESISTANCE, FOLLOWED BY STRETCHING
// THIS GIVES US THE FLEXBILITY OF TAILORING WORKOUTS TO THE NEEDS OF THE CLIENT 
public class Program
{
    public int UserID { get; }
    public int ProgramID { get; }
    public List<Workout> Workouts { get; set; }
    public Program (int userID, int programID)
    {
        UserID = userID;
        ProgramID = programID;
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