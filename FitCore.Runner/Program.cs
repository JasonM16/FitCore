using FitCore.Data;
using FitCore.Model.Interfaces;
using FitCore.Tests.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FitCore.Runner
{
    class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddDbContextPool<FitCoreDbContext>(op =>
              op.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FitCoreDb.Data;Trusted_Connection=True;MultipleActiveResultSets=true"))
              .AddTransient<IRepository, FitCoreRepository>();

            // C# 8.0 feature
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/using
            using var ctx = new FitCoreDbContext(new DbContextOptions<FitCoreDbContext>());


            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            ctx.Exercises.AddRange(Seed.GetExercises());
            var workout = TestData.Build_Chest_Workout();
            var user = TestData.Build_Athlete();
            user.AddWorkouts(workout);
            ctx.Users.Add(user);
            ctx.SaveChanges();

            // make a full workout and add it to user...
            TestGraph(ctx);

        }

        private static void TestGraph(FitCoreDbContext ctx)
        {
            // get user:
            var user = ctx.Users.FirstOrDefault();
            Console.WriteLine($"Athlete: {user.FirstName} {user.LastName} Date of Birth: {user.Birthdate}");
            PrintWorkout(ctx);
            Console.ReadLine();
        }

        private static void PrintWorkout(FitCoreDbContext ctx)
        {
            var user = ctx.Users.Include(w => w.Workouts).FirstOrDefault();
            

            int count = 1;
            int exerciseCount = 1;
            int setCount = 1;
            foreach (var workout in user.Workouts)
            {
                Console.WriteLine($"Workout {count++}\n");

                foreach (var exercise in workout.Exercises)
                {
                    Console.WriteLine($"Exercise {exerciseCount++}: {exercise.Exercise.Name}\n");

                    foreach (var set in exercise.Sets)
                    {
                        Console.WriteLine($"Set {setCount++}: Reps: {set.Reps}  Weight: {set.Weight}");
                    }
                    Console.WriteLine();
                    setCount = 1;
                }
                Console.WriteLine();
            }
        }
    }
}
