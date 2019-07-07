using System.ComponentModel.DataAnnotations;

namespace FitCore.Model
{
    // TODO: 
    // Should I really have data annotations here?
    // This is an ef and UI concern.
    // Can this be mapped somewhere else?
    public enum CardioType
    {
        [Display(Name = "Stationary Bike")]
        StationaryBike,
        Treadmill,
        [Display(Name = "Stair Climber")]
        StairClimber,
        Running,
        Rowing,
        Other
    }
}