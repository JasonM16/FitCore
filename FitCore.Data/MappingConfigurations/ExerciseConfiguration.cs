using FitCore.Model;
using FitCore.Model.Enums;
using FitCore.Model.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FitCore.Data.MappingConfigurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            // https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions
            builder
                .Property(bp => bp.TargetMuscleGroup)
                .HasConversion(
                    v => v.ToString(),
                    v => (BodyPart)Enum.Parse(typeof(BodyPart), v));

            builder
               .Property(bp => bp.SecondaryMuscleGroup)
               .HasConversion(
                   v => v.ToString(),
                   v => (BodyPart)Enum.Parse(typeof(BodyPart), v));

            builder
               .Property(bp => bp.Type)
               .HasConversion(
                   v => v.ToString(),
                   v => (MovementType)Enum.Parse(typeof(MovementType), v));
        }
    }
}
