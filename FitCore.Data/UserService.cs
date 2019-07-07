using FitCore.Model.Training;
using FitCore.Model.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCore.Data
{
    public class UserService
    {
        private readonly FitCoreDbContext context;

        public UserService(FitCoreDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Athlete athlete)
        {
            await context.Users.AddAsync(athlete);
            await context.SaveChangesAsync();
        }

        public async Task<Athlete> GetUser(int id)
        {
            return await context.Users.FirstOrDefaultAsync(i => i.AthleteId == id);
        }

        public async Task<IReadOnlyList<Workout>> GetWorkoutsForUser(int id)
        {
            var user = await GetUser(id);
            return user.Workouts.ToList().AsReadOnly();
        }

        public async Task<IReadOnlyList<Workout>> Get_User_Workouts_By_Date_Interval(int id, DateTime start, DateTime end)
        {
            var user = await GetUser(id);
            return user.Workouts.Where(sd => sd.Day.Date == start.Date)
                .ToList().AsReadOnly();
        }
    }
}
