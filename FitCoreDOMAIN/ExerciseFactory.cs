using System.Collections;

namespace FitCoreDOMAIN;

public class ExerciseFactory
{
    public IExercise createExercise(string type, string name, string description)
    {
        if (type == "STRETCH")
        {
            return new ExerciseStretch(name, description);
        }
        else if (type == "AEROBIC")
        {
            return new ExerciseAerobic(name, description);
        }
        else
        {
            return new ExerciseResistance(name, description);
        }
    }

}

