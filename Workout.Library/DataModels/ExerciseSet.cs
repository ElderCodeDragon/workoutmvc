using System;
using Workout.Library.DataModels.Base;

namespace Workout.Library.DataModels;

public class ExerciseSet : LongIdBase
{
    public int ExerciseId { get; set; } = 0;
    public short? Reps { get; set; }
    public short MeasurementTypeId { get; set; } = 0;
}
