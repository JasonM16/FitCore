using FitCore.Model.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FitCore.Data.MappingConfigurations
{
    public class AthleteConfiguration : IEntityTypeConfiguration<Athlete>
    {
        public void Configure(EntityTypeBuilder<Athlete> builder)
        {
            
        }
    }
}
