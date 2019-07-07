using FitCore.Model.Training;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FitCore.Model.User
{
    public class Athlete 
    {   
        private List<Workout> _workouts = new List<Workout>();
        public int AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }        
        public virtual IReadOnlyList<Workout> Workouts => _workouts.ToList();
        public void AddWorkouts(List<Workout> workouts) => _workouts.AddRange(workouts);
        public void AddWorkouts(Workout workout) => _workouts.Add(workout);
    }
}
