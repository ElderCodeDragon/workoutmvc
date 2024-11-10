using System;
using Workout.Library.DataModels.Base;

namespace Workout.Library.DataModels;

public class Exercise : IntIdBase
{
    public string ExerciseName { get; set; } = "";
    public short ExerciseType { get; set; } = 0;
    public int WorkoutId { get; set; } = 0;
}

