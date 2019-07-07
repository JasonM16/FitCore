using FitCore.Data;
using FitCore.Model.Training;
using FitCore.Model.User;
using FitCore.Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FitCore.Model.UnitTests
{
    public class UserTests
    {
        
        //[Theory]
        //[InlineData(" ", " ")]
        //[InlineData("Jason", " ")]
        //[InlineData("   Jason", " ")]
        //[InlineData(" ", " Mo")]
        //[InlineData(" ", "    Morand   ")]
        //public void Create_User_With_Null_Or_Whitespace_Name_Throws_Exception(string f, string l)
        //{
        //    Assert.Throws<ArgumentException>(() =>
        //    new Athlete
        //    {
        //        FirstName = f,
        //        LastName = l,
        //        Birthdate = new DateTime(1979, 12, 16)
        //    });
        //}


        [Fact]
        public void Can_Build_Athlete()
        {
            var athlete = TestData.Build_Athlete();
            Assert.NotNull(athlete.FirstName);
        }

        [Fact]
        public void User_Can_Add_Workout_To_Their_Account()
        {           
            var athlete = TestData.Build_Athlete();
            var workout = TestData.Build_Chest_Workout();
            athlete.AddWorkouts(workout);

            var set_five_weight = workout.Exercises[0].Sets[4].Weight;

            Assert.Single(workout.Exercises);
            Assert.Equal(155 ,set_five_weight);
        }          

    }
}
