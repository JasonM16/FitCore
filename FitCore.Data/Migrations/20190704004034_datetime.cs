using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitCore.Data.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DurationInMinutes",
                table: "Workouts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeRange",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProgramName",
                table: "WorkoutPrograms",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reps",
                table: "Set",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SetNumber",
                table: "Set",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Set",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationInMinutes",
                table: "CardioSessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSets_ExerciseId",
                table: "ExerciseSets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_CardioSessions_WorkoutId",
                table: "CardioSessions",
                column: "WorkoutId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CardioSessions_Workouts_WorkoutId",
                table: "CardioSessions",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSets_Exercises_ExerciseId",
                table: "ExerciseSets",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardioSessions_Workouts_WorkoutId",
                table: "CardioSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSets_Exercises_ExerciseId",
                table: "ExerciseSets");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseSets_ExerciseId",
                table: "ExerciseSets");

            migrationBuilder.DropIndex(
                name: "IX_CardioSessions_WorkoutId",
                table: "CardioSessions");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "DurationInMinutes",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "TimeRange",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "ProgramName",
                table: "WorkoutPrograms");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Reps",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "SetNumber",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "DurationInMinutes",
                table: "CardioSessions");
        }
    }
}
