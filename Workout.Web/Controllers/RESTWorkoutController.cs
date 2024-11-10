using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using b = Workout.Library.BusinessModels;
using d = Workout.Library.DataModels;

namespace Workout.Web.Controllers
{
    [ApiController]
    [Route("REST/Workout")]
    [AllowAnonymous]
    public class RESTWorkoutController : ControllerBase
    {
        private readonly IConfiguration _config;
        public RESTWorkoutController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Test(){
            b.Workout output = new b.Workout{
                Id = 1,
                WorkoutName = "Test Workout",
                WorkoutType = 1,
                UpdatedBy = "Glenn"
            };

            // Create 3 exercises with different sets
            b.Exercise Exercise1 = new b.Exercise {
                Id = 1,
                ExerciseName = "Text Exercise 1",
                ExerciseType = 1,
                WorkoutId = 1,
                UpdatedBy = "Glenn"
            };
            // create 3 sets for Exercise 1
            d.ExerciseSet set1 = new d.ExerciseSet {
                Id = 1,
                ExerciseId = 1,
                Reps = 12,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            d.ExerciseSet set2 = new d.ExerciseSet {
                Id = 2,
                ExerciseId = 1,
                Reps = 10,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            d.ExerciseSet set3 = new d.ExerciseSet {
                Id = 3,
                ExerciseId = 1,
                Reps = 8,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            Exercise1.Sets.Add(set1);
            Exercise1.Sets.Add(set2);
            Exercise1.Sets.Add(set3);
            output.Exercises.Add(Exercise1);

            b.Exercise Exercise2 = new b.Exercise {
                Id = 2,
                ExerciseName = "Text Exercise 2",
                ExerciseType = 2,
                WorkoutId = 1,
                UpdatedBy = "Glenn"
            };
            d.ExerciseSet set4 = new d.ExerciseSet{
                Id=4,
                ExerciseId = 2,
                Reps = 10,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            d.ExerciseSet set5 = new d.ExerciseSet{
                Id=5,
                ExerciseId = 2,
                Reps = 10,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            d.ExerciseSet set6 = new d.ExerciseSet{
                Id=6,
                ExerciseId = 2,
                Reps = 10,
                MeasurementTypeId = 1,
                UpdatedBy = "Glenn"
            };
            Exercise2.Sets.Add(set4);
            Exercise2.Sets.Add(set5);
            Exercise2.Sets.Add(set6);
            output.Exercises.Add(Exercise2);

            b.Exercise Exercise3 = new b.Exercise{
                Id = 3,
                ExerciseName = "Text Exercise 3",
                ExerciseType = 3,
                WorkoutId = 1,
                UpdatedBy = "Glenn"
            };
            
            d.ExerciseSet set7 = new d.ExerciseSet{
                Id = 7,
                ExerciseId = 3,
                Reps = 15,
                MeasurementTypeId = 2,
                UpdatedBy = "Glenn"
            };
            Exercise3.Sets.Add(set7);
            output.Exercises.Add(Exercise3);

            return Ok(output);
        }
    }
}