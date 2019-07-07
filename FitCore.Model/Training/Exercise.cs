using FitCore.Model.Enums;

namespace FitCore.Model.Training
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MovementType Type { get; set; }
        public BodyPart TargetMuscleGroup { get; set; }
        public BodyPart SecondaryMuscleGroup { get; set; }
    }
}