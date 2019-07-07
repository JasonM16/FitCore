using System.ComponentModel.DataAnnotations;

namespace FitCore.Model
{
    public enum BodyPart
    {
        Neck,
        Abdominals,
        Biceps,
        Forearms,
        Triceps,
        Shoulders,
        Lats,
        [Display(Name = "Mid Back")]
        Middle_Back,
        [Display(Name = "Lower Back")]
        Lower_Back,
        Traps,
        Chest,
        Hamstrings,
        Quadraceps,
        Calves,
        Glutes,
        None
    }
}