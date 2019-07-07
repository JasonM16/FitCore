﻿// <auto-generated />
using System;
using FitCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitCore.Data.Migrations
{
    [DbContext(typeof(FitCoreDbContext))]
    [Migration("20190703221614_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitCore.Model.Training.CardioSession", b =>
                {
                    b.Property<int>("CardioSessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("WorkoutId");

                    b.HasKey("CardioSessionId");

                    b.ToTable("CardioSessions");
                });

            modelBuilder.Entity("FitCore.Model.Training.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SecondaryMuscleGroup")
                        .IsRequired();

                    b.Property<string>("TargetMuscleGroup")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitCore.Model.Training.ExerciseSets", b =>
                {
                    b.Property<int>("ExerciseSetsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExerciseId");

                    b.Property<int>("WorkoutId");

                    b.HasKey("ExerciseSetsId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("ExerciseSets");
                });

            modelBuilder.Entity("FitCore.Model.Training.Program", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AthleteId");

                    b.HasKey("ProgramId");

                    b.ToTable("WorkoutPrograms");
                });

            modelBuilder.Entity("FitCore.Model.Training.Set", b =>
                {
                    b.Property<int>("SetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExerciseSetsId");

                    b.HasKey("SetId");

                    b.HasIndex("ExerciseSetsId");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("FitCore.Model.Training.Workout", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AthleteId");

                    b.Property<int?>("ProgramId");

                    b.HasKey("WorkoutId");

                    b.HasIndex("AthleteId");

                    b.HasIndex("ProgramId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FitCore.Model.User.Athlete", b =>
                {
                    b.Property<int>("AthleteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("AthleteId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitCore.Model.Training.ExerciseSets", b =>
                {
                    b.HasOne("FitCore.Model.Training.Workout", null)
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitCore.Model.Training.Set", b =>
                {
                    b.HasOne("FitCore.Model.Training.ExerciseSets", null)
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseSetsId");
                });

            modelBuilder.Entity("FitCore.Model.Training.Workout", b =>
                {
                    b.HasOne("FitCore.Model.User.Athlete", null)
                        .WithMany("Workouts")
                        .HasForeignKey("AthleteId");

                    b.HasOne("FitCore.Model.Training.Program", null)
                        .WithMany("Workouts")
                        .HasForeignKey("ProgramId");
                });
#pragma warning restore 612, 618
        }
    }
}