using FitCore.Model;
using FitCore.Model.Training;
using System.Collections.Generic;

namespace FitCore.Data
{
    public class Seed
    {
        public static List<Exercise> GetExercises() => new List<Exercise>
        {
            #region Chest 

            new Exercise
            {
                Name = "Dumbbell Bench Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {
                Name = "Pushups",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell Flyes",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Incline Dumbbell Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {

                Name = "Low Cable Crossover",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {

                Name = "Decline Dumbbell Flyes",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {

                Name = "Dips - Chest Version",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Triceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Barbell Bench Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {

                Name = "Incline Cable Flye",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {
                Name = "Decline Barbell Bench Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Chest,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },

            #endregion

            #region Lats
            new Exercise
            {

                Name = "Pullups",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Chin-Up",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Lat Pulldown",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Straight-Arm Pulldown ",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {

                Name = "Reverse Grip Bent-Over Rows",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "One-Arm Dumbbell Row",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Dumbbell Incline Row",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Seated Cable Rows",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Bent Over Barbell Row",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lats,
                SecondaryMuscleGroup = BodyPart.Biceps,
                Description = @""
            },
            new Exercise
            {

                Name = "Deadlift",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lower_Back,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {

                Name = "Stiff Leg Barbell Good Morning",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Lower_Back,
                SecondaryMuscleGroup = BodyPart.Hamstrings,
                Description = @""
            },

            #endregion

            #region Legs and Calves

            new Exercise
            {

                Name = "Barbell Full Squat",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {

                Name = "Box Squat",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {

                Name = "Front Barbell Squat",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {

                Name = "Dumbbell Lunges",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Hamstrings,
                Description = @""
            },
            new Exercise
            {

                Name = "Leg Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Hamstrings,
                Description = @""
            },
            new Exercise
            {

                Name = "Single-Leg Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.Hamstrings,
                Description = @""
            },
            new Exercise
            {

                Name = "Leg Curls",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Hamstrings,
                SecondaryMuscleGroup = BodyPart.Glutes,
                Description = @""
            },
            new Exercise
            {

                Name = "Stiff-Legged Dumbbell Deadlift",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Hamstrings,
                SecondaryMuscleGroup = BodyPart.Lower_Back,
                Description = @""
            },
            new Exercise
            {

                Name = "Leg Extensions",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Quadraceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {

                Name = "Seated Calf Raises",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Calves,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {

                Name = "Standing Calf Raises",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Calves,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            #endregion

            #region Triceps

            new Exercise
            {
                Name = "Dips",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "EZ Bar Triceps Extension",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Close-Grip Barbell Bench Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {
                Name = "Triceps Pushdown",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Reverse Grip Triceps Pushdown",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Standing Dumbbell Triceps Extension",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Push-Ups - Close Triceps Position",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {
                Name = "EZ-Bar Skullcrusher",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Triceps Pushdown - Rope Attachment",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Cable One Arm Tricep Extension",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Seated Triceps Press",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Close-Grip EZ-Bar Press",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.Shoulders,
                Description = @""
            },
            new Exercise
            {
                Name = "Tricep Dumbbell Kickback",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Triceps Pushdown",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Triceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },

            #endregion

            #region Biceps
            new Exercise
            {
                Name = "Incline Hammer Curls",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.Forearms,
                Description = @""
            },
            new Exercise
            {
                Name = "Wide-Grip Standing Barbell Curl",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Spider Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "EZ-Bar Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Hammer Curls",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.Forearms,
                Description = @""
            },
            new Exercise
            {
                Name = "Concentration Curls",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Overhead Cable Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell Bicep Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Cross Body Hammer Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Biceps,
                SecondaryMuscleGroup = BodyPart.Forearms,
                Description = @""
            },
            #endregion
            
            #region Shoulders and Traps
            new Exercise
            {
                Name = "Standing Palm-In One-Arm Dumbbell Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Single-Arm Linear Jammer",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Standing Military Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Abdominals,
                Description = @""
            },
            new Exercise
            {
                Name = "Side Laterals",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Seated Dumbbell Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Reverse Flyes",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Front Dumbbell Raise",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell Shoulder Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Arnold Dumbbell Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Front Cable Raise",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Barbell Shoulder Press",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell Upright Row",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Barbell Upright Row",
                Type = Model.Enums.MovementType.Compound,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell Shrug",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Traps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Barbell Shrug",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Traps,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Upright Cable Row",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Shoulders,
                SecondaryMuscleGroup = BodyPart.Traps,
                Description = @""
            },
            #endregion
            
            #region Forearms
            new Exercise
            {
                Name = "Palms-Down Dumbbell Wrist Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Forearms,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Palms-Up Dumbbell Wrist Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Forearms,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Standing Palms-Up Barbell Behind The Back Wrist Curl",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Forearms,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            #endregion
                       

            #region Abs
            new Exercise
            {
                Name = "Landmine 180's",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Plank",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Standing Cable Lift",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Hanging Leg Raise",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Crunches",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Kneeling Cable Crunch With Alternating Oblique Twists",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },
            new Exercise
            {
                Name = "Dumbbell V-Sit Cross Jab",
                Type = Model.Enums.MovementType.Isolated,
                TargetMuscleGroup = BodyPart.Abdominals,
                SecondaryMuscleGroup = BodyPart.None,
                Description = @""
            },

            #endregion

            //new Exercise
            //{
            //    Name = "",
            //    Type = Model.Enums.MovementType.Compound,
            //    TargetMuscleGroup = BodyPart.,
            //    SecondaryMuscleGroup = BodyPart.,
            //    Description = @""
            //},
        };
    }
}
