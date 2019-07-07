using FitCore.Model.Training;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitCore.Data
{
    public class WorkoutService
    {
        private readonly FitCoreDbContext context;

        public WorkoutService(FitCoreDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Workout workout)
        {
            await context.Workouts.AddAsync(workout);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                var ex = e.InnerException;
            }
            
        }

        public async Task<Workout> GetWorkoutAsync(int id)
        {
            return await context.Workouts.FindAsync(id);
        }

        

    }
}
