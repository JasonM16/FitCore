using FitCore.Model.Training;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitCore.Data
{
    public class ExerciseService 
    {
        private readonly FitCoreDbContext ctx;

        public ExerciseService(FitCoreDbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task AddAsync(Exercise exercise)
        {
            await ctx.Exercises.AddAsync(exercise);
            await ctx.SaveChangesAsync();
        }

    }
}
