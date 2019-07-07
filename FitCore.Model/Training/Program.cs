using System.Collections.Generic;

namespace FitCore.Model.Training
{
    public class Program
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public virtual IReadOnlyList<Workout> Workouts { get; set; }
        public int AthleteId { get; set; }
    }
}
