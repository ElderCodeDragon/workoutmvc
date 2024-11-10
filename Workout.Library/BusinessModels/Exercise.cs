using System;
using dm = Workout.Library.DataModels;

namespace Workout.Library.BusinessModels;

public class Exercise : dm.Exercise
{
    public List<dm.ExerciseSet> Sets { get; set; } = new List<dm.ExerciseSet>();
}
