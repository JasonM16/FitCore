using FitCore.Model.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitCore.Data.MappingConfigurations
{
    public class ExerciseSetsConfiguration : IEntityTypeConfiguration<ExerciseSets>
    {
        public void Configure(EntityTypeBuilder<ExerciseSets> builder)
        {
            
        }
    }
}
