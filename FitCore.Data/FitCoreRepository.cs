using FitCore.Model.Interfaces;
using FitCore.Model.Training;
using FitCore.Model.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCore.Data
{
    public class FitCoreRepository : IRepository
    {
        private readonly FitCoreDbContext ctx;

        public FitCoreRepository(FitCoreDbContext ctx) => 
            this.ctx = ctx;

        public async Task<EntityEntry<Workout>> AddWorkoutAsync(Workout workout) => 
            await ctx.Workouts.AddAsync(workout);

        public async Task AddWorkoutsAsync(IEnumerable<Workout> workouts) => 
            await ctx.Workouts.AddRangeAsync(workouts);

        public Task<EntityEntry<Workout>> DeleteWorkoutAsync(Workout workout) => 
            Task.FromResult(ctx.Workouts.Remove(workout));

        public async Task<IEnumerable<Exercise>> GetAllExercisesAsync() => 
            await Task.FromResult(ctx.Exercises.AsQueryable().AsNoTracking());

        public async Task<IEnumerable<Program>> GetAllUsersWorkoutsAsync(int userId) => 
            await Task.FromResult(ctx.WorkoutPrograms.Where(u => u.AthleteId == userId)
                .AsQueryable());

        public async Task<Exercise> GetExerciseDetailsAsync(int exerciseId) =>
            await ctx.Exercises.FindAsync(exerciseId);

        public async Task<Workout> GetWorkoutAsync(int workoutId) =>
            await ctx.Workouts.Include(e => e.Exercises)
            .FirstOrDefaultAsync(i => i.WorkoutId == workoutId);

        public async Task<int> SaveChangesAsync() => 
            await ctx.SaveChangesAsync();

        public async Task<EntityEntry<Workout>> UpdateWorkoutAsync(Workout workout) => 
            await Task.FromResult(ctx.Workouts.Update(workout));
    }
}
