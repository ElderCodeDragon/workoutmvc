using System;
using Workout.Library.DataModels.Base;

namespace Workout.Library.DataModels;

public class Workout : IntIdBase
{
    public string WorkoutName { get; set; } = "";
    public short WorkoutType { get; set; } = 0;

}
