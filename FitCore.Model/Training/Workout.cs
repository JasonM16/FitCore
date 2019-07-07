using System;
using System.Collections.Generic;

namespace FitCore.Model.Training
{
    public class Workout
    {
        public int WorkoutId { get; set; }       
        public DateTime Day { get; set; }
        public DateTime TimeRange { get; set; }
        public int DurationInMinutes  { get; set; }
        public virtual CardioSession CardioSession { get; set; }
        public virtual IReadOnlyList<ExerciseSets> Exercises { get; set; }      
    }
}
