namespace FitCore.Model.Training
{
    public class CardioSession
    { 
        public int CardioSessionId { get; set; }
        public CardioType Type { get; set; }
        public int DurationInMinutes { get; set; }
        public int WorkoutId { get; set; }
    }
}