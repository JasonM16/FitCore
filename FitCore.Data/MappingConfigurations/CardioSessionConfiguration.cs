using FitCore.Model;
using FitCore.Model.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FitCore.Data.MappingConfigurations
{
    public class CardioSessionConfiguration : IEntityTypeConfiguration<CardioSession>
    {
        public void Configure(EntityTypeBuilder<CardioSession> builder)
        {
            builder
                .Property(ct => ct.Type)
                .HasConversion(
                   v => v.ToString(),
                   v => (CardioType)Enum.Parse(typeof(CardioType), v));
        }
    }
}
