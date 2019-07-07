using FitCore.Tests.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace FitCore.Data.IntegrationTests
{
    public class WorkoutTests
    {
        [Fact]
        public void Cannot_Add_Workout_To_Repository_Without_A_User()
        {
            // In-memory database only exists while the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            try
            {
                var options = new DbContextOptionsBuilder<FitCoreDbContext>()
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database
                using (var context = new FitCoreDbContext(options))
                {
                    context.Database.EnsureCreated();
                }

                // Run the test against one instance of the context
                using (var context = new FitCoreDbContext(options))
                {
                    // add exercise...
                    //context.Exercises.Add(TestData.Build_Single_Exercise());
                    var workout = TestData.Build_Chest_Workout();
                    context.Workouts.Add(workout);
                    Assert.Throws<DbUpdateException>(() => context.SaveChanges());
                }

                // Use a separate instance of the context to verify correct data was saved to database
                using (var context = new FitCoreDbContext(options))
                {
                    Assert.Equal(0, context.Workouts.Count());                    
                }
            }
            finally
            {
                connection.Close();
            }
        }

        [Fact]
        public void User_Can_Add_Workout_To_Their_Account()
        {
            // In-memory database only exists while the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            try
            {
                var options = new DbContextOptionsBuilder<FitCoreDbContext>()
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database
                using (var context = new FitCoreDbContext(options))
                {
                    context.Database.EnsureCreated();
                }

                // Run the test against one instance of the context
                using (var context = new FitCoreDbContext(options))
                {
                    // add exercise...
                    context.Exercises.Add(TestData.Build_Single_Exercise());
                    context.Users.Add(TestData.Build_Athlete());
                    context.SaveChanges();

                    var workout = TestData.Build_Chest_Workout();                    
                    var userService = new UserService(context);
                    var user = context.Users.FirstOrDefault();
                    user.AddWorkouts(workout);                    
                    context.SaveChanges();                    
                }

                // Use a separate instance of the context to verify correct data was saved to database
                using (var context = new FitCoreDbContext(options))
                {
                    var user = context.Users.FirstOrDefault();
                    Assert.NotNull(user.FirstName);
                    Assert.Equal(1, context.Workouts.Count());
                }
            }
            finally
            {
                connection.Close();
            }

        }


        //[Fact]
        //public void User_Can_Add_New_Set_To_Their_Workout()
        //{

        //}
        //[Fact]
        //public void User_Can_Search_For_A_Workout_By_Id()
        //{

        //}
        //[Fact]
        //public void User_Can_Search_For_A_Workout_By_Name()
        //{

        //}
        //[Fact]
        //public void User_Can_Search_For_A_Workout_By_BodyPart()
        //{

        //}

        //[Fact]
        //public void User_Can_See_List_Of_All_Their_Workouts()
        //{

        //}



    }
}
