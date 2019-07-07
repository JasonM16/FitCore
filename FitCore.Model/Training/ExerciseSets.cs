using System.Collections.Generic;

namespace FitCore.Model.Training
{
    public class ExerciseSets
    {
        public int ExerciseSetsId { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int WorkoutId { get; set; }        
        public IReadOnlyList<Set> Sets { get; set; }
    }
}