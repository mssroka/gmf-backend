﻿using Gymify.Domain.Constants.Column;
using Gymify.Domain.Entities;
using Gymify.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gymify.Persistence.Configurations;

public class CoachCategoryConfiguration : IEntityTypeConfiguration<CoachCategory>
{
    public void Configure(EntityTypeBuilder<CoachCategory> builder)
    {
        builder.HasKey(e => e.CoachCategoryId).HasName("CoachCategory_pk");

        builder.ToTable("CoachCategory");

        builder.Property(e => e.CoachCategoryId).ValueGeneratedNever();
        
        builder.Property(e => e.CoachCategoryName)
            .HasMaxLength(CoachColumnConstants.CategoryNameLimit)
            .IsUnicode(false);
        builder.Seed();
    }
}