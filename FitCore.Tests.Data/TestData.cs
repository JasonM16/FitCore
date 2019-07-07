using FitCore.Model;
using FitCore.Model.Training;
using FitCore.Model.User;
using FitCore.Model.Utilities;
using System;
using System.Collections.Generic;


namespace FitCore.Tests.Data
{
    public class TestData
    {
        public static Athlete Build_Athlete() =>
            new Athlete
            {
                FirstName = "Jason",
                LastName = "Morand",
                Birthdate = new System.DateTime(1979, 12, 16)
            };
        
        public static Athlete Build_Athlete_Graph()
        {
            Athlete jay = Build_Athlete();


            var sets = new List<Set> { new Set { SetNumber = 1, Reps = 12, Weight = 45 }, new Set { SetNumber = 2, Reps = 8, Weight = 65 } };
            var exSets = new List<ExerciseSets>
            {
                new ExerciseSets{ ExerciseId = 2, Sets = sets}
            };

            var workouts = new List<Workout>
            {
                new Workout
                {
                    TimeRange = DateTime.UtcNow,
                    Day = System.DateTime.UtcNow,
                    DurationInMinutes = 60,
                    Exercises = exSets
                },
                Build_Chest_And_Back_Workout()
            };


            jay.AddWorkouts(workouts);
            return jay;
        }
        
        public static Exercise Build_Single_Exercise() => 
            new Exercise { Name = "Bench Press", Description = "", Type = Model.Enums.MovementType.Compound,  TargetMuscleGroup = BodyPart.Chest, SecondaryMuscleGroup =  BodyPart.Shoulders };

        public static Workout Build_Chest_And_Back_Workout()
        {
            var exercises = new List<ExerciseSets>
            {                
                new ExerciseSets
                {
                    ExerciseId = 53,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 95},
                        new Set { SetNumber = 2, Reps = 10, Weight = 115},
                        new Set { SetNumber = 3, Reps = 12, Weight = 115},
                        new Set { SetNumber = 4, Reps = 12, Weight = 135},
                        new Set { SetNumber = 5, Reps = 12, Weight = 155},
                    }
                },
                
                new ExerciseSets
                {
                    ExerciseId = 57,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 40},
                        new Set { SetNumber = 2, Reps = 12, Weight = 40},
                        new Set { SetNumber = 3, Reps = 8, Weight = 50},
                    }
                },
                new ExerciseSets
                {
                    ExerciseId = 57,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 25},
                        new Set { SetNumber = 2, Reps = 12, Weight = 35},
                        new Set { SetNumber = 3, Reps = 10, Weight = 45},
                    }                        
                },
                new ExerciseSets
                {
                    ExerciseId = 60,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 95},
                        new Set { SetNumber = 2, Reps = 12, Weight = 95},
                        new Set { SetNumber = 3, Reps = 10, Weight = 115},
                        new Set { SetNumber = 4, Reps = 10, Weight = 135},
                        new Set { SetNumber = 5, Reps = 10, Weight = 155},
                    }
                },
                new ExerciseSets
                {
                    ExerciseId = 48,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 80},
                        new Set { SetNumber = 2, Reps = 12, Weight = 90},
                        new Set { SetNumber = 3, Reps = 12, Weight = 100},
                    }
                },
                new ExerciseSets
                {
                    ExerciseId = 62,
                    Sets = new List<Set>
                    {
                        new Set { SetNumber = 1, Reps = 12, Weight = 95},
                        new Set { SetNumber = 2, Reps = 12, Weight = 135},
                        new Set { SetNumber = 3, Reps = 10, Weight = 155},
                        new Set { SetNumber = 4, Reps = 10, Weight = 175},
                        new Set { SetNumber = 5, Reps =  8, Weight = 205 }
                    }
                }                
            };
            return new Workout
            {
                TimeRange = System.DateTime.UtcNow,
                Day = System.DateTime.UtcNow,
                DurationInMinutes = 50,
                CardioSession = new CardioSession { Type = CardioType.Treadmill, DurationInMinutes = 25 },
                Exercises = exercises
            };                
        }

        public static Workout Build_Chest_Workout()
        {
            var exercises = new List<ExerciseSets>
            {
                new ExerciseSets
                {
                    ExerciseId = 1,
                    Sets = new List<Set>
                    {
                        new Set{ SetNumber = 1, Reps = 12, Weight = 95},
                        new Set{ SetNumber = 2, Reps = 10, Weight = 115},
                        new Set{ SetNumber = 3, Reps = 10, Weight = 115},
                        new Set{ SetNumber = 4, Reps = 8, Weight = 135},
                        new Set{ SetNumber = 5, Reps = 6, Weight = 155},
                    }
                }
            };
            return new Workout
            {                
               TimeRange = DateTime.UtcNow,
               DurationInMinutes = 50,
               CardioSession = new CardioSession { Type = CardioType.Treadmill, DurationInMinutes = 25 },
               Day = DateTime.UtcNow,
               Exercises = exercises
            };
        }
    }
}
