using System;
using dm = Workout.Library.DataModels;
using bm = Workout.Library.BusinessModels;

namespace Workout.Library.BusinessModels;

public class Workout : dm.Workout
{
    public List<bm.Exercise> Exercises { get; set;} = new List<bm.Exercise>();
}
