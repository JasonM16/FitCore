using FitCore.Data.MappingConfigurations;
using FitCore.Model.Training;
using FitCore.Model.User;
using Microsoft.EntityFrameworkCore;

namespace FitCore.Data
{
    public class FitCoreDbContext : DbContext
    {
        public FitCoreDbContext(DbContextOptions<FitCoreDbContext> options) 
            : base(options){}

        public FitCoreDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // helpful for testing...
            // will not override UseInMemoryDatabase configuration 
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FitCoreDb.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AthleteConfiguration());
            builder.ApplyConfiguration(new CardioSessionConfiguration());
            builder.ApplyConfiguration(new ExerciseConfiguration());
            builder.ApplyConfiguration(new ExerciseSetsConfiguration());
            builder.ApplyConfiguration(new WorkoutConfiguration());
        }

        
        public DbSet<Athlete> Users { get; set; }
        public DbSet<Program> WorkoutPrograms { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }        
        public DbSet<ExerciseSets> ExerciseSets { get; set; }
        public DbSet<CardioSession> CardioSessions { get; set; }
    }
}
