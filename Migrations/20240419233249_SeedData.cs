using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamPlanner_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Rooms_RoomId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26bfc605-dab5-4925-88e3-c6f862db56af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35f5ff75-c156-4d8e-ae21-cef814980769");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "822a9478-0948-40a7-bef8-ac6c665b1b22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9cefcb0-c6e6-49f8-b058-d5eefd42b12a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da809682-0d16-4ff5-893d-56d2bed8f489");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelLevelId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelSpecialityId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelLevelId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SpecialityLevelSpecialityId",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Exams",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d1e553d-8688-4a30-b9fb-1ab882c6fb05", "25401ae5-c2b2-4fb2-9e88-308074db1f4d", "SuperAdmin", "SUPERADMIN" },
                    { "8186cd24-7dee-4284-a5b4-c7490f7a406e", "182b9767-489e-4a90-8b0e-c6c71d1298b6", "PrintingService", "PRINTINGSERVICE" },
                    { "d97dc0a7-edb2-4ce3-9415-3b951b29dc42", "a6a85f98-9154-4e5d-8ece-8ebad0cda5a5", "Teacher", "TEACHER" },
                    { "f30c7cbe-1f71-46dd-9618-6375d6d16ee2", "d75b5d23-3f9a-4c71-ac98-9a16276dcdab", "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "f692eb82-24a1-4400-9559-c2c0ef1c78e1", "421b1ce2-8755-4f6f-8563-de80727e488e", "Director", "DIRECTOR" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "Name" },
                values: new object[,]
                {
                    { 1, "First Year" },
                    { 2, "Second Year" },
                    { 3, "Third Year" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Name" },
                values: new object[,]
                {
                    { 1, "Room 101" },
                    { 2, "Room 102" },
                    { 3, "Room 103" },
                    { 4, "Room 104" },
                    { 5, "Room 201" },
                    { 6, "Room 202" },
                    { 7, "Room 203" },
                    { 8, "Room 204" },
                    { 9, "Room 301" },
                    { 10, "Room 302" },
                    { 11, "Room 303" },
                    { 12, "Room 304" },
                    { 13, "Room 401" },
                    { 14, "Room 402" },
                    { 15, "Room 403" },
                    { 16, "Room 404" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "SpecialityId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Computer Science" },
                    { 2, 2, "Software Engineering" },
                    { 3, 2, "Data Science" },
                    { 4, 2, "Web Development" },
                    { 5, 3, "Marketing" },
                    { 6, 3, "Finance" },
                    { 7, 3, "International Business" },
                    { 8, 4, "Mechanical Engineering" },
                    { 9, 4, "Electrical Engineering" },
                    { 10, 4, "Civil Engineering" }
                });

            migrationBuilder.InsertData(
                table: "SpecialityLevels",
                columns: new[] { "LevelId", "SpecialityId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 },
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 7 },
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 1, 9 },
                    { 2, 9 },
                    { 3, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "LevelId", "Name", "SpecialityId" },
                values: new object[,]
                {
                    { 1, 1, "Class A", 1 },
                    { 2, 1, "Class B", 1 },
                    { 3, 1, "Class C", 1 },
                    { 4, 2, "Class A", 1 },
                    { 5, 2, "Class B", 1 },
                    { 6, 2, "Class C", 1 },
                    { 7, 3, "Class A", 1 },
                    { 8, 3, "Class B", 1 },
                    { 9, 3, "Class C", 1 },
                    { 10, 1, "Class A", 2 },
                    { 11, 1, "Class B", 2 },
                    { 12, 1, "Class C", 2 },
                    { 13, 2, "Class A", 2 },
                    { 14, 2, "Class B", 2 },
                    { 15, 2, "Class C", 2 },
                    { 16, 3, "Class A", 2 },
                    { 17, 3, "Class B", 2 },
                    { 18, 3, "Class C", 2 },
                    { 19, 1, "Class A", 3 },
                    { 20, 1, "Class B", 3 },
                    { 21, 1, "Class C", 3 },
                    { 22, 2, "Class A", 3 },
                    { 23, 2, "Class B", 3 },
                    { 24, 2, "Class C", 3 },
                    { 25, 3, "Class A", 3 },
                    { 26, 3, "Class B", 3 },
                    { 27, 3, "Class C", 3 },
                    { 28, 1, "Class A", 4 },
                    { 29, 1, "Class B", 4 },
                    { 30, 1, "Class C", 4 },
                    { 31, 2, "Class A", 4 },
                    { 32, 2, "Class B", 4 },
                    { 33, 2, "Class C", 4 },
                    { 34, 3, "Class A", 4 },
                    { 35, 3, "Class B", 4 },
                    { 36, 3, "Class C", 4 },
                    { 37, 1, "Class A", 5 },
                    { 38, 1, "Class B", 5 },
                    { 39, 1, "Class C", 5 },
                    { 40, 2, "Class A", 5 },
                    { 41, 2, "Class B", 5 },
                    { 42, 2, "Class C", 5 },
                    { 43, 3, "Class A", 5 },
                    { 44, 3, "Class B", 5 },
                    { 45, 3, "Class C", 5 },
                    { 46, 1, "Class A", 6 },
                    { 47, 1, "Class B", 6 },
                    { 48, 1, "Class C", 6 },
                    { 49, 2, "Class A", 6 },
                    { 50, 2, "Class B", 6 },
                    { 51, 2, "Class C", 6 },
                    { 52, 3, "Class A", 6 },
                    { 53, 3, "Class B", 6 },
                    { 54, 3, "Class C", 6 },
                    { 55, 1, "Class A", 7 },
                    { 56, 1, "Class B", 7 },
                    { 57, 1, "Class C", 7 },
                    { 58, 2, "Class A", 7 },
                    { 59, 2, "Class B", 7 },
                    { 60, 2, "Class C", 7 },
                    { 61, 3, "Class A", 7 },
                    { 62, 3, "Class B", 7 },
                    { 63, 3, "Class C", 7 },
                    { 64, 1, "Class A", 8 },
                    { 65, 1, "Class B", 8 },
                    { 66, 1, "Class C", 8 },
                    { 67, 2, "Class A", 8 },
                    { 68, 2, "Class B", 8 },
                    { 69, 2, "Class C", 8 },
                    { 70, 3, "Class A", 8 },
                    { 71, 3, "Class B", 8 },
                    { 72, 3, "Class C", 8 },
                    { 73, 1, "Class A", 9 },
                    { 74, 1, "Class B", 9 },
                    { 75, 1, "Class C", 9 },
                    { 76, 2, "Class A", 9 },
                    { 77, 2, "Class B", 9 },
                    { 78, 2, "Class C", 9 },
                    { 79, 3, "Class A", 9 },
                    { 80, 3, "Class B", 9 },
                    { 81, 3, "Class C", 9 },
                    { 82, 1, "Class A", 10 },
                    { 83, 1, "Class B", 10 },
                    { 84, 1, "Class C", 10 },
                    { 85, 2, "Class A", 10 },
                    { 86, 2, "Class B", 10 },
                    { 87, 2, "Class C", 10 },
                    { 88, 3, "Class A", 10 },
                    { 89, 3, "Class B", 10 },
                    { 90, 3, "Class C", 10 }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "ExamId", "Date", "Duration", "LevelId", "Name", "SpecialityId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(4927), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 1", 1 },
                    { 2, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5004), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 2", 1 },
                    { 3, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5029), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 3", 1 },
                    { 4, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5050), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 4", 1 },
                    { 5, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5109), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 5", 1 },
                    { 6, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5136), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 6", 1 },
                    { 7, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5160), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 7", 1 },
                    { 8, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5183), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 8", 1 },
                    { 9, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5205), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 9", 1 },
                    { 10, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5231), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 10", 1 },
                    { 11, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5256), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 11", 1 },
                    { 12, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5278), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 12", 1 },
                    { 13, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5302), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 13", 1 },
                    { 14, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5324), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 14", 1 },
                    { 15, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5346), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 15", 1 },
                    { 16, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5369), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 16", 2 },
                    { 17, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5393), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 17", 2 },
                    { 18, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5416), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 18", 2 },
                    { 19, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5439), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 19", 2 },
                    { 20, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5464), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 20", 2 },
                    { 21, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5489), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 21", 2 },
                    { 22, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5511), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 22", 2 },
                    { 23, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5534), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 23", 2 },
                    { 24, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5556), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 24", 2 },
                    { 25, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5580), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 25", 2 },
                    { 26, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5603), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 26", 2 },
                    { 27, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5626), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 27", 2 },
                    { 28, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5684), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 28", 2 },
                    { 29, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5710), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 29", 2 },
                    { 30, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5735), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 30", 2 },
                    { 31, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5760), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 31", 3 },
                    { 32, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5783), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 32", 3 },
                    { 33, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5808), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 33", 3 },
                    { 34, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5834), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 34", 3 },
                    { 35, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5857), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 35", 3 },
                    { 36, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5882), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 36", 3 },
                    { 37, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5907), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 37", 3 },
                    { 38, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5929), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 38", 3 },
                    { 39, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5952), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 39", 3 },
                    { 40, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5977), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 40", 3 },
                    { 41, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6004), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 41", 3 },
                    { 42, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6028), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 42", 3 },
                    { 43, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6051), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 43", 3 },
                    { 44, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6074), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 44", 3 },
                    { 45, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6099), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 45", 3 },
                    { 46, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6121), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 46", 4 },
                    { 47, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6144), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 47", 4 },
                    { 48, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6166), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 48", 4 },
                    { 49, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6189), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 49", 4 },
                    { 50, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6210), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 50", 4 },
                    { 51, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6265), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 51", 4 },
                    { 52, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6292), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 52", 4 },
                    { 53, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6316), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 53", 4 },
                    { 54, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6340), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 54", 4 },
                    { 55, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6364), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 55", 4 },
                    { 56, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6386), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 56", 4 },
                    { 57, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6410), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 57", 4 },
                    { 58, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6432), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 58", 4 },
                    { 59, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6455), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 59", 4 },
                    { 60, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6478), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 60", 4 },
                    { 61, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6501), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 61", 5 },
                    { 62, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6526), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 62", 5 },
                    { 63, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6550), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 63", 5 },
                    { 64, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6572), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 64", 5 },
                    { 65, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6595), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 65", 5 },
                    { 66, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6620), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 66", 5 },
                    { 67, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6643), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 67", 5 },
                    { 68, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6667), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 68", 5 },
                    { 69, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6690), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 69", 5 },
                    { 70, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6713), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 70", 5 },
                    { 71, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6735), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 71", 5 },
                    { 72, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6758), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 72", 5 },
                    { 73, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6803), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 73", 5 },
                    { 74, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6827), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 74", 5 },
                    { 75, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6851), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 75", 5 },
                    { 76, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6876), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 76", 6 },
                    { 77, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6900), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 77", 6 },
                    { 78, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6924), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 78", 6 },
                    { 79, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6947), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 79", 6 },
                    { 80, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6968), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 80", 6 },
                    { 81, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6991), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 81", 6 },
                    { 82, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7015), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 82", 6 },
                    { 83, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7039), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 83", 6 },
                    { 84, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7062), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 84", 6 },
                    { 85, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7085), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 85", 6 },
                    { 86, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7108), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 86", 6 },
                    { 87, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7131), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 87", 6 },
                    { 88, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7151), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 88", 6 },
                    { 89, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7173), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 89", 6 },
                    { 90, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7195), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 90", 6 },
                    { 91, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7218), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 91", 7 },
                    { 92, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7240), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 92", 7 },
                    { 93, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7262), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 93", 7 },
                    { 94, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7285), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 94", 7 },
                    { 95, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7307), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 95", 7 },
                    { 96, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7331), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 96", 7 },
                    { 97, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7405), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 97", 7 },
                    { 98, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7432), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 98", 7 },
                    { 99, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7456), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 99", 7 },
                    { 100, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7480), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 100", 7 },
                    { 101, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7503), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 101", 7 },
                    { 102, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7526), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 102", 7 },
                    { 103, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7549), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 103", 7 },
                    { 104, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7573), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 104", 7 },
                    { 105, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7597), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 105", 7 },
                    { 106, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7622), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 106", 8 },
                    { 107, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7645), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 107", 8 },
                    { 108, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7669), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 108", 8 },
                    { 109, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7690), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 109", 8 },
                    { 110, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7713), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 110", 8 },
                    { 111, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7736), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 111", 8 },
                    { 112, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7758), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 112", 8 },
                    { 113, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7781), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 113", 8 },
                    { 114, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7806), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 114", 8 },
                    { 115, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7830), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 115", 8 },
                    { 116, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7853), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 116", 8 },
                    { 117, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7876), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 117", 8 },
                    { 118, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7898), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 118", 8 },
                    { 119, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7988), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 119", 8 },
                    { 120, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8014), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 120", 8 },
                    { 121, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8039), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 121", 9 },
                    { 122, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8120), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 122", 9 },
                    { 123, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8145), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 123", 9 },
                    { 124, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8168), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 124", 9 },
                    { 125, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8194), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 125", 9 },
                    { 126, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8218), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 126", 9 },
                    { 127, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8239), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 127", 9 },
                    { 128, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8262), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 128", 9 },
                    { 129, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8286), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 129", 9 },
                    { 130, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8311), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 130", 9 },
                    { 131, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8335), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 131", 9 },
                    { 132, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8358), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 132", 9 },
                    { 133, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8379), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 133", 9 },
                    { 134, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8403), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 134", 9 },
                    { 135, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8425), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 135", 9 },
                    { 136, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8447), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 136", 10 },
                    { 137, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8470), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 137", 10 },
                    { 138, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8493), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 138", 10 },
                    { 139, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8517), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 139", 10 },
                    { 140, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8539), new TimeSpan(0, 2, 0, 0, 0), 1, "Exam 140", 10 },
                    { 141, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8600), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 141", 10 },
                    { 142, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8625), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 142", 10 },
                    { 143, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8649), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 143", 10 },
                    { 144, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8673), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 144", 10 },
                    { 145, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8698), new TimeSpan(0, 2, 0, 0, 0), 2, "Exam 145", 10 },
                    { 146, new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8721), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 146", 10 },
                    { 147, new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8745), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 147", 10 },
                    { 148, new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8766), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 148", 10 },
                    { 149, new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8788), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 149", 10 },
                    { 150, new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8812), new TimeSpan(0, 2, 0, 0, 0), 3, "Exam 150", 10 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "ClassId", "Name", "RoomId" },
                values: new object[,]
                {
                    { 1, 1, "Group 1", 2 },
                    { 2, 1, "Group 2", 3 },
                    { 3, 2, "Group 1", 4 },
                    { 4, 2, "Group 2", 5 },
                    { 5, 3, "Group 1", 6 },
                    { 6, 3, "Group 2", 7 },
                    { 7, 4, "Group 1", 8 },
                    { 8, 4, "Group 2", 9 },
                    { 9, 5, "Group 1", 10 },
                    { 10, 5, "Group 2", 11 },
                    { 11, 6, "Group 1", 12 },
                    { 12, 6, "Group 2", 1 },
                    { 13, 7, "Group 1", 2 },
                    { 14, 7, "Group 2", 3 },
                    { 15, 8, "Group 1", 4 },
                    { 16, 8, "Group 2", 5 },
                    { 17, 9, "Group 1", 6 },
                    { 18, 9, "Group 2", 7 },
                    { 19, 10, "Group 1", 8 },
                    { 20, 10, "Group 2", 9 },
                    { 21, 11, "Group 1", 10 },
                    { 22, 11, "Group 2", 11 },
                    { 23, 12, "Group 1", 12 },
                    { 24, 12, "Group 2", 1 },
                    { 25, 13, "Group 1", 2 },
                    { 26, 13, "Group 2", 3 },
                    { 27, 14, "Group 1", 4 },
                    { 28, 14, "Group 2", 5 },
                    { 29, 15, "Group 1", 6 },
                    { 30, 15, "Group 2", 7 },
                    { 31, 16, "Group 1", 8 },
                    { 32, 16, "Group 2", 9 },
                    { 33, 17, "Group 1", 10 },
                    { 34, 17, "Group 2", 11 },
                    { 35, 18, "Group 1", 12 },
                    { 36, 18, "Group 2", 1 },
                    { 37, 19, "Group 1", 2 },
                    { 38, 19, "Group 2", 3 },
                    { 39, 20, "Group 1", 4 },
                    { 40, 20, "Group 2", 5 },
                    { 41, 21, "Group 1", 6 },
                    { 42, 21, "Group 2", 7 },
                    { 43, 22, "Group 1", 8 },
                    { 44, 22, "Group 2", 9 },
                    { 45, 23, "Group 1", 10 },
                    { 46, 23, "Group 2", 11 },
                    { 47, 24, "Group 1", 12 },
                    { 48, 24, "Group 2", 1 },
                    { 49, 25, "Group 1", 2 },
                    { 50, 25, "Group 2", 3 },
                    { 51, 26, "Group 1", 4 },
                    { 52, 26, "Group 2", 5 },
                    { 53, 27, "Group 1", 6 },
                    { 54, 27, "Group 2", 7 },
                    { 55, 28, "Group 1", 8 },
                    { 56, 28, "Group 2", 9 },
                    { 57, 29, "Group 1", 10 },
                    { 58, 29, "Group 2", 11 },
                    { 59, 30, "Group 1", 12 },
                    { 60, 30, "Group 2", 1 },
                    { 61, 31, "Group 1", 2 },
                    { 62, 31, "Group 2", 3 },
                    { 63, 32, "Group 1", 4 },
                    { 64, 32, "Group 2", 5 },
                    { 65, 33, "Group 1", 6 },
                    { 66, 33, "Group 2", 7 },
                    { 67, 34, "Group 1", 8 },
                    { 68, 34, "Group 2", 9 },
                    { 69, 35, "Group 1", 10 },
                    { 70, 35, "Group 2", 11 },
                    { 71, 36, "Group 1", 12 },
                    { 72, 36, "Group 2", 1 },
                    { 73, 37, "Group 1", 2 },
                    { 74, 37, "Group 2", 3 },
                    { 75, 38, "Group 1", 4 },
                    { 76, 38, "Group 2", 5 },
                    { 77, 39, "Group 1", 6 },
                    { 78, 39, "Group 2", 7 },
                    { 79, 40, "Group 1", 8 },
                    { 80, 40, "Group 2", 9 },
                    { 81, 41, "Group 1", 10 },
                    { 82, 41, "Group 2", 11 },
                    { 83, 42, "Group 1", 12 },
                    { 84, 42, "Group 2", 1 },
                    { 85, 43, "Group 1", 2 },
                    { 86, 43, "Group 2", 3 },
                    { 87, 44, "Group 1", 4 },
                    { 88, 44, "Group 2", 5 },
                    { 89, 45, "Group 1", 6 },
                    { 90, 45, "Group 2", 7 },
                    { 91, 46, "Group 1", 8 },
                    { 92, 46, "Group 2", 9 },
                    { 93, 47, "Group 1", 10 },
                    { 94, 47, "Group 2", 11 },
                    { 95, 48, "Group 1", 12 },
                    { 96, 48, "Group 2", 1 },
                    { 97, 49, "Group 1", 2 },
                    { 98, 49, "Group 2", 3 },
                    { 99, 50, "Group 1", 4 },
                    { 100, 50, "Group 2", 5 },
                    { 101, 51, "Group 1", 6 },
                    { 102, 51, "Group 2", 7 },
                    { 103, 52, "Group 1", 8 },
                    { 104, 52, "Group 2", 9 },
                    { 105, 53, "Group 1", 10 },
                    { 106, 53, "Group 2", 11 },
                    { 107, 54, "Group 1", 12 },
                    { 108, 54, "Group 2", 1 },
                    { 109, 55, "Group 1", 2 },
                    { 110, 55, "Group 2", 3 },
                    { 111, 56, "Group 1", 4 },
                    { 112, 56, "Group 2", 5 },
                    { 113, 57, "Group 1", 6 },
                    { 114, 57, "Group 2", 7 },
                    { 115, 58, "Group 1", 8 },
                    { 116, 58, "Group 2", 9 },
                    { 117, 59, "Group 1", 10 },
                    { 118, 59, "Group 2", 11 },
                    { 119, 60, "Group 1", 12 },
                    { 120, 60, "Group 2", 1 },
                    { 121, 61, "Group 1", 2 },
                    { 122, 61, "Group 2", 3 },
                    { 123, 62, "Group 1", 4 },
                    { 124, 62, "Group 2", 5 },
                    { 125, 63, "Group 1", 6 },
                    { 126, 63, "Group 2", 7 },
                    { 127, 64, "Group 1", 8 },
                    { 128, 64, "Group 2", 9 },
                    { 129, 65, "Group 1", 10 },
                    { 130, 65, "Group 2", 11 },
                    { 131, 66, "Group 1", 12 },
                    { 132, 66, "Group 2", 1 },
                    { 133, 67, "Group 1", 2 },
                    { 134, 67, "Group 2", 3 },
                    { 135, 68, "Group 1", 4 },
                    { 136, 68, "Group 2", 5 },
                    { 137, 69, "Group 1", 6 },
                    { 138, 69, "Group 2", 7 },
                    { 139, 70, "Group 1", 8 },
                    { 140, 70, "Group 2", 9 },
                    { 141, 71, "Group 1", 10 },
                    { 142, 71, "Group 2", 11 },
                    { 143, 72, "Group 1", 12 },
                    { 144, 72, "Group 2", 1 },
                    { 145, 73, "Group 1", 2 },
                    { 146, 73, "Group 2", 3 },
                    { 147, 74, "Group 1", 4 },
                    { 148, 74, "Group 2", 5 },
                    { 149, 75, "Group 1", 6 },
                    { 150, 75, "Group 2", 7 },
                    { 151, 76, "Group 1", 8 },
                    { 152, 76, "Group 2", 9 },
                    { 153, 77, "Group 1", 10 },
                    { 154, 77, "Group 2", 11 },
                    { 155, 78, "Group 1", 12 },
                    { 156, 78, "Group 2", 1 },
                    { 157, 79, "Group 1", 2 },
                    { 158, 79, "Group 2", 3 },
                    { 159, 80, "Group 1", 4 },
                    { 160, 80, "Group 2", 5 },
                    { 161, 81, "Group 1", 6 },
                    { 162, 81, "Group 2", 7 },
                    { 163, 82, "Group 1", 8 },
                    { 164, 82, "Group 2", 9 },
                    { 165, 83, "Group 1", 10 },
                    { 166, 83, "Group 2", 11 },
                    { 167, 84, "Group 1", 12 },
                    { 168, 84, "Group 2", 1 },
                    { 169, 85, "Group 1", 2 },
                    { 170, 85, "Group 2", 3 },
                    { 171, 86, "Group 1", 4 },
                    { 172, 86, "Group 2", 5 },
                    { 173, 87, "Group 1", 6 },
                    { 174, 87, "Group 2", 7 },
                    { 175, 88, "Group 1", 8 },
                    { 176, 88, "Group 2", 9 },
                    { 177, 89, "Group 1", 10 },
                    { 178, 89, "Group 2", 11 },
                    { 179, 90, "Group 1", 12 },
                    { 180, 90, "Group 2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, "Student1@mail.com", 1, "Student 1" },
                    { 2, "Student2@mail.com", 1, "Student 2" },
                    { 3, "Student3@mail.com", 1, "Student 3" },
                    { 4, "Student4@mail.com", 1, "Student 4" },
                    { 5, "Student5@mail.com", 1, "Student 5" },
                    { 6, "Student6@mail.com", 1, "Student 6" },
                    { 7, "Student7@mail.com", 1, "Student 7" },
                    { 8, "Student8@mail.com", 1, "Student 8" },
                    { 9, "Student9@mail.com", 1, "Student 9" },
                    { 10, "Student10@mail.com", 1, "Student 10" },
                    { 11, "Student11@mail.com", 1, "Student 11" },
                    { 12, "Student12@mail.com", 1, "Student 12" },
                    { 13, "Student13@mail.com", 1, "Student 13" },
                    { 14, "Student14@mail.com", 1, "Student 14" },
                    { 15, "Student15@mail.com", 1, "Student 15" },
                    { 16, "Student16@mail.com", 2, "Student 16" },
                    { 17, "Student17@mail.com", 2, "Student 17" },
                    { 18, "Student18@mail.com", 2, "Student 18" },
                    { 19, "Student19@mail.com", 2, "Student 19" },
                    { 20, "Student20@mail.com", 2, "Student 20" },
                    { 21, "Student21@mail.com", 2, "Student 21" },
                    { 22, "Student22@mail.com", 2, "Student 22" },
                    { 23, "Student23@mail.com", 2, "Student 23" },
                    { 24, "Student24@mail.com", 2, "Student 24" },
                    { 25, "Student25@mail.com", 2, "Student 25" },
                    { 26, "Student26@mail.com", 2, "Student 26" },
                    { 27, "Student27@mail.com", 2, "Student 27" },
                    { 28, "Student28@mail.com", 2, "Student 28" },
                    { 29, "Student29@mail.com", 2, "Student 29" },
                    { 30, "Student30@mail.com", 2, "Student 30" },
                    { 31, "Student31@mail.com", 3, "Student 31" },
                    { 32, "Student32@mail.com", 3, "Student 32" },
                    { 33, "Student33@mail.com", 3, "Student 33" },
                    { 34, "Student34@mail.com", 3, "Student 34" },
                    { 35, "Student35@mail.com", 3, "Student 35" },
                    { 36, "Student36@mail.com", 3, "Student 36" },
                    { 37, "Student37@mail.com", 3, "Student 37" },
                    { 38, "Student38@mail.com", 3, "Student 38" },
                    { 39, "Student39@mail.com", 3, "Student 39" },
                    { 40, "Student40@mail.com", 3, "Student 40" },
                    { 41, "Student41@mail.com", 3, "Student 41" },
                    { 42, "Student42@mail.com", 3, "Student 42" },
                    { 43, "Student43@mail.com", 3, "Student 43" },
                    { 44, "Student44@mail.com", 3, "Student 44" },
                    { 45, "Student45@mail.com", 3, "Student 45" },
                    { 46, "Student46@mail.com", 4, "Student 46" },
                    { 47, "Student47@mail.com", 4, "Student 47" },
                    { 48, "Student48@mail.com", 4, "Student 48" },
                    { 49, "Student49@mail.com", 4, "Student 49" },
                    { 50, "Student50@mail.com", 4, "Student 50" },
                    { 51, "Student51@mail.com", 4, "Student 51" },
                    { 52, "Student52@mail.com", 4, "Student 52" },
                    { 53, "Student53@mail.com", 4, "Student 53" },
                    { 54, "Student54@mail.com", 4, "Student 54" },
                    { 55, "Student55@mail.com", 4, "Student 55" },
                    { 56, "Student56@mail.com", 4, "Student 56" },
                    { 57, "Student57@mail.com", 4, "Student 57" },
                    { 58, "Student58@mail.com", 4, "Student 58" },
                    { 59, "Student59@mail.com", 4, "Student 59" },
                    { 60, "Student60@mail.com", 4, "Student 60" },
                    { 61, "Student61@mail.com", 5, "Student 61" },
                    { 62, "Student62@mail.com", 5, "Student 62" },
                    { 63, "Student63@mail.com", 5, "Student 63" },
                    { 64, "Student64@mail.com", 5, "Student 64" },
                    { 65, "Student65@mail.com", 5, "Student 65" },
                    { 66, "Student66@mail.com", 5, "Student 66" },
                    { 67, "Student67@mail.com", 5, "Student 67" },
                    { 68, "Student68@mail.com", 5, "Student 68" },
                    { 69, "Student69@mail.com", 5, "Student 69" },
                    { 70, "Student70@mail.com", 5, "Student 70" },
                    { 71, "Student71@mail.com", 5, "Student 71" },
                    { 72, "Student72@mail.com", 5, "Student 72" },
                    { 73, "Student73@mail.com", 5, "Student 73" },
                    { 74, "Student74@mail.com", 5, "Student 74" },
                    { 75, "Student75@mail.com", 5, "Student 75" },
                    { 76, "Student76@mail.com", 6, "Student 76" },
                    { 77, "Student77@mail.com", 6, "Student 77" },
                    { 78, "Student78@mail.com", 6, "Student 78" },
                    { 79, "Student79@mail.com", 6, "Student 79" },
                    { 80, "Student80@mail.com", 6, "Student 80" },
                    { 81, "Student81@mail.com", 6, "Student 81" },
                    { 82, "Student82@mail.com", 6, "Student 82" },
                    { 83, "Student83@mail.com", 6, "Student 83" },
                    { 84, "Student84@mail.com", 6, "Student 84" },
                    { 85, "Student85@mail.com", 6, "Student 85" },
                    { 86, "Student86@mail.com", 6, "Student 86" },
                    { 87, "Student87@mail.com", 6, "Student 87" },
                    { 88, "Student88@mail.com", 6, "Student 88" },
                    { 89, "Student89@mail.com", 6, "Student 89" },
                    { 90, "Student90@mail.com", 6, "Student 90" },
                    { 91, "Student91@mail.com", 7, "Student 91" },
                    { 92, "Student92@mail.com", 7, "Student 92" },
                    { 93, "Student93@mail.com", 7, "Student 93" },
                    { 94, "Student94@mail.com", 7, "Student 94" },
                    { 95, "Student95@mail.com", 7, "Student 95" },
                    { 96, "Student96@mail.com", 7, "Student 96" },
                    { 97, "Student97@mail.com", 7, "Student 97" },
                    { 98, "Student98@mail.com", 7, "Student 98" },
                    { 99, "Student99@mail.com", 7, "Student 99" },
                    { 100, "Student100@mail.com", 7, "Student 100" },
                    { 101, "Student101@mail.com", 7, "Student 101" },
                    { 102, "Student102@mail.com", 7, "Student 102" },
                    { 103, "Student103@mail.com", 7, "Student 103" },
                    { 104, "Student104@mail.com", 7, "Student 104" },
                    { 105, "Student105@mail.com", 7, "Student 105" },
                    { 106, "Student106@mail.com", 8, "Student 106" },
                    { 107, "Student107@mail.com", 8, "Student 107" },
                    { 108, "Student108@mail.com", 8, "Student 108" },
                    { 109, "Student109@mail.com", 8, "Student 109" },
                    { 110, "Student110@mail.com", 8, "Student 110" },
                    { 111, "Student111@mail.com", 8, "Student 111" },
                    { 112, "Student112@mail.com", 8, "Student 112" },
                    { 113, "Student113@mail.com", 8, "Student 113" },
                    { 114, "Student114@mail.com", 8, "Student 114" },
                    { 115, "Student115@mail.com", 8, "Student 115" },
                    { 116, "Student116@mail.com", 8, "Student 116" },
                    { 117, "Student117@mail.com", 8, "Student 117" },
                    { 118, "Student118@mail.com", 8, "Student 118" },
                    { 119, "Student119@mail.com", 8, "Student 119" },
                    { 120, "Student120@mail.com", 8, "Student 120" },
                    { 121, "Student121@mail.com", 9, "Student 121" },
                    { 122, "Student122@mail.com", 9, "Student 122" },
                    { 123, "Student123@mail.com", 9, "Student 123" },
                    { 124, "Student124@mail.com", 9, "Student 124" },
                    { 125, "Student125@mail.com", 9, "Student 125" },
                    { 126, "Student126@mail.com", 9, "Student 126" },
                    { 127, "Student127@mail.com", 9, "Student 127" },
                    { 128, "Student128@mail.com", 9, "Student 128" },
                    { 129, "Student129@mail.com", 9, "Student 129" },
                    { 130, "Student130@mail.com", 9, "Student 130" },
                    { 131, "Student131@mail.com", 9, "Student 131" },
                    { 132, "Student132@mail.com", 9, "Student 132" },
                    { 133, "Student133@mail.com", 9, "Student 133" },
                    { 134, "Student134@mail.com", 9, "Student 134" },
                    { 135, "Student135@mail.com", 9, "Student 135" },
                    { 136, "Student136@mail.com", 10, "Student 136" },
                    { 137, "Student137@mail.com", 10, "Student 137" },
                    { 138, "Student138@mail.com", 10, "Student 138" },
                    { 139, "Student139@mail.com", 10, "Student 139" },
                    { 140, "Student140@mail.com", 10, "Student 140" },
                    { 141, "Student141@mail.com", 10, "Student 141" },
                    { 142, "Student142@mail.com", 10, "Student 142" },
                    { 143, "Student143@mail.com", 10, "Student 143" },
                    { 144, "Student144@mail.com", 10, "Student 144" },
                    { 145, "Student145@mail.com", 10, "Student 145" },
                    { 146, "Student146@mail.com", 10, "Student 146" },
                    { 147, "Student147@mail.com", 10, "Student 147" },
                    { 148, "Student148@mail.com", 10, "Student 148" },
                    { 149, "Student149@mail.com", 10, "Student 149" },
                    { 150, "Student150@mail.com", 10, "Student 150" },
                    { 151, "Student151@mail.com", 11, "Student 151" },
                    { 152, "Student152@mail.com", 11, "Student 152" },
                    { 153, "Student153@mail.com", 11, "Student 153" },
                    { 154, "Student154@mail.com", 11, "Student 154" },
                    { 155, "Student155@mail.com", 11, "Student 155" },
                    { 156, "Student156@mail.com", 11, "Student 156" },
                    { 157, "Student157@mail.com", 11, "Student 157" },
                    { 158, "Student158@mail.com", 11, "Student 158" },
                    { 159, "Student159@mail.com", 11, "Student 159" },
                    { 160, "Student160@mail.com", 11, "Student 160" },
                    { 161, "Student161@mail.com", 11, "Student 161" },
                    { 162, "Student162@mail.com", 11, "Student 162" },
                    { 163, "Student163@mail.com", 11, "Student 163" },
                    { 164, "Student164@mail.com", 11, "Student 164" },
                    { 165, "Student165@mail.com", 11, "Student 165" },
                    { 166, "Student166@mail.com", 12, "Student 166" },
                    { 167, "Student167@mail.com", 12, "Student 167" },
                    { 168, "Student168@mail.com", 12, "Student 168" },
                    { 169, "Student169@mail.com", 12, "Student 169" },
                    { 170, "Student170@mail.com", 12, "Student 170" },
                    { 171, "Student171@mail.com", 12, "Student 171" },
                    { 172, "Student172@mail.com", 12, "Student 172" },
                    { 173, "Student173@mail.com", 12, "Student 173" },
                    { 174, "Student174@mail.com", 12, "Student 174" },
                    { 175, "Student175@mail.com", 12, "Student 175" },
                    { 176, "Student176@mail.com", 12, "Student 176" },
                    { 177, "Student177@mail.com", 12, "Student 177" },
                    { 178, "Student178@mail.com", 12, "Student 178" },
                    { 179, "Student179@mail.com", 12, "Student 179" },
                    { 180, "Student180@mail.com", 12, "Student 180" },
                    { 181, "Student181@mail.com", 13, "Student 181" },
                    { 182, "Student182@mail.com", 13, "Student 182" },
                    { 183, "Student183@mail.com", 13, "Student 183" },
                    { 184, "Student184@mail.com", 13, "Student 184" },
                    { 185, "Student185@mail.com", 13, "Student 185" },
                    { 186, "Student186@mail.com", 13, "Student 186" },
                    { 187, "Student187@mail.com", 13, "Student 187" },
                    { 188, "Student188@mail.com", 13, "Student 188" },
                    { 189, "Student189@mail.com", 13, "Student 189" },
                    { 190, "Student190@mail.com", 13, "Student 190" },
                    { 191, "Student191@mail.com", 13, "Student 191" },
                    { 192, "Student192@mail.com", 13, "Student 192" },
                    { 193, "Student193@mail.com", 13, "Student 193" },
                    { 194, "Student194@mail.com", 13, "Student 194" },
                    { 195, "Student195@mail.com", 13, "Student 195" },
                    { 196, "Student196@mail.com", 14, "Student 196" },
                    { 197, "Student197@mail.com", 14, "Student 197" },
                    { 198, "Student198@mail.com", 14, "Student 198" },
                    { 199, "Student199@mail.com", 14, "Student 199" },
                    { 200, "Student200@mail.com", 14, "Student 200" },
                    { 201, "Student201@mail.com", 14, "Student 201" },
                    { 202, "Student202@mail.com", 14, "Student 202" },
                    { 203, "Student203@mail.com", 14, "Student 203" },
                    { 204, "Student204@mail.com", 14, "Student 204" },
                    { 205, "Student205@mail.com", 14, "Student 205" },
                    { 206, "Student206@mail.com", 14, "Student 206" },
                    { 207, "Student207@mail.com", 14, "Student 207" },
                    { 208, "Student208@mail.com", 14, "Student 208" },
                    { 209, "Student209@mail.com", 14, "Student 209" },
                    { 210, "Student210@mail.com", 14, "Student 210" },
                    { 211, "Student211@mail.com", 15, "Student 211" },
                    { 212, "Student212@mail.com", 15, "Student 212" },
                    { 213, "Student213@mail.com", 15, "Student 213" },
                    { 214, "Student214@mail.com", 15, "Student 214" },
                    { 215, "Student215@mail.com", 15, "Student 215" },
                    { 216, "Student216@mail.com", 15, "Student 216" },
                    { 217, "Student217@mail.com", 15, "Student 217" },
                    { 218, "Student218@mail.com", 15, "Student 218" },
                    { 219, "Student219@mail.com", 15, "Student 219" },
                    { 220, "Student220@mail.com", 15, "Student 220" },
                    { 221, "Student221@mail.com", 15, "Student 221" },
                    { 222, "Student222@mail.com", 15, "Student 222" },
                    { 223, "Student223@mail.com", 15, "Student 223" },
                    { 224, "Student224@mail.com", 15, "Student 224" },
                    { 225, "Student225@mail.com", 15, "Student 225" },
                    { 226, "Student226@mail.com", 16, "Student 226" },
                    { 227, "Student227@mail.com", 16, "Student 227" },
                    { 228, "Student228@mail.com", 16, "Student 228" },
                    { 229, "Student229@mail.com", 16, "Student 229" },
                    { 230, "Student230@mail.com", 16, "Student 230" },
                    { 231, "Student231@mail.com", 16, "Student 231" },
                    { 232, "Student232@mail.com", 16, "Student 232" },
                    { 233, "Student233@mail.com", 16, "Student 233" },
                    { 234, "Student234@mail.com", 16, "Student 234" },
                    { 235, "Student235@mail.com", 16, "Student 235" },
                    { 236, "Student236@mail.com", 16, "Student 236" },
                    { 237, "Student237@mail.com", 16, "Student 237" },
                    { 238, "Student238@mail.com", 16, "Student 238" },
                    { 239, "Student239@mail.com", 16, "Student 239" },
                    { 240, "Student240@mail.com", 16, "Student 240" },
                    { 241, "Student241@mail.com", 17, "Student 241" },
                    { 242, "Student242@mail.com", 17, "Student 242" },
                    { 243, "Student243@mail.com", 17, "Student 243" },
                    { 244, "Student244@mail.com", 17, "Student 244" },
                    { 245, "Student245@mail.com", 17, "Student 245" },
                    { 246, "Student246@mail.com", 17, "Student 246" },
                    { 247, "Student247@mail.com", 17, "Student 247" },
                    { 248, "Student248@mail.com", 17, "Student 248" },
                    { 249, "Student249@mail.com", 17, "Student 249" },
                    { 250, "Student250@mail.com", 17, "Student 250" },
                    { 251, "Student251@mail.com", 17, "Student 251" },
                    { 252, "Student252@mail.com", 17, "Student 252" },
                    { 253, "Student253@mail.com", 17, "Student 253" },
                    { 254, "Student254@mail.com", 17, "Student 254" },
                    { 255, "Student255@mail.com", 17, "Student 255" },
                    { 256, "Student256@mail.com", 18, "Student 256" },
                    { 257, "Student257@mail.com", 18, "Student 257" },
                    { 258, "Student258@mail.com", 18, "Student 258" },
                    { 259, "Student259@mail.com", 18, "Student 259" },
                    { 260, "Student260@mail.com", 18, "Student 260" },
                    { 261, "Student261@mail.com", 18, "Student 261" },
                    { 262, "Student262@mail.com", 18, "Student 262" },
                    { 263, "Student263@mail.com", 18, "Student 263" },
                    { 264, "Student264@mail.com", 18, "Student 264" },
                    { 265, "Student265@mail.com", 18, "Student 265" },
                    { 266, "Student266@mail.com", 18, "Student 266" },
                    { 267, "Student267@mail.com", 18, "Student 267" },
                    { 268, "Student268@mail.com", 18, "Student 268" },
                    { 269, "Student269@mail.com", 18, "Student 269" },
                    { 270, "Student270@mail.com", 18, "Student 270" },
                    { 271, "Student271@mail.com", 19, "Student 271" },
                    { 272, "Student272@mail.com", 19, "Student 272" },
                    { 273, "Student273@mail.com", 19, "Student 273" },
                    { 274, "Student274@mail.com", 19, "Student 274" },
                    { 275, "Student275@mail.com", 19, "Student 275" },
                    { 276, "Student276@mail.com", 19, "Student 276" },
                    { 277, "Student277@mail.com", 19, "Student 277" },
                    { 278, "Student278@mail.com", 19, "Student 278" },
                    { 279, "Student279@mail.com", 19, "Student 279" },
                    { 280, "Student280@mail.com", 19, "Student 280" },
                    { 281, "Student281@mail.com", 19, "Student 281" },
                    { 282, "Student282@mail.com", 19, "Student 282" },
                    { 283, "Student283@mail.com", 19, "Student 283" },
                    { 284, "Student284@mail.com", 19, "Student 284" },
                    { 285, "Student285@mail.com", 19, "Student 285" },
                    { 286, "Student286@mail.com", 20, "Student 286" },
                    { 287, "Student287@mail.com", 20, "Student 287" },
                    { 288, "Student288@mail.com", 20, "Student 288" },
                    { 289, "Student289@mail.com", 20, "Student 289" },
                    { 290, "Student290@mail.com", 20, "Student 290" },
                    { 291, "Student291@mail.com", 20, "Student 291" },
                    { 292, "Student292@mail.com", 20, "Student 292" },
                    { 293, "Student293@mail.com", 20, "Student 293" },
                    { 294, "Student294@mail.com", 20, "Student 294" },
                    { 295, "Student295@mail.com", 20, "Student 295" },
                    { 296, "Student296@mail.com", 20, "Student 296" },
                    { 297, "Student297@mail.com", 20, "Student 297" },
                    { 298, "Student298@mail.com", 20, "Student 298" },
                    { 299, "Student299@mail.com", 20, "Student 299" },
                    { 300, "Student300@mail.com", 20, "Student 300" },
                    { 301, "Student301@mail.com", 21, "Student 301" },
                    { 302, "Student302@mail.com", 21, "Student 302" },
                    { 303, "Student303@mail.com", 21, "Student 303" },
                    { 304, "Student304@mail.com", 21, "Student 304" },
                    { 305, "Student305@mail.com", 21, "Student 305" },
                    { 306, "Student306@mail.com", 21, "Student 306" },
                    { 307, "Student307@mail.com", 21, "Student 307" },
                    { 308, "Student308@mail.com", 21, "Student 308" },
                    { 309, "Student309@mail.com", 21, "Student 309" },
                    { 310, "Student310@mail.com", 21, "Student 310" },
                    { 311, "Student311@mail.com", 21, "Student 311" },
                    { 312, "Student312@mail.com", 21, "Student 312" },
                    { 313, "Student313@mail.com", 21, "Student 313" },
                    { 314, "Student314@mail.com", 21, "Student 314" },
                    { 315, "Student315@mail.com", 21, "Student 315" },
                    { 316, "Student316@mail.com", 22, "Student 316" },
                    { 317, "Student317@mail.com", 22, "Student 317" },
                    { 318, "Student318@mail.com", 22, "Student 318" },
                    { 319, "Student319@mail.com", 22, "Student 319" },
                    { 320, "Student320@mail.com", 22, "Student 320" },
                    { 321, "Student321@mail.com", 22, "Student 321" },
                    { 322, "Student322@mail.com", 22, "Student 322" },
                    { 323, "Student323@mail.com", 22, "Student 323" },
                    { 324, "Student324@mail.com", 22, "Student 324" },
                    { 325, "Student325@mail.com", 22, "Student 325" },
                    { 326, "Student326@mail.com", 22, "Student 326" },
                    { 327, "Student327@mail.com", 22, "Student 327" },
                    { 328, "Student328@mail.com", 22, "Student 328" },
                    { 329, "Student329@mail.com", 22, "Student 329" },
                    { 330, "Student330@mail.com", 22, "Student 330" },
                    { 331, "Student331@mail.com", 23, "Student 331" },
                    { 332, "Student332@mail.com", 23, "Student 332" },
                    { 333, "Student333@mail.com", 23, "Student 333" },
                    { 334, "Student334@mail.com", 23, "Student 334" },
                    { 335, "Student335@mail.com", 23, "Student 335" },
                    { 336, "Student336@mail.com", 23, "Student 336" },
                    { 337, "Student337@mail.com", 23, "Student 337" },
                    { 338, "Student338@mail.com", 23, "Student 338" },
                    { 339, "Student339@mail.com", 23, "Student 339" },
                    { 340, "Student340@mail.com", 23, "Student 340" },
                    { 341, "Student341@mail.com", 23, "Student 341" },
                    { 342, "Student342@mail.com", 23, "Student 342" },
                    { 343, "Student343@mail.com", 23, "Student 343" },
                    { 344, "Student344@mail.com", 23, "Student 344" },
                    { 345, "Student345@mail.com", 23, "Student 345" },
                    { 346, "Student346@mail.com", 24, "Student 346" },
                    { 347, "Student347@mail.com", 24, "Student 347" },
                    { 348, "Student348@mail.com", 24, "Student 348" },
                    { 349, "Student349@mail.com", 24, "Student 349" },
                    { 350, "Student350@mail.com", 24, "Student 350" },
                    { 351, "Student351@mail.com", 24, "Student 351" },
                    { 352, "Student352@mail.com", 24, "Student 352" },
                    { 353, "Student353@mail.com", 24, "Student 353" },
                    { 354, "Student354@mail.com", 24, "Student 354" },
                    { 355, "Student355@mail.com", 24, "Student 355" },
                    { 356, "Student356@mail.com", 24, "Student 356" },
                    { 357, "Student357@mail.com", 24, "Student 357" },
                    { 358, "Student358@mail.com", 24, "Student 358" },
                    { 359, "Student359@mail.com", 24, "Student 359" },
                    { 360, "Student360@mail.com", 24, "Student 360" },
                    { 361, "Student361@mail.com", 25, "Student 361" },
                    { 362, "Student362@mail.com", 25, "Student 362" },
                    { 363, "Student363@mail.com", 25, "Student 363" },
                    { 364, "Student364@mail.com", 25, "Student 364" },
                    { 365, "Student365@mail.com", 25, "Student 365" },
                    { 366, "Student366@mail.com", 25, "Student 366" },
                    { 367, "Student367@mail.com", 25, "Student 367" },
                    { 368, "Student368@mail.com", 25, "Student 368" },
                    { 369, "Student369@mail.com", 25, "Student 369" },
                    { 370, "Student370@mail.com", 25, "Student 370" },
                    { 371, "Student371@mail.com", 25, "Student 371" },
                    { 372, "Student372@mail.com", 25, "Student 372" },
                    { 373, "Student373@mail.com", 25, "Student 373" },
                    { 374, "Student374@mail.com", 25, "Student 374" },
                    { 375, "Student375@mail.com", 25, "Student 375" },
                    { 376, "Student376@mail.com", 26, "Student 376" },
                    { 377, "Student377@mail.com", 26, "Student 377" },
                    { 378, "Student378@mail.com", 26, "Student 378" },
                    { 379, "Student379@mail.com", 26, "Student 379" },
                    { 380, "Student380@mail.com", 26, "Student 380" },
                    { 381, "Student381@mail.com", 26, "Student 381" },
                    { 382, "Student382@mail.com", 26, "Student 382" },
                    { 383, "Student383@mail.com", 26, "Student 383" },
                    { 384, "Student384@mail.com", 26, "Student 384" },
                    { 385, "Student385@mail.com", 26, "Student 385" },
                    { 386, "Student386@mail.com", 26, "Student 386" },
                    { 387, "Student387@mail.com", 26, "Student 387" },
                    { 388, "Student388@mail.com", 26, "Student 388" },
                    { 389, "Student389@mail.com", 26, "Student 389" },
                    { 390, "Student390@mail.com", 26, "Student 390" },
                    { 391, "Student391@mail.com", 27, "Student 391" },
                    { 392, "Student392@mail.com", 27, "Student 392" },
                    { 393, "Student393@mail.com", 27, "Student 393" },
                    { 394, "Student394@mail.com", 27, "Student 394" },
                    { 395, "Student395@mail.com", 27, "Student 395" },
                    { 396, "Student396@mail.com", 27, "Student 396" },
                    { 397, "Student397@mail.com", 27, "Student 397" },
                    { 398, "Student398@mail.com", 27, "Student 398" },
                    { 399, "Student399@mail.com", 27, "Student 399" },
                    { 400, "Student400@mail.com", 27, "Student 400" },
                    { 401, "Student401@mail.com", 27, "Student 401" },
                    { 402, "Student402@mail.com", 27, "Student 402" },
                    { 403, "Student403@mail.com", 27, "Student 403" },
                    { 404, "Student404@mail.com", 27, "Student 404" },
                    { 405, "Student405@mail.com", 27, "Student 405" },
                    { 406, "Student406@mail.com", 28, "Student 406" },
                    { 407, "Student407@mail.com", 28, "Student 407" },
                    { 408, "Student408@mail.com", 28, "Student 408" },
                    { 409, "Student409@mail.com", 28, "Student 409" },
                    { 410, "Student410@mail.com", 28, "Student 410" },
                    { 411, "Student411@mail.com", 28, "Student 411" },
                    { 412, "Student412@mail.com", 28, "Student 412" },
                    { 413, "Student413@mail.com", 28, "Student 413" },
                    { 414, "Student414@mail.com", 28, "Student 414" },
                    { 415, "Student415@mail.com", 28, "Student 415" },
                    { 416, "Student416@mail.com", 28, "Student 416" },
                    { 417, "Student417@mail.com", 28, "Student 417" },
                    { 418, "Student418@mail.com", 28, "Student 418" },
                    { 419, "Student419@mail.com", 28, "Student 419" },
                    { 420, "Student420@mail.com", 28, "Student 420" },
                    { 421, "Student421@mail.com", 29, "Student 421" },
                    { 422, "Student422@mail.com", 29, "Student 422" },
                    { 423, "Student423@mail.com", 29, "Student 423" },
                    { 424, "Student424@mail.com", 29, "Student 424" },
                    { 425, "Student425@mail.com", 29, "Student 425" },
                    { 426, "Student426@mail.com", 29, "Student 426" },
                    { 427, "Student427@mail.com", 29, "Student 427" },
                    { 428, "Student428@mail.com", 29, "Student 428" },
                    { 429, "Student429@mail.com", 29, "Student 429" },
                    { 430, "Student430@mail.com", 29, "Student 430" },
                    { 431, "Student431@mail.com", 29, "Student 431" },
                    { 432, "Student432@mail.com", 29, "Student 432" },
                    { 433, "Student433@mail.com", 29, "Student 433" },
                    { 434, "Student434@mail.com", 29, "Student 434" },
                    { 435, "Student435@mail.com", 29, "Student 435" },
                    { 436, "Student436@mail.com", 30, "Student 436" },
                    { 437, "Student437@mail.com", 30, "Student 437" },
                    { 438, "Student438@mail.com", 30, "Student 438" },
                    { 439, "Student439@mail.com", 30, "Student 439" },
                    { 440, "Student440@mail.com", 30, "Student 440" },
                    { 441, "Student441@mail.com", 30, "Student 441" },
                    { 442, "Student442@mail.com", 30, "Student 442" },
                    { 443, "Student443@mail.com", 30, "Student 443" },
                    { 444, "Student444@mail.com", 30, "Student 444" },
                    { 445, "Student445@mail.com", 30, "Student 445" },
                    { 446, "Student446@mail.com", 30, "Student 446" },
                    { 447, "Student447@mail.com", 30, "Student 447" },
                    { 448, "Student448@mail.com", 30, "Student 448" },
                    { 449, "Student449@mail.com", 30, "Student 449" },
                    { 450, "Student450@mail.com", 30, "Student 450" },
                    { 451, "Student451@mail.com", 31, "Student 451" },
                    { 452, "Student452@mail.com", 31, "Student 452" },
                    { 453, "Student453@mail.com", 31, "Student 453" },
                    { 454, "Student454@mail.com", 31, "Student 454" },
                    { 455, "Student455@mail.com", 31, "Student 455" },
                    { 456, "Student456@mail.com", 31, "Student 456" },
                    { 457, "Student457@mail.com", 31, "Student 457" },
                    { 458, "Student458@mail.com", 31, "Student 458" },
                    { 459, "Student459@mail.com", 31, "Student 459" },
                    { 460, "Student460@mail.com", 31, "Student 460" },
                    { 461, "Student461@mail.com", 31, "Student 461" },
                    { 462, "Student462@mail.com", 31, "Student 462" },
                    { 463, "Student463@mail.com", 31, "Student 463" },
                    { 464, "Student464@mail.com", 31, "Student 464" },
                    { 465, "Student465@mail.com", 31, "Student 465" },
                    { 466, "Student466@mail.com", 32, "Student 466" },
                    { 467, "Student467@mail.com", 32, "Student 467" },
                    { 468, "Student468@mail.com", 32, "Student 468" },
                    { 469, "Student469@mail.com", 32, "Student 469" },
                    { 470, "Student470@mail.com", 32, "Student 470" },
                    { 471, "Student471@mail.com", 32, "Student 471" },
                    { 472, "Student472@mail.com", 32, "Student 472" },
                    { 473, "Student473@mail.com", 32, "Student 473" },
                    { 474, "Student474@mail.com", 32, "Student 474" },
                    { 475, "Student475@mail.com", 32, "Student 475" },
                    { 476, "Student476@mail.com", 32, "Student 476" },
                    { 477, "Student477@mail.com", 32, "Student 477" },
                    { 478, "Student478@mail.com", 32, "Student 478" },
                    { 479, "Student479@mail.com", 32, "Student 479" },
                    { 480, "Student480@mail.com", 32, "Student 480" },
                    { 481, "Student481@mail.com", 33, "Student 481" },
                    { 482, "Student482@mail.com", 33, "Student 482" },
                    { 483, "Student483@mail.com", 33, "Student 483" },
                    { 484, "Student484@mail.com", 33, "Student 484" },
                    { 485, "Student485@mail.com", 33, "Student 485" },
                    { 486, "Student486@mail.com", 33, "Student 486" },
                    { 487, "Student487@mail.com", 33, "Student 487" },
                    { 488, "Student488@mail.com", 33, "Student 488" },
                    { 489, "Student489@mail.com", 33, "Student 489" },
                    { 490, "Student490@mail.com", 33, "Student 490" },
                    { 491, "Student491@mail.com", 33, "Student 491" },
                    { 492, "Student492@mail.com", 33, "Student 492" },
                    { 493, "Student493@mail.com", 33, "Student 493" },
                    { 494, "Student494@mail.com", 33, "Student 494" },
                    { 495, "Student495@mail.com", 33, "Student 495" },
                    { 496, "Student496@mail.com", 34, "Student 496" },
                    { 497, "Student497@mail.com", 34, "Student 497" },
                    { 498, "Student498@mail.com", 34, "Student 498" },
                    { 499, "Student499@mail.com", 34, "Student 499" },
                    { 500, "Student500@mail.com", 34, "Student 500" },
                    { 501, "Student501@mail.com", 34, "Student 501" },
                    { 502, "Student502@mail.com", 34, "Student 502" },
                    { 503, "Student503@mail.com", 34, "Student 503" },
                    { 504, "Student504@mail.com", 34, "Student 504" },
                    { 505, "Student505@mail.com", 34, "Student 505" },
                    { 506, "Student506@mail.com", 34, "Student 506" },
                    { 507, "Student507@mail.com", 34, "Student 507" },
                    { 508, "Student508@mail.com", 34, "Student 508" },
                    { 509, "Student509@mail.com", 34, "Student 509" },
                    { 510, "Student510@mail.com", 34, "Student 510" },
                    { 511, "Student511@mail.com", 35, "Student 511" },
                    { 512, "Student512@mail.com", 35, "Student 512" },
                    { 513, "Student513@mail.com", 35, "Student 513" },
                    { 514, "Student514@mail.com", 35, "Student 514" },
                    { 515, "Student515@mail.com", 35, "Student 515" },
                    { 516, "Student516@mail.com", 35, "Student 516" },
                    { 517, "Student517@mail.com", 35, "Student 517" },
                    { 518, "Student518@mail.com", 35, "Student 518" },
                    { 519, "Student519@mail.com", 35, "Student 519" },
                    { 520, "Student520@mail.com", 35, "Student 520" },
                    { 521, "Student521@mail.com", 35, "Student 521" },
                    { 522, "Student522@mail.com", 35, "Student 522" },
                    { 523, "Student523@mail.com", 35, "Student 523" },
                    { 524, "Student524@mail.com", 35, "Student 524" },
                    { 525, "Student525@mail.com", 35, "Student 525" },
                    { 526, "Student526@mail.com", 36, "Student 526" },
                    { 527, "Student527@mail.com", 36, "Student 527" },
                    { 528, "Student528@mail.com", 36, "Student 528" },
                    { 529, "Student529@mail.com", 36, "Student 529" },
                    { 530, "Student530@mail.com", 36, "Student 530" },
                    { 531, "Student531@mail.com", 36, "Student 531" },
                    { 532, "Student532@mail.com", 36, "Student 532" },
                    { 533, "Student533@mail.com", 36, "Student 533" },
                    { 534, "Student534@mail.com", 36, "Student 534" },
                    { 535, "Student535@mail.com", 36, "Student 535" },
                    { 536, "Student536@mail.com", 36, "Student 536" },
                    { 537, "Student537@mail.com", 36, "Student 537" },
                    { 538, "Student538@mail.com", 36, "Student 538" },
                    { 539, "Student539@mail.com", 36, "Student 539" },
                    { 540, "Student540@mail.com", 36, "Student 540" },
                    { 541, "Student541@mail.com", 37, "Student 541" },
                    { 542, "Student542@mail.com", 37, "Student 542" },
                    { 543, "Student543@mail.com", 37, "Student 543" },
                    { 544, "Student544@mail.com", 37, "Student 544" },
                    { 545, "Student545@mail.com", 37, "Student 545" },
                    { 546, "Student546@mail.com", 37, "Student 546" },
                    { 547, "Student547@mail.com", 37, "Student 547" },
                    { 548, "Student548@mail.com", 37, "Student 548" },
                    { 549, "Student549@mail.com", 37, "Student 549" },
                    { 550, "Student550@mail.com", 37, "Student 550" },
                    { 551, "Student551@mail.com", 37, "Student 551" },
                    { 552, "Student552@mail.com", 37, "Student 552" },
                    { 553, "Student553@mail.com", 37, "Student 553" },
                    { 554, "Student554@mail.com", 37, "Student 554" },
                    { 555, "Student555@mail.com", 37, "Student 555" },
                    { 556, "Student556@mail.com", 38, "Student 556" },
                    { 557, "Student557@mail.com", 38, "Student 557" },
                    { 558, "Student558@mail.com", 38, "Student 558" },
                    { 559, "Student559@mail.com", 38, "Student 559" },
                    { 560, "Student560@mail.com", 38, "Student 560" },
                    { 561, "Student561@mail.com", 38, "Student 561" },
                    { 562, "Student562@mail.com", 38, "Student 562" },
                    { 563, "Student563@mail.com", 38, "Student 563" },
                    { 564, "Student564@mail.com", 38, "Student 564" },
                    { 565, "Student565@mail.com", 38, "Student 565" },
                    { 566, "Student566@mail.com", 38, "Student 566" },
                    { 567, "Student567@mail.com", 38, "Student 567" },
                    { 568, "Student568@mail.com", 38, "Student 568" },
                    { 569, "Student569@mail.com", 38, "Student 569" },
                    { 570, "Student570@mail.com", 38, "Student 570" },
                    { 571, "Student571@mail.com", 39, "Student 571" },
                    { 572, "Student572@mail.com", 39, "Student 572" },
                    { 573, "Student573@mail.com", 39, "Student 573" },
                    { 574, "Student574@mail.com", 39, "Student 574" },
                    { 575, "Student575@mail.com", 39, "Student 575" },
                    { 576, "Student576@mail.com", 39, "Student 576" },
                    { 577, "Student577@mail.com", 39, "Student 577" },
                    { 578, "Student578@mail.com", 39, "Student 578" },
                    { 579, "Student579@mail.com", 39, "Student 579" },
                    { 580, "Student580@mail.com", 39, "Student 580" },
                    { 581, "Student581@mail.com", 39, "Student 581" },
                    { 582, "Student582@mail.com", 39, "Student 582" },
                    { 583, "Student583@mail.com", 39, "Student 583" },
                    { 584, "Student584@mail.com", 39, "Student 584" },
                    { 585, "Student585@mail.com", 39, "Student 585" },
                    { 586, "Student586@mail.com", 40, "Student 586" },
                    { 587, "Student587@mail.com", 40, "Student 587" },
                    { 588, "Student588@mail.com", 40, "Student 588" },
                    { 589, "Student589@mail.com", 40, "Student 589" },
                    { 590, "Student590@mail.com", 40, "Student 590" },
                    { 591, "Student591@mail.com", 40, "Student 591" },
                    { 592, "Student592@mail.com", 40, "Student 592" },
                    { 593, "Student593@mail.com", 40, "Student 593" },
                    { 594, "Student594@mail.com", 40, "Student 594" },
                    { 595, "Student595@mail.com", 40, "Student 595" },
                    { 596, "Student596@mail.com", 40, "Student 596" },
                    { 597, "Student597@mail.com", 40, "Student 597" },
                    { 598, "Student598@mail.com", 40, "Student 598" },
                    { 599, "Student599@mail.com", 40, "Student 599" },
                    { 600, "Student600@mail.com", 40, "Student 600" },
                    { 601, "Student601@mail.com", 41, "Student 601" },
                    { 602, "Student602@mail.com", 41, "Student 602" },
                    { 603, "Student603@mail.com", 41, "Student 603" },
                    { 604, "Student604@mail.com", 41, "Student 604" },
                    { 605, "Student605@mail.com", 41, "Student 605" },
                    { 606, "Student606@mail.com", 41, "Student 606" },
                    { 607, "Student607@mail.com", 41, "Student 607" },
                    { 608, "Student608@mail.com", 41, "Student 608" },
                    { 609, "Student609@mail.com", 41, "Student 609" },
                    { 610, "Student610@mail.com", 41, "Student 610" },
                    { 611, "Student611@mail.com", 41, "Student 611" },
                    { 612, "Student612@mail.com", 41, "Student 612" },
                    { 613, "Student613@mail.com", 41, "Student 613" },
                    { 614, "Student614@mail.com", 41, "Student 614" },
                    { 615, "Student615@mail.com", 41, "Student 615" },
                    { 616, "Student616@mail.com", 42, "Student 616" },
                    { 617, "Student617@mail.com", 42, "Student 617" },
                    { 618, "Student618@mail.com", 42, "Student 618" },
                    { 619, "Student619@mail.com", 42, "Student 619" },
                    { 620, "Student620@mail.com", 42, "Student 620" },
                    { 621, "Student621@mail.com", 42, "Student 621" },
                    { 622, "Student622@mail.com", 42, "Student 622" },
                    { 623, "Student623@mail.com", 42, "Student 623" },
                    { 624, "Student624@mail.com", 42, "Student 624" },
                    { 625, "Student625@mail.com", 42, "Student 625" },
                    { 626, "Student626@mail.com", 42, "Student 626" },
                    { 627, "Student627@mail.com", 42, "Student 627" },
                    { 628, "Student628@mail.com", 42, "Student 628" },
                    { 629, "Student629@mail.com", 42, "Student 629" },
                    { 630, "Student630@mail.com", 42, "Student 630" },
                    { 631, "Student631@mail.com", 43, "Student 631" },
                    { 632, "Student632@mail.com", 43, "Student 632" },
                    { 633, "Student633@mail.com", 43, "Student 633" },
                    { 634, "Student634@mail.com", 43, "Student 634" },
                    { 635, "Student635@mail.com", 43, "Student 635" },
                    { 636, "Student636@mail.com", 43, "Student 636" },
                    { 637, "Student637@mail.com", 43, "Student 637" },
                    { 638, "Student638@mail.com", 43, "Student 638" },
                    { 639, "Student639@mail.com", 43, "Student 639" },
                    { 640, "Student640@mail.com", 43, "Student 640" },
                    { 641, "Student641@mail.com", 43, "Student 641" },
                    { 642, "Student642@mail.com", 43, "Student 642" },
                    { 643, "Student643@mail.com", 43, "Student 643" },
                    { 644, "Student644@mail.com", 43, "Student 644" },
                    { 645, "Student645@mail.com", 43, "Student 645" },
                    { 646, "Student646@mail.com", 44, "Student 646" },
                    { 647, "Student647@mail.com", 44, "Student 647" },
                    { 648, "Student648@mail.com", 44, "Student 648" },
                    { 649, "Student649@mail.com", 44, "Student 649" },
                    { 650, "Student650@mail.com", 44, "Student 650" },
                    { 651, "Student651@mail.com", 44, "Student 651" },
                    { 652, "Student652@mail.com", 44, "Student 652" },
                    { 653, "Student653@mail.com", 44, "Student 653" },
                    { 654, "Student654@mail.com", 44, "Student 654" },
                    { 655, "Student655@mail.com", 44, "Student 655" },
                    { 656, "Student656@mail.com", 44, "Student 656" },
                    { 657, "Student657@mail.com", 44, "Student 657" },
                    { 658, "Student658@mail.com", 44, "Student 658" },
                    { 659, "Student659@mail.com", 44, "Student 659" },
                    { 660, "Student660@mail.com", 44, "Student 660" },
                    { 661, "Student661@mail.com", 45, "Student 661" },
                    { 662, "Student662@mail.com", 45, "Student 662" },
                    { 663, "Student663@mail.com", 45, "Student 663" },
                    { 664, "Student664@mail.com", 45, "Student 664" },
                    { 665, "Student665@mail.com", 45, "Student 665" },
                    { 666, "Student666@mail.com", 45, "Student 666" },
                    { 667, "Student667@mail.com", 45, "Student 667" },
                    { 668, "Student668@mail.com", 45, "Student 668" },
                    { 669, "Student669@mail.com", 45, "Student 669" },
                    { 670, "Student670@mail.com", 45, "Student 670" },
                    { 671, "Student671@mail.com", 45, "Student 671" },
                    { 672, "Student672@mail.com", 45, "Student 672" },
                    { 673, "Student673@mail.com", 45, "Student 673" },
                    { 674, "Student674@mail.com", 45, "Student 674" },
                    { 675, "Student675@mail.com", 45, "Student 675" },
                    { 676, "Student676@mail.com", 46, "Student 676" },
                    { 677, "Student677@mail.com", 46, "Student 677" },
                    { 678, "Student678@mail.com", 46, "Student 678" },
                    { 679, "Student679@mail.com", 46, "Student 679" },
                    { 680, "Student680@mail.com", 46, "Student 680" },
                    { 681, "Student681@mail.com", 46, "Student 681" },
                    { 682, "Student682@mail.com", 46, "Student 682" },
                    { 683, "Student683@mail.com", 46, "Student 683" },
                    { 684, "Student684@mail.com", 46, "Student 684" },
                    { 685, "Student685@mail.com", 46, "Student 685" },
                    { 686, "Student686@mail.com", 46, "Student 686" },
                    { 687, "Student687@mail.com", 46, "Student 687" },
                    { 688, "Student688@mail.com", 46, "Student 688" },
                    { 689, "Student689@mail.com", 46, "Student 689" },
                    { 690, "Student690@mail.com", 46, "Student 690" },
                    { 691, "Student691@mail.com", 47, "Student 691" },
                    { 692, "Student692@mail.com", 47, "Student 692" },
                    { 693, "Student693@mail.com", 47, "Student 693" },
                    { 694, "Student694@mail.com", 47, "Student 694" },
                    { 695, "Student695@mail.com", 47, "Student 695" },
                    { 696, "Student696@mail.com", 47, "Student 696" },
                    { 697, "Student697@mail.com", 47, "Student 697" },
                    { 698, "Student698@mail.com", 47, "Student 698" },
                    { 699, "Student699@mail.com", 47, "Student 699" },
                    { 700, "Student700@mail.com", 47, "Student 700" },
                    { 701, "Student701@mail.com", 47, "Student 701" },
                    { 702, "Student702@mail.com", 47, "Student 702" },
                    { 703, "Student703@mail.com", 47, "Student 703" },
                    { 704, "Student704@mail.com", 47, "Student 704" },
                    { 705, "Student705@mail.com", 47, "Student 705" },
                    { 706, "Student706@mail.com", 48, "Student 706" },
                    { 707, "Student707@mail.com", 48, "Student 707" },
                    { 708, "Student708@mail.com", 48, "Student 708" },
                    { 709, "Student709@mail.com", 48, "Student 709" },
                    { 710, "Student710@mail.com", 48, "Student 710" },
                    { 711, "Student711@mail.com", 48, "Student 711" },
                    { 712, "Student712@mail.com", 48, "Student 712" },
                    { 713, "Student713@mail.com", 48, "Student 713" },
                    { 714, "Student714@mail.com", 48, "Student 714" },
                    { 715, "Student715@mail.com", 48, "Student 715" },
                    { 716, "Student716@mail.com", 48, "Student 716" },
                    { 717, "Student717@mail.com", 48, "Student 717" },
                    { 718, "Student718@mail.com", 48, "Student 718" },
                    { 719, "Student719@mail.com", 48, "Student 719" },
                    { 720, "Student720@mail.com", 48, "Student 720" },
                    { 721, "Student721@mail.com", 49, "Student 721" },
                    { 722, "Student722@mail.com", 49, "Student 722" },
                    { 723, "Student723@mail.com", 49, "Student 723" },
                    { 724, "Student724@mail.com", 49, "Student 724" },
                    { 725, "Student725@mail.com", 49, "Student 725" },
                    { 726, "Student726@mail.com", 49, "Student 726" },
                    { 727, "Student727@mail.com", 49, "Student 727" },
                    { 728, "Student728@mail.com", 49, "Student 728" },
                    { 729, "Student729@mail.com", 49, "Student 729" },
                    { 730, "Student730@mail.com", 49, "Student 730" },
                    { 731, "Student731@mail.com", 49, "Student 731" },
                    { 732, "Student732@mail.com", 49, "Student 732" },
                    { 733, "Student733@mail.com", 49, "Student 733" },
                    { 734, "Student734@mail.com", 49, "Student 734" },
                    { 735, "Student735@mail.com", 49, "Student 735" },
                    { 736, "Student736@mail.com", 50, "Student 736" },
                    { 737, "Student737@mail.com", 50, "Student 737" },
                    { 738, "Student738@mail.com", 50, "Student 738" },
                    { 739, "Student739@mail.com", 50, "Student 739" },
                    { 740, "Student740@mail.com", 50, "Student 740" },
                    { 741, "Student741@mail.com", 50, "Student 741" },
                    { 742, "Student742@mail.com", 50, "Student 742" },
                    { 743, "Student743@mail.com", 50, "Student 743" },
                    { 744, "Student744@mail.com", 50, "Student 744" },
                    { 745, "Student745@mail.com", 50, "Student 745" },
                    { 746, "Student746@mail.com", 50, "Student 746" },
                    { 747, "Student747@mail.com", 50, "Student 747" },
                    { 748, "Student748@mail.com", 50, "Student 748" },
                    { 749, "Student749@mail.com", 50, "Student 749" },
                    { 750, "Student750@mail.com", 50, "Student 750" },
                    { 751, "Student751@mail.com", 51, "Student 751" },
                    { 752, "Student752@mail.com", 51, "Student 752" },
                    { 753, "Student753@mail.com", 51, "Student 753" },
                    { 754, "Student754@mail.com", 51, "Student 754" },
                    { 755, "Student755@mail.com", 51, "Student 755" },
                    { 756, "Student756@mail.com", 51, "Student 756" },
                    { 757, "Student757@mail.com", 51, "Student 757" },
                    { 758, "Student758@mail.com", 51, "Student 758" },
                    { 759, "Student759@mail.com", 51, "Student 759" },
                    { 760, "Student760@mail.com", 51, "Student 760" },
                    { 761, "Student761@mail.com", 51, "Student 761" },
                    { 762, "Student762@mail.com", 51, "Student 762" },
                    { 763, "Student763@mail.com", 51, "Student 763" },
                    { 764, "Student764@mail.com", 51, "Student 764" },
                    { 765, "Student765@mail.com", 51, "Student 765" },
                    { 766, "Student766@mail.com", 52, "Student 766" },
                    { 767, "Student767@mail.com", 52, "Student 767" },
                    { 768, "Student768@mail.com", 52, "Student 768" },
                    { 769, "Student769@mail.com", 52, "Student 769" },
                    { 770, "Student770@mail.com", 52, "Student 770" },
                    { 771, "Student771@mail.com", 52, "Student 771" },
                    { 772, "Student772@mail.com", 52, "Student 772" },
                    { 773, "Student773@mail.com", 52, "Student 773" },
                    { 774, "Student774@mail.com", 52, "Student 774" },
                    { 775, "Student775@mail.com", 52, "Student 775" },
                    { 776, "Student776@mail.com", 52, "Student 776" },
                    { 777, "Student777@mail.com", 52, "Student 777" },
                    { 778, "Student778@mail.com", 52, "Student 778" },
                    { 779, "Student779@mail.com", 52, "Student 779" },
                    { 780, "Student780@mail.com", 52, "Student 780" },
                    { 781, "Student781@mail.com", 53, "Student 781" },
                    { 782, "Student782@mail.com", 53, "Student 782" },
                    { 783, "Student783@mail.com", 53, "Student 783" },
                    { 784, "Student784@mail.com", 53, "Student 784" },
                    { 785, "Student785@mail.com", 53, "Student 785" },
                    { 786, "Student786@mail.com", 53, "Student 786" },
                    { 787, "Student787@mail.com", 53, "Student 787" },
                    { 788, "Student788@mail.com", 53, "Student 788" },
                    { 789, "Student789@mail.com", 53, "Student 789" },
                    { 790, "Student790@mail.com", 53, "Student 790" },
                    { 791, "Student791@mail.com", 53, "Student 791" },
                    { 792, "Student792@mail.com", 53, "Student 792" },
                    { 793, "Student793@mail.com", 53, "Student 793" },
                    { 794, "Student794@mail.com", 53, "Student 794" },
                    { 795, "Student795@mail.com", 53, "Student 795" },
                    { 796, "Student796@mail.com", 54, "Student 796" },
                    { 797, "Student797@mail.com", 54, "Student 797" },
                    { 798, "Student798@mail.com", 54, "Student 798" },
                    { 799, "Student799@mail.com", 54, "Student 799" },
                    { 800, "Student800@mail.com", 54, "Student 800" },
                    { 801, "Student801@mail.com", 54, "Student 801" },
                    { 802, "Student802@mail.com", 54, "Student 802" },
                    { 803, "Student803@mail.com", 54, "Student 803" },
                    { 804, "Student804@mail.com", 54, "Student 804" },
                    { 805, "Student805@mail.com", 54, "Student 805" },
                    { 806, "Student806@mail.com", 54, "Student 806" },
                    { 807, "Student807@mail.com", 54, "Student 807" },
                    { 808, "Student808@mail.com", 54, "Student 808" },
                    { 809, "Student809@mail.com", 54, "Student 809" },
                    { 810, "Student810@mail.com", 54, "Student 810" },
                    { 811, "Student811@mail.com", 55, "Student 811" },
                    { 812, "Student812@mail.com", 55, "Student 812" },
                    { 813, "Student813@mail.com", 55, "Student 813" },
                    { 814, "Student814@mail.com", 55, "Student 814" },
                    { 815, "Student815@mail.com", 55, "Student 815" },
                    { 816, "Student816@mail.com", 55, "Student 816" },
                    { 817, "Student817@mail.com", 55, "Student 817" },
                    { 818, "Student818@mail.com", 55, "Student 818" },
                    { 819, "Student819@mail.com", 55, "Student 819" },
                    { 820, "Student820@mail.com", 55, "Student 820" },
                    { 821, "Student821@mail.com", 55, "Student 821" },
                    { 822, "Student822@mail.com", 55, "Student 822" },
                    { 823, "Student823@mail.com", 55, "Student 823" },
                    { 824, "Student824@mail.com", 55, "Student 824" },
                    { 825, "Student825@mail.com", 55, "Student 825" },
                    { 826, "Student826@mail.com", 56, "Student 826" },
                    { 827, "Student827@mail.com", 56, "Student 827" },
                    { 828, "Student828@mail.com", 56, "Student 828" },
                    { 829, "Student829@mail.com", 56, "Student 829" },
                    { 830, "Student830@mail.com", 56, "Student 830" },
                    { 831, "Student831@mail.com", 56, "Student 831" },
                    { 832, "Student832@mail.com", 56, "Student 832" },
                    { 833, "Student833@mail.com", 56, "Student 833" },
                    { 834, "Student834@mail.com", 56, "Student 834" },
                    { 835, "Student835@mail.com", 56, "Student 835" },
                    { 836, "Student836@mail.com", 56, "Student 836" },
                    { 837, "Student837@mail.com", 56, "Student 837" },
                    { 838, "Student838@mail.com", 56, "Student 838" },
                    { 839, "Student839@mail.com", 56, "Student 839" },
                    { 840, "Student840@mail.com", 56, "Student 840" },
                    { 841, "Student841@mail.com", 57, "Student 841" },
                    { 842, "Student842@mail.com", 57, "Student 842" },
                    { 843, "Student843@mail.com", 57, "Student 843" },
                    { 844, "Student844@mail.com", 57, "Student 844" },
                    { 845, "Student845@mail.com", 57, "Student 845" },
                    { 846, "Student846@mail.com", 57, "Student 846" },
                    { 847, "Student847@mail.com", 57, "Student 847" },
                    { 848, "Student848@mail.com", 57, "Student 848" },
                    { 849, "Student849@mail.com", 57, "Student 849" },
                    { 850, "Student850@mail.com", 57, "Student 850" },
                    { 851, "Student851@mail.com", 57, "Student 851" },
                    { 852, "Student852@mail.com", 57, "Student 852" },
                    { 853, "Student853@mail.com", 57, "Student 853" },
                    { 854, "Student854@mail.com", 57, "Student 854" },
                    { 855, "Student855@mail.com", 57, "Student 855" },
                    { 856, "Student856@mail.com", 58, "Student 856" },
                    { 857, "Student857@mail.com", 58, "Student 857" },
                    { 858, "Student858@mail.com", 58, "Student 858" },
                    { 859, "Student859@mail.com", 58, "Student 859" },
                    { 860, "Student860@mail.com", 58, "Student 860" },
                    { 861, "Student861@mail.com", 58, "Student 861" },
                    { 862, "Student862@mail.com", 58, "Student 862" },
                    { 863, "Student863@mail.com", 58, "Student 863" },
                    { 864, "Student864@mail.com", 58, "Student 864" },
                    { 865, "Student865@mail.com", 58, "Student 865" },
                    { 866, "Student866@mail.com", 58, "Student 866" },
                    { 867, "Student867@mail.com", 58, "Student 867" },
                    { 868, "Student868@mail.com", 58, "Student 868" },
                    { 869, "Student869@mail.com", 58, "Student 869" },
                    { 870, "Student870@mail.com", 58, "Student 870" },
                    { 871, "Student871@mail.com", 59, "Student 871" },
                    { 872, "Student872@mail.com", 59, "Student 872" },
                    { 873, "Student873@mail.com", 59, "Student 873" },
                    { 874, "Student874@mail.com", 59, "Student 874" },
                    { 875, "Student875@mail.com", 59, "Student 875" },
                    { 876, "Student876@mail.com", 59, "Student 876" },
                    { 877, "Student877@mail.com", 59, "Student 877" },
                    { 878, "Student878@mail.com", 59, "Student 878" },
                    { 879, "Student879@mail.com", 59, "Student 879" },
                    { 880, "Student880@mail.com", 59, "Student 880" },
                    { 881, "Student881@mail.com", 59, "Student 881" },
                    { 882, "Student882@mail.com", 59, "Student 882" },
                    { 883, "Student883@mail.com", 59, "Student 883" },
                    { 884, "Student884@mail.com", 59, "Student 884" },
                    { 885, "Student885@mail.com", 59, "Student 885" },
                    { 886, "Student886@mail.com", 60, "Student 886" },
                    { 887, "Student887@mail.com", 60, "Student 887" },
                    { 888, "Student888@mail.com", 60, "Student 888" },
                    { 889, "Student889@mail.com", 60, "Student 889" },
                    { 890, "Student890@mail.com", 60, "Student 890" },
                    { 891, "Student891@mail.com", 60, "Student 891" },
                    { 892, "Student892@mail.com", 60, "Student 892" },
                    { 893, "Student893@mail.com", 60, "Student 893" },
                    { 894, "Student894@mail.com", 60, "Student 894" },
                    { 895, "Student895@mail.com", 60, "Student 895" },
                    { 896, "Student896@mail.com", 60, "Student 896" },
                    { 897, "Student897@mail.com", 60, "Student 897" },
                    { 898, "Student898@mail.com", 60, "Student 898" },
                    { 899, "Student899@mail.com", 60, "Student 899" },
                    { 900, "Student900@mail.com", 60, "Student 900" },
                    { 901, "Student901@mail.com", 61, "Student 901" },
                    { 902, "Student902@mail.com", 61, "Student 902" },
                    { 903, "Student903@mail.com", 61, "Student 903" },
                    { 904, "Student904@mail.com", 61, "Student 904" },
                    { 905, "Student905@mail.com", 61, "Student 905" },
                    { 906, "Student906@mail.com", 61, "Student 906" },
                    { 907, "Student907@mail.com", 61, "Student 907" },
                    { 908, "Student908@mail.com", 61, "Student 908" },
                    { 909, "Student909@mail.com", 61, "Student 909" },
                    { 910, "Student910@mail.com", 61, "Student 910" },
                    { 911, "Student911@mail.com", 61, "Student 911" },
                    { 912, "Student912@mail.com", 61, "Student 912" },
                    { 913, "Student913@mail.com", 61, "Student 913" },
                    { 914, "Student914@mail.com", 61, "Student 914" },
                    { 915, "Student915@mail.com", 61, "Student 915" },
                    { 916, "Student916@mail.com", 62, "Student 916" },
                    { 917, "Student917@mail.com", 62, "Student 917" },
                    { 918, "Student918@mail.com", 62, "Student 918" },
                    { 919, "Student919@mail.com", 62, "Student 919" },
                    { 920, "Student920@mail.com", 62, "Student 920" },
                    { 921, "Student921@mail.com", 62, "Student 921" },
                    { 922, "Student922@mail.com", 62, "Student 922" },
                    { 923, "Student923@mail.com", 62, "Student 923" },
                    { 924, "Student924@mail.com", 62, "Student 924" },
                    { 925, "Student925@mail.com", 62, "Student 925" },
                    { 926, "Student926@mail.com", 62, "Student 926" },
                    { 927, "Student927@mail.com", 62, "Student 927" },
                    { 928, "Student928@mail.com", 62, "Student 928" },
                    { 929, "Student929@mail.com", 62, "Student 929" },
                    { 930, "Student930@mail.com", 62, "Student 930" },
                    { 931, "Student931@mail.com", 63, "Student 931" },
                    { 932, "Student932@mail.com", 63, "Student 932" },
                    { 933, "Student933@mail.com", 63, "Student 933" },
                    { 934, "Student934@mail.com", 63, "Student 934" },
                    { 935, "Student935@mail.com", 63, "Student 935" },
                    { 936, "Student936@mail.com", 63, "Student 936" },
                    { 937, "Student937@mail.com", 63, "Student 937" },
                    { 938, "Student938@mail.com", 63, "Student 938" },
                    { 939, "Student939@mail.com", 63, "Student 939" },
                    { 940, "Student940@mail.com", 63, "Student 940" },
                    { 941, "Student941@mail.com", 63, "Student 941" },
                    { 942, "Student942@mail.com", 63, "Student 942" },
                    { 943, "Student943@mail.com", 63, "Student 943" },
                    { 944, "Student944@mail.com", 63, "Student 944" },
                    { 945, "Student945@mail.com", 63, "Student 945" },
                    { 946, "Student946@mail.com", 64, "Student 946" },
                    { 947, "Student947@mail.com", 64, "Student 947" },
                    { 948, "Student948@mail.com", 64, "Student 948" },
                    { 949, "Student949@mail.com", 64, "Student 949" },
                    { 950, "Student950@mail.com", 64, "Student 950" },
                    { 951, "Student951@mail.com", 64, "Student 951" },
                    { 952, "Student952@mail.com", 64, "Student 952" },
                    { 953, "Student953@mail.com", 64, "Student 953" },
                    { 954, "Student954@mail.com", 64, "Student 954" },
                    { 955, "Student955@mail.com", 64, "Student 955" },
                    { 956, "Student956@mail.com", 64, "Student 956" },
                    { 957, "Student957@mail.com", 64, "Student 957" },
                    { 958, "Student958@mail.com", 64, "Student 958" },
                    { 959, "Student959@mail.com", 64, "Student 959" },
                    { 960, "Student960@mail.com", 64, "Student 960" },
                    { 961, "Student961@mail.com", 65, "Student 961" },
                    { 962, "Student962@mail.com", 65, "Student 962" },
                    { 963, "Student963@mail.com", 65, "Student 963" },
                    { 964, "Student964@mail.com", 65, "Student 964" },
                    { 965, "Student965@mail.com", 65, "Student 965" },
                    { 966, "Student966@mail.com", 65, "Student 966" },
                    { 967, "Student967@mail.com", 65, "Student 967" },
                    { 968, "Student968@mail.com", 65, "Student 968" },
                    { 969, "Student969@mail.com", 65, "Student 969" },
                    { 970, "Student970@mail.com", 65, "Student 970" },
                    { 971, "Student971@mail.com", 65, "Student 971" },
                    { 972, "Student972@mail.com", 65, "Student 972" },
                    { 973, "Student973@mail.com", 65, "Student 973" },
                    { 974, "Student974@mail.com", 65, "Student 974" },
                    { 975, "Student975@mail.com", 65, "Student 975" },
                    { 976, "Student976@mail.com", 66, "Student 976" },
                    { 977, "Student977@mail.com", 66, "Student 977" },
                    { 978, "Student978@mail.com", 66, "Student 978" },
                    { 979, "Student979@mail.com", 66, "Student 979" },
                    { 980, "Student980@mail.com", 66, "Student 980" },
                    { 981, "Student981@mail.com", 66, "Student 981" },
                    { 982, "Student982@mail.com", 66, "Student 982" },
                    { 983, "Student983@mail.com", 66, "Student 983" },
                    { 984, "Student984@mail.com", 66, "Student 984" },
                    { 985, "Student985@mail.com", 66, "Student 985" },
                    { 986, "Student986@mail.com", 66, "Student 986" },
                    { 987, "Student987@mail.com", 66, "Student 987" },
                    { 988, "Student988@mail.com", 66, "Student 988" },
                    { 989, "Student989@mail.com", 66, "Student 989" },
                    { 990, "Student990@mail.com", 66, "Student 990" },
                    { 991, "Student991@mail.com", 67, "Student 991" },
                    { 992, "Student992@mail.com", 67, "Student 992" },
                    { 993, "Student993@mail.com", 67, "Student 993" },
                    { 994, "Student994@mail.com", 67, "Student 994" },
                    { 995, "Student995@mail.com", 67, "Student 995" },
                    { 996, "Student996@mail.com", 67, "Student 996" },
                    { 997, "Student997@mail.com", 67, "Student 997" },
                    { 998, "Student998@mail.com", 67, "Student 998" },
                    { 999, "Student999@mail.com", 67, "Student 999" },
                    { 1000, "Student1000@mail.com", 67, "Student 1000" },
                    { 1001, "Student1001@mail.com", 67, "Student 1001" },
                    { 1002, "Student1002@mail.com", 67, "Student 1002" },
                    { 1003, "Student1003@mail.com", 67, "Student 1003" },
                    { 1004, "Student1004@mail.com", 67, "Student 1004" },
                    { 1005, "Student1005@mail.com", 67, "Student 1005" },
                    { 1006, "Student1006@mail.com", 68, "Student 1006" },
                    { 1007, "Student1007@mail.com", 68, "Student 1007" },
                    { 1008, "Student1008@mail.com", 68, "Student 1008" },
                    { 1009, "Student1009@mail.com", 68, "Student 1009" },
                    { 1010, "Student1010@mail.com", 68, "Student 1010" },
                    { 1011, "Student1011@mail.com", 68, "Student 1011" },
                    { 1012, "Student1012@mail.com", 68, "Student 1012" },
                    { 1013, "Student1013@mail.com", 68, "Student 1013" },
                    { 1014, "Student1014@mail.com", 68, "Student 1014" },
                    { 1015, "Student1015@mail.com", 68, "Student 1015" },
                    { 1016, "Student1016@mail.com", 68, "Student 1016" },
                    { 1017, "Student1017@mail.com", 68, "Student 1017" },
                    { 1018, "Student1018@mail.com", 68, "Student 1018" },
                    { 1019, "Student1019@mail.com", 68, "Student 1019" },
                    { 1020, "Student1020@mail.com", 68, "Student 1020" },
                    { 1021, "Student1021@mail.com", 69, "Student 1021" },
                    { 1022, "Student1022@mail.com", 69, "Student 1022" },
                    { 1023, "Student1023@mail.com", 69, "Student 1023" },
                    { 1024, "Student1024@mail.com", 69, "Student 1024" },
                    { 1025, "Student1025@mail.com", 69, "Student 1025" },
                    { 1026, "Student1026@mail.com", 69, "Student 1026" },
                    { 1027, "Student1027@mail.com", 69, "Student 1027" },
                    { 1028, "Student1028@mail.com", 69, "Student 1028" },
                    { 1029, "Student1029@mail.com", 69, "Student 1029" },
                    { 1030, "Student1030@mail.com", 69, "Student 1030" },
                    { 1031, "Student1031@mail.com", 69, "Student 1031" },
                    { 1032, "Student1032@mail.com", 69, "Student 1032" },
                    { 1033, "Student1033@mail.com", 69, "Student 1033" },
                    { 1034, "Student1034@mail.com", 69, "Student 1034" },
                    { 1035, "Student1035@mail.com", 69, "Student 1035" },
                    { 1036, "Student1036@mail.com", 70, "Student 1036" },
                    { 1037, "Student1037@mail.com", 70, "Student 1037" },
                    { 1038, "Student1038@mail.com", 70, "Student 1038" },
                    { 1039, "Student1039@mail.com", 70, "Student 1039" },
                    { 1040, "Student1040@mail.com", 70, "Student 1040" },
                    { 1041, "Student1041@mail.com", 70, "Student 1041" },
                    { 1042, "Student1042@mail.com", 70, "Student 1042" },
                    { 1043, "Student1043@mail.com", 70, "Student 1043" },
                    { 1044, "Student1044@mail.com", 70, "Student 1044" },
                    { 1045, "Student1045@mail.com", 70, "Student 1045" },
                    { 1046, "Student1046@mail.com", 70, "Student 1046" },
                    { 1047, "Student1047@mail.com", 70, "Student 1047" },
                    { 1048, "Student1048@mail.com", 70, "Student 1048" },
                    { 1049, "Student1049@mail.com", 70, "Student 1049" },
                    { 1050, "Student1050@mail.com", 70, "Student 1050" },
                    { 1051, "Student1051@mail.com", 71, "Student 1051" },
                    { 1052, "Student1052@mail.com", 71, "Student 1052" },
                    { 1053, "Student1053@mail.com", 71, "Student 1053" },
                    { 1054, "Student1054@mail.com", 71, "Student 1054" },
                    { 1055, "Student1055@mail.com", 71, "Student 1055" },
                    { 1056, "Student1056@mail.com", 71, "Student 1056" },
                    { 1057, "Student1057@mail.com", 71, "Student 1057" },
                    { 1058, "Student1058@mail.com", 71, "Student 1058" },
                    { 1059, "Student1059@mail.com", 71, "Student 1059" },
                    { 1060, "Student1060@mail.com", 71, "Student 1060" },
                    { 1061, "Student1061@mail.com", 71, "Student 1061" },
                    { 1062, "Student1062@mail.com", 71, "Student 1062" },
                    { 1063, "Student1063@mail.com", 71, "Student 1063" },
                    { 1064, "Student1064@mail.com", 71, "Student 1064" },
                    { 1065, "Student1065@mail.com", 71, "Student 1065" },
                    { 1066, "Student1066@mail.com", 72, "Student 1066" },
                    { 1067, "Student1067@mail.com", 72, "Student 1067" },
                    { 1068, "Student1068@mail.com", 72, "Student 1068" },
                    { 1069, "Student1069@mail.com", 72, "Student 1069" },
                    { 1070, "Student1070@mail.com", 72, "Student 1070" },
                    { 1071, "Student1071@mail.com", 72, "Student 1071" },
                    { 1072, "Student1072@mail.com", 72, "Student 1072" },
                    { 1073, "Student1073@mail.com", 72, "Student 1073" },
                    { 1074, "Student1074@mail.com", 72, "Student 1074" },
                    { 1075, "Student1075@mail.com", 72, "Student 1075" },
                    { 1076, "Student1076@mail.com", 72, "Student 1076" },
                    { 1077, "Student1077@mail.com", 72, "Student 1077" },
                    { 1078, "Student1078@mail.com", 72, "Student 1078" },
                    { 1079, "Student1079@mail.com", 72, "Student 1079" },
                    { 1080, "Student1080@mail.com", 72, "Student 1080" },
                    { 1081, "Student1081@mail.com", 73, "Student 1081" },
                    { 1082, "Student1082@mail.com", 73, "Student 1082" },
                    { 1083, "Student1083@mail.com", 73, "Student 1083" },
                    { 1084, "Student1084@mail.com", 73, "Student 1084" },
                    { 1085, "Student1085@mail.com", 73, "Student 1085" },
                    { 1086, "Student1086@mail.com", 73, "Student 1086" },
                    { 1087, "Student1087@mail.com", 73, "Student 1087" },
                    { 1088, "Student1088@mail.com", 73, "Student 1088" },
                    { 1089, "Student1089@mail.com", 73, "Student 1089" },
                    { 1090, "Student1090@mail.com", 73, "Student 1090" },
                    { 1091, "Student1091@mail.com", 73, "Student 1091" },
                    { 1092, "Student1092@mail.com", 73, "Student 1092" },
                    { 1093, "Student1093@mail.com", 73, "Student 1093" },
                    { 1094, "Student1094@mail.com", 73, "Student 1094" },
                    { 1095, "Student1095@mail.com", 73, "Student 1095" },
                    { 1096, "Student1096@mail.com", 74, "Student 1096" },
                    { 1097, "Student1097@mail.com", 74, "Student 1097" },
                    { 1098, "Student1098@mail.com", 74, "Student 1098" },
                    { 1099, "Student1099@mail.com", 74, "Student 1099" },
                    { 1100, "Student1100@mail.com", 74, "Student 1100" },
                    { 1101, "Student1101@mail.com", 74, "Student 1101" },
                    { 1102, "Student1102@mail.com", 74, "Student 1102" },
                    { 1103, "Student1103@mail.com", 74, "Student 1103" },
                    { 1104, "Student1104@mail.com", 74, "Student 1104" },
                    { 1105, "Student1105@mail.com", 74, "Student 1105" },
                    { 1106, "Student1106@mail.com", 74, "Student 1106" },
                    { 1107, "Student1107@mail.com", 74, "Student 1107" },
                    { 1108, "Student1108@mail.com", 74, "Student 1108" },
                    { 1109, "Student1109@mail.com", 74, "Student 1109" },
                    { 1110, "Student1110@mail.com", 74, "Student 1110" },
                    { 1111, "Student1111@mail.com", 75, "Student 1111" },
                    { 1112, "Student1112@mail.com", 75, "Student 1112" },
                    { 1113, "Student1113@mail.com", 75, "Student 1113" },
                    { 1114, "Student1114@mail.com", 75, "Student 1114" },
                    { 1115, "Student1115@mail.com", 75, "Student 1115" },
                    { 1116, "Student1116@mail.com", 75, "Student 1116" },
                    { 1117, "Student1117@mail.com", 75, "Student 1117" },
                    { 1118, "Student1118@mail.com", 75, "Student 1118" },
                    { 1119, "Student1119@mail.com", 75, "Student 1119" },
                    { 1120, "Student1120@mail.com", 75, "Student 1120" },
                    { 1121, "Student1121@mail.com", 75, "Student 1121" },
                    { 1122, "Student1122@mail.com", 75, "Student 1122" },
                    { 1123, "Student1123@mail.com", 75, "Student 1123" },
                    { 1124, "Student1124@mail.com", 75, "Student 1124" },
                    { 1125, "Student1125@mail.com", 75, "Student 1125" },
                    { 1126, "Student1126@mail.com", 76, "Student 1126" },
                    { 1127, "Student1127@mail.com", 76, "Student 1127" },
                    { 1128, "Student1128@mail.com", 76, "Student 1128" },
                    { 1129, "Student1129@mail.com", 76, "Student 1129" },
                    { 1130, "Student1130@mail.com", 76, "Student 1130" },
                    { 1131, "Student1131@mail.com", 76, "Student 1131" },
                    { 1132, "Student1132@mail.com", 76, "Student 1132" },
                    { 1133, "Student1133@mail.com", 76, "Student 1133" },
                    { 1134, "Student1134@mail.com", 76, "Student 1134" },
                    { 1135, "Student1135@mail.com", 76, "Student 1135" },
                    { 1136, "Student1136@mail.com", 76, "Student 1136" },
                    { 1137, "Student1137@mail.com", 76, "Student 1137" },
                    { 1138, "Student1138@mail.com", 76, "Student 1138" },
                    { 1139, "Student1139@mail.com", 76, "Student 1139" },
                    { 1140, "Student1140@mail.com", 76, "Student 1140" },
                    { 1141, "Student1141@mail.com", 77, "Student 1141" },
                    { 1142, "Student1142@mail.com", 77, "Student 1142" },
                    { 1143, "Student1143@mail.com", 77, "Student 1143" },
                    { 1144, "Student1144@mail.com", 77, "Student 1144" },
                    { 1145, "Student1145@mail.com", 77, "Student 1145" },
                    { 1146, "Student1146@mail.com", 77, "Student 1146" },
                    { 1147, "Student1147@mail.com", 77, "Student 1147" },
                    { 1148, "Student1148@mail.com", 77, "Student 1148" },
                    { 1149, "Student1149@mail.com", 77, "Student 1149" },
                    { 1150, "Student1150@mail.com", 77, "Student 1150" },
                    { 1151, "Student1151@mail.com", 77, "Student 1151" },
                    { 1152, "Student1152@mail.com", 77, "Student 1152" },
                    { 1153, "Student1153@mail.com", 77, "Student 1153" },
                    { 1154, "Student1154@mail.com", 77, "Student 1154" },
                    { 1155, "Student1155@mail.com", 77, "Student 1155" },
                    { 1156, "Student1156@mail.com", 78, "Student 1156" },
                    { 1157, "Student1157@mail.com", 78, "Student 1157" },
                    { 1158, "Student1158@mail.com", 78, "Student 1158" },
                    { 1159, "Student1159@mail.com", 78, "Student 1159" },
                    { 1160, "Student1160@mail.com", 78, "Student 1160" },
                    { 1161, "Student1161@mail.com", 78, "Student 1161" },
                    { 1162, "Student1162@mail.com", 78, "Student 1162" },
                    { 1163, "Student1163@mail.com", 78, "Student 1163" },
                    { 1164, "Student1164@mail.com", 78, "Student 1164" },
                    { 1165, "Student1165@mail.com", 78, "Student 1165" },
                    { 1166, "Student1166@mail.com", 78, "Student 1166" },
                    { 1167, "Student1167@mail.com", 78, "Student 1167" },
                    { 1168, "Student1168@mail.com", 78, "Student 1168" },
                    { 1169, "Student1169@mail.com", 78, "Student 1169" },
                    { 1170, "Student1170@mail.com", 78, "Student 1170" },
                    { 1171, "Student1171@mail.com", 79, "Student 1171" },
                    { 1172, "Student1172@mail.com", 79, "Student 1172" },
                    { 1173, "Student1173@mail.com", 79, "Student 1173" },
                    { 1174, "Student1174@mail.com", 79, "Student 1174" },
                    { 1175, "Student1175@mail.com", 79, "Student 1175" },
                    { 1176, "Student1176@mail.com", 79, "Student 1176" },
                    { 1177, "Student1177@mail.com", 79, "Student 1177" },
                    { 1178, "Student1178@mail.com", 79, "Student 1178" },
                    { 1179, "Student1179@mail.com", 79, "Student 1179" },
                    { 1180, "Student1180@mail.com", 79, "Student 1180" },
                    { 1181, "Student1181@mail.com", 79, "Student 1181" },
                    { 1182, "Student1182@mail.com", 79, "Student 1182" },
                    { 1183, "Student1183@mail.com", 79, "Student 1183" },
                    { 1184, "Student1184@mail.com", 79, "Student 1184" },
                    { 1185, "Student1185@mail.com", 79, "Student 1185" },
                    { 1186, "Student1186@mail.com", 80, "Student 1186" },
                    { 1187, "Student1187@mail.com", 80, "Student 1187" },
                    { 1188, "Student1188@mail.com", 80, "Student 1188" },
                    { 1189, "Student1189@mail.com", 80, "Student 1189" },
                    { 1190, "Student1190@mail.com", 80, "Student 1190" },
                    { 1191, "Student1191@mail.com", 80, "Student 1191" },
                    { 1192, "Student1192@mail.com", 80, "Student 1192" },
                    { 1193, "Student1193@mail.com", 80, "Student 1193" },
                    { 1194, "Student1194@mail.com", 80, "Student 1194" },
                    { 1195, "Student1195@mail.com", 80, "Student 1195" },
                    { 1196, "Student1196@mail.com", 80, "Student 1196" },
                    { 1197, "Student1197@mail.com", 80, "Student 1197" },
                    { 1198, "Student1198@mail.com", 80, "Student 1198" },
                    { 1199, "Student1199@mail.com", 80, "Student 1199" },
                    { 1200, "Student1200@mail.com", 80, "Student 1200" },
                    { 1201, "Student1201@mail.com", 81, "Student 1201" },
                    { 1202, "Student1202@mail.com", 81, "Student 1202" },
                    { 1203, "Student1203@mail.com", 81, "Student 1203" },
                    { 1204, "Student1204@mail.com", 81, "Student 1204" },
                    { 1205, "Student1205@mail.com", 81, "Student 1205" },
                    { 1206, "Student1206@mail.com", 81, "Student 1206" },
                    { 1207, "Student1207@mail.com", 81, "Student 1207" },
                    { 1208, "Student1208@mail.com", 81, "Student 1208" },
                    { 1209, "Student1209@mail.com", 81, "Student 1209" },
                    { 1210, "Student1210@mail.com", 81, "Student 1210" },
                    { 1211, "Student1211@mail.com", 81, "Student 1211" },
                    { 1212, "Student1212@mail.com", 81, "Student 1212" },
                    { 1213, "Student1213@mail.com", 81, "Student 1213" },
                    { 1214, "Student1214@mail.com", 81, "Student 1214" },
                    { 1215, "Student1215@mail.com", 81, "Student 1215" },
                    { 1216, "Student1216@mail.com", 82, "Student 1216" },
                    { 1217, "Student1217@mail.com", 82, "Student 1217" },
                    { 1218, "Student1218@mail.com", 82, "Student 1218" },
                    { 1219, "Student1219@mail.com", 82, "Student 1219" },
                    { 1220, "Student1220@mail.com", 82, "Student 1220" },
                    { 1221, "Student1221@mail.com", 82, "Student 1221" },
                    { 1222, "Student1222@mail.com", 82, "Student 1222" },
                    { 1223, "Student1223@mail.com", 82, "Student 1223" },
                    { 1224, "Student1224@mail.com", 82, "Student 1224" },
                    { 1225, "Student1225@mail.com", 82, "Student 1225" },
                    { 1226, "Student1226@mail.com", 82, "Student 1226" },
                    { 1227, "Student1227@mail.com", 82, "Student 1227" },
                    { 1228, "Student1228@mail.com", 82, "Student 1228" },
                    { 1229, "Student1229@mail.com", 82, "Student 1229" },
                    { 1230, "Student1230@mail.com", 82, "Student 1230" },
                    { 1231, "Student1231@mail.com", 83, "Student 1231" },
                    { 1232, "Student1232@mail.com", 83, "Student 1232" },
                    { 1233, "Student1233@mail.com", 83, "Student 1233" },
                    { 1234, "Student1234@mail.com", 83, "Student 1234" },
                    { 1235, "Student1235@mail.com", 83, "Student 1235" },
                    { 1236, "Student1236@mail.com", 83, "Student 1236" },
                    { 1237, "Student1237@mail.com", 83, "Student 1237" },
                    { 1238, "Student1238@mail.com", 83, "Student 1238" },
                    { 1239, "Student1239@mail.com", 83, "Student 1239" },
                    { 1240, "Student1240@mail.com", 83, "Student 1240" },
                    { 1241, "Student1241@mail.com", 83, "Student 1241" },
                    { 1242, "Student1242@mail.com", 83, "Student 1242" },
                    { 1243, "Student1243@mail.com", 83, "Student 1243" },
                    { 1244, "Student1244@mail.com", 83, "Student 1244" },
                    { 1245, "Student1245@mail.com", 83, "Student 1245" },
                    { 1246, "Student1246@mail.com", 84, "Student 1246" },
                    { 1247, "Student1247@mail.com", 84, "Student 1247" },
                    { 1248, "Student1248@mail.com", 84, "Student 1248" },
                    { 1249, "Student1249@mail.com", 84, "Student 1249" },
                    { 1250, "Student1250@mail.com", 84, "Student 1250" },
                    { 1251, "Student1251@mail.com", 84, "Student 1251" },
                    { 1252, "Student1252@mail.com", 84, "Student 1252" },
                    { 1253, "Student1253@mail.com", 84, "Student 1253" },
                    { 1254, "Student1254@mail.com", 84, "Student 1254" },
                    { 1255, "Student1255@mail.com", 84, "Student 1255" },
                    { 1256, "Student1256@mail.com", 84, "Student 1256" },
                    { 1257, "Student1257@mail.com", 84, "Student 1257" },
                    { 1258, "Student1258@mail.com", 84, "Student 1258" },
                    { 1259, "Student1259@mail.com", 84, "Student 1259" },
                    { 1260, "Student1260@mail.com", 84, "Student 1260" },
                    { 1261, "Student1261@mail.com", 85, "Student 1261" },
                    { 1262, "Student1262@mail.com", 85, "Student 1262" },
                    { 1263, "Student1263@mail.com", 85, "Student 1263" },
                    { 1264, "Student1264@mail.com", 85, "Student 1264" },
                    { 1265, "Student1265@mail.com", 85, "Student 1265" },
                    { 1266, "Student1266@mail.com", 85, "Student 1266" },
                    { 1267, "Student1267@mail.com", 85, "Student 1267" },
                    { 1268, "Student1268@mail.com", 85, "Student 1268" },
                    { 1269, "Student1269@mail.com", 85, "Student 1269" },
                    { 1270, "Student1270@mail.com", 85, "Student 1270" },
                    { 1271, "Student1271@mail.com", 85, "Student 1271" },
                    { 1272, "Student1272@mail.com", 85, "Student 1272" },
                    { 1273, "Student1273@mail.com", 85, "Student 1273" },
                    { 1274, "Student1274@mail.com", 85, "Student 1274" },
                    { 1275, "Student1275@mail.com", 85, "Student 1275" },
                    { 1276, "Student1276@mail.com", 86, "Student 1276" },
                    { 1277, "Student1277@mail.com", 86, "Student 1277" },
                    { 1278, "Student1278@mail.com", 86, "Student 1278" },
                    { 1279, "Student1279@mail.com", 86, "Student 1279" },
                    { 1280, "Student1280@mail.com", 86, "Student 1280" },
                    { 1281, "Student1281@mail.com", 86, "Student 1281" },
                    { 1282, "Student1282@mail.com", 86, "Student 1282" },
                    { 1283, "Student1283@mail.com", 86, "Student 1283" },
                    { 1284, "Student1284@mail.com", 86, "Student 1284" },
                    { 1285, "Student1285@mail.com", 86, "Student 1285" },
                    { 1286, "Student1286@mail.com", 86, "Student 1286" },
                    { 1287, "Student1287@mail.com", 86, "Student 1287" },
                    { 1288, "Student1288@mail.com", 86, "Student 1288" },
                    { 1289, "Student1289@mail.com", 86, "Student 1289" },
                    { 1290, "Student1290@mail.com", 86, "Student 1290" },
                    { 1291, "Student1291@mail.com", 87, "Student 1291" },
                    { 1292, "Student1292@mail.com", 87, "Student 1292" },
                    { 1293, "Student1293@mail.com", 87, "Student 1293" },
                    { 1294, "Student1294@mail.com", 87, "Student 1294" },
                    { 1295, "Student1295@mail.com", 87, "Student 1295" },
                    { 1296, "Student1296@mail.com", 87, "Student 1296" },
                    { 1297, "Student1297@mail.com", 87, "Student 1297" },
                    { 1298, "Student1298@mail.com", 87, "Student 1298" },
                    { 1299, "Student1299@mail.com", 87, "Student 1299" },
                    { 1300, "Student1300@mail.com", 87, "Student 1300" },
                    { 1301, "Student1301@mail.com", 87, "Student 1301" },
                    { 1302, "Student1302@mail.com", 87, "Student 1302" },
                    { 1303, "Student1303@mail.com", 87, "Student 1303" },
                    { 1304, "Student1304@mail.com", 87, "Student 1304" },
                    { 1305, "Student1305@mail.com", 87, "Student 1305" },
                    { 1306, "Student1306@mail.com", 88, "Student 1306" },
                    { 1307, "Student1307@mail.com", 88, "Student 1307" },
                    { 1308, "Student1308@mail.com", 88, "Student 1308" },
                    { 1309, "Student1309@mail.com", 88, "Student 1309" },
                    { 1310, "Student1310@mail.com", 88, "Student 1310" },
                    { 1311, "Student1311@mail.com", 88, "Student 1311" },
                    { 1312, "Student1312@mail.com", 88, "Student 1312" },
                    { 1313, "Student1313@mail.com", 88, "Student 1313" },
                    { 1314, "Student1314@mail.com", 88, "Student 1314" },
                    { 1315, "Student1315@mail.com", 88, "Student 1315" },
                    { 1316, "Student1316@mail.com", 88, "Student 1316" },
                    { 1317, "Student1317@mail.com", 88, "Student 1317" },
                    { 1318, "Student1318@mail.com", 88, "Student 1318" },
                    { 1319, "Student1319@mail.com", 88, "Student 1319" },
                    { 1320, "Student1320@mail.com", 88, "Student 1320" },
                    { 1321, "Student1321@mail.com", 89, "Student 1321" },
                    { 1322, "Student1322@mail.com", 89, "Student 1322" },
                    { 1323, "Student1323@mail.com", 89, "Student 1323" },
                    { 1324, "Student1324@mail.com", 89, "Student 1324" },
                    { 1325, "Student1325@mail.com", 89, "Student 1325" },
                    { 1326, "Student1326@mail.com", 89, "Student 1326" },
                    { 1327, "Student1327@mail.com", 89, "Student 1327" },
                    { 1328, "Student1328@mail.com", 89, "Student 1328" },
                    { 1329, "Student1329@mail.com", 89, "Student 1329" },
                    { 1330, "Student1330@mail.com", 89, "Student 1330" },
                    { 1331, "Student1331@mail.com", 89, "Student 1331" },
                    { 1332, "Student1332@mail.com", 89, "Student 1332" },
                    { 1333, "Student1333@mail.com", 89, "Student 1333" },
                    { 1334, "Student1334@mail.com", 89, "Student 1334" },
                    { 1335, "Student1335@mail.com", 89, "Student 1335" },
                    { 1336, "Student1336@mail.com", 90, "Student 1336" },
                    { 1337, "Student1337@mail.com", 90, "Student 1337" },
                    { 1338, "Student1338@mail.com", 90, "Student 1338" },
                    { 1339, "Student1339@mail.com", 90, "Student 1339" },
                    { 1340, "Student1340@mail.com", 90, "Student 1340" },
                    { 1341, "Student1341@mail.com", 90, "Student 1341" },
                    { 1342, "Student1342@mail.com", 90, "Student 1342" },
                    { 1343, "Student1343@mail.com", 90, "Student 1343" },
                    { 1344, "Student1344@mail.com", 90, "Student 1344" },
                    { 1345, "Student1345@mail.com", 90, "Student 1345" },
                    { 1346, "Student1346@mail.com", 90, "Student 1346" },
                    { 1347, "Student1347@mail.com", 90, "Student 1347" },
                    { 1348, "Student1348@mail.com", 90, "Student 1348" },
                    { 1349, "Student1349@mail.com", 90, "Student 1349" },
                    { 1350, "Student1350@mail.com", 90, "Student 1350" },
                    { 1351, "Student1351@mail.com", 91, "Student 1351" },
                    { 1352, "Student1352@mail.com", 91, "Student 1352" },
                    { 1353, "Student1353@mail.com", 91, "Student 1353" },
                    { 1354, "Student1354@mail.com", 91, "Student 1354" },
                    { 1355, "Student1355@mail.com", 91, "Student 1355" },
                    { 1356, "Student1356@mail.com", 91, "Student 1356" },
                    { 1357, "Student1357@mail.com", 91, "Student 1357" },
                    { 1358, "Student1358@mail.com", 91, "Student 1358" },
                    { 1359, "Student1359@mail.com", 91, "Student 1359" },
                    { 1360, "Student1360@mail.com", 91, "Student 1360" },
                    { 1361, "Student1361@mail.com", 91, "Student 1361" },
                    { 1362, "Student1362@mail.com", 91, "Student 1362" },
                    { 1363, "Student1363@mail.com", 91, "Student 1363" },
                    { 1364, "Student1364@mail.com", 91, "Student 1364" },
                    { 1365, "Student1365@mail.com", 91, "Student 1365" },
                    { 1366, "Student1366@mail.com", 92, "Student 1366" },
                    { 1367, "Student1367@mail.com", 92, "Student 1367" },
                    { 1368, "Student1368@mail.com", 92, "Student 1368" },
                    { 1369, "Student1369@mail.com", 92, "Student 1369" },
                    { 1370, "Student1370@mail.com", 92, "Student 1370" },
                    { 1371, "Student1371@mail.com", 92, "Student 1371" },
                    { 1372, "Student1372@mail.com", 92, "Student 1372" },
                    { 1373, "Student1373@mail.com", 92, "Student 1373" },
                    { 1374, "Student1374@mail.com", 92, "Student 1374" },
                    { 1375, "Student1375@mail.com", 92, "Student 1375" },
                    { 1376, "Student1376@mail.com", 92, "Student 1376" },
                    { 1377, "Student1377@mail.com", 92, "Student 1377" },
                    { 1378, "Student1378@mail.com", 92, "Student 1378" },
                    { 1379, "Student1379@mail.com", 92, "Student 1379" },
                    { 1380, "Student1380@mail.com", 92, "Student 1380" },
                    { 1381, "Student1381@mail.com", 93, "Student 1381" },
                    { 1382, "Student1382@mail.com", 93, "Student 1382" },
                    { 1383, "Student1383@mail.com", 93, "Student 1383" },
                    { 1384, "Student1384@mail.com", 93, "Student 1384" },
                    { 1385, "Student1385@mail.com", 93, "Student 1385" },
                    { 1386, "Student1386@mail.com", 93, "Student 1386" },
                    { 1387, "Student1387@mail.com", 93, "Student 1387" },
                    { 1388, "Student1388@mail.com", 93, "Student 1388" },
                    { 1389, "Student1389@mail.com", 93, "Student 1389" },
                    { 1390, "Student1390@mail.com", 93, "Student 1390" },
                    { 1391, "Student1391@mail.com", 93, "Student 1391" },
                    { 1392, "Student1392@mail.com", 93, "Student 1392" },
                    { 1393, "Student1393@mail.com", 93, "Student 1393" },
                    { 1394, "Student1394@mail.com", 93, "Student 1394" },
                    { 1395, "Student1395@mail.com", 93, "Student 1395" },
                    { 1396, "Student1396@mail.com", 94, "Student 1396" },
                    { 1397, "Student1397@mail.com", 94, "Student 1397" },
                    { 1398, "Student1398@mail.com", 94, "Student 1398" },
                    { 1399, "Student1399@mail.com", 94, "Student 1399" },
                    { 1400, "Student1400@mail.com", 94, "Student 1400" },
                    { 1401, "Student1401@mail.com", 94, "Student 1401" },
                    { 1402, "Student1402@mail.com", 94, "Student 1402" },
                    { 1403, "Student1403@mail.com", 94, "Student 1403" },
                    { 1404, "Student1404@mail.com", 94, "Student 1404" },
                    { 1405, "Student1405@mail.com", 94, "Student 1405" },
                    { 1406, "Student1406@mail.com", 94, "Student 1406" },
                    { 1407, "Student1407@mail.com", 94, "Student 1407" },
                    { 1408, "Student1408@mail.com", 94, "Student 1408" },
                    { 1409, "Student1409@mail.com", 94, "Student 1409" },
                    { 1410, "Student1410@mail.com", 94, "Student 1410" },
                    { 1411, "Student1411@mail.com", 95, "Student 1411" },
                    { 1412, "Student1412@mail.com", 95, "Student 1412" },
                    { 1413, "Student1413@mail.com", 95, "Student 1413" },
                    { 1414, "Student1414@mail.com", 95, "Student 1414" },
                    { 1415, "Student1415@mail.com", 95, "Student 1415" },
                    { 1416, "Student1416@mail.com", 95, "Student 1416" },
                    { 1417, "Student1417@mail.com", 95, "Student 1417" },
                    { 1418, "Student1418@mail.com", 95, "Student 1418" },
                    { 1419, "Student1419@mail.com", 95, "Student 1419" },
                    { 1420, "Student1420@mail.com", 95, "Student 1420" },
                    { 1421, "Student1421@mail.com", 95, "Student 1421" },
                    { 1422, "Student1422@mail.com", 95, "Student 1422" },
                    { 1423, "Student1423@mail.com", 95, "Student 1423" },
                    { 1424, "Student1424@mail.com", 95, "Student 1424" },
                    { 1425, "Student1425@mail.com", 95, "Student 1425" },
                    { 1426, "Student1426@mail.com", 96, "Student 1426" },
                    { 1427, "Student1427@mail.com", 96, "Student 1427" },
                    { 1428, "Student1428@mail.com", 96, "Student 1428" },
                    { 1429, "Student1429@mail.com", 96, "Student 1429" },
                    { 1430, "Student1430@mail.com", 96, "Student 1430" },
                    { 1431, "Student1431@mail.com", 96, "Student 1431" },
                    { 1432, "Student1432@mail.com", 96, "Student 1432" },
                    { 1433, "Student1433@mail.com", 96, "Student 1433" },
                    { 1434, "Student1434@mail.com", 96, "Student 1434" },
                    { 1435, "Student1435@mail.com", 96, "Student 1435" },
                    { 1436, "Student1436@mail.com", 96, "Student 1436" },
                    { 1437, "Student1437@mail.com", 96, "Student 1437" },
                    { 1438, "Student1438@mail.com", 96, "Student 1438" },
                    { 1439, "Student1439@mail.com", 96, "Student 1439" },
                    { 1440, "Student1440@mail.com", 96, "Student 1440" },
                    { 1441, "Student1441@mail.com", 97, "Student 1441" },
                    { 1442, "Student1442@mail.com", 97, "Student 1442" },
                    { 1443, "Student1443@mail.com", 97, "Student 1443" },
                    { 1444, "Student1444@mail.com", 97, "Student 1444" },
                    { 1445, "Student1445@mail.com", 97, "Student 1445" },
                    { 1446, "Student1446@mail.com", 97, "Student 1446" },
                    { 1447, "Student1447@mail.com", 97, "Student 1447" },
                    { 1448, "Student1448@mail.com", 97, "Student 1448" },
                    { 1449, "Student1449@mail.com", 97, "Student 1449" },
                    { 1450, "Student1450@mail.com", 97, "Student 1450" },
                    { 1451, "Student1451@mail.com", 97, "Student 1451" },
                    { 1452, "Student1452@mail.com", 97, "Student 1452" },
                    { 1453, "Student1453@mail.com", 97, "Student 1453" },
                    { 1454, "Student1454@mail.com", 97, "Student 1454" },
                    { 1455, "Student1455@mail.com", 97, "Student 1455" },
                    { 1456, "Student1456@mail.com", 98, "Student 1456" },
                    { 1457, "Student1457@mail.com", 98, "Student 1457" },
                    { 1458, "Student1458@mail.com", 98, "Student 1458" },
                    { 1459, "Student1459@mail.com", 98, "Student 1459" },
                    { 1460, "Student1460@mail.com", 98, "Student 1460" },
                    { 1461, "Student1461@mail.com", 98, "Student 1461" },
                    { 1462, "Student1462@mail.com", 98, "Student 1462" },
                    { 1463, "Student1463@mail.com", 98, "Student 1463" },
                    { 1464, "Student1464@mail.com", 98, "Student 1464" },
                    { 1465, "Student1465@mail.com", 98, "Student 1465" },
                    { 1466, "Student1466@mail.com", 98, "Student 1466" },
                    { 1467, "Student1467@mail.com", 98, "Student 1467" },
                    { 1468, "Student1468@mail.com", 98, "Student 1468" },
                    { 1469, "Student1469@mail.com", 98, "Student 1469" },
                    { 1470, "Student1470@mail.com", 98, "Student 1470" },
                    { 1471, "Student1471@mail.com", 99, "Student 1471" },
                    { 1472, "Student1472@mail.com", 99, "Student 1472" },
                    { 1473, "Student1473@mail.com", 99, "Student 1473" },
                    { 1474, "Student1474@mail.com", 99, "Student 1474" },
                    { 1475, "Student1475@mail.com", 99, "Student 1475" },
                    { 1476, "Student1476@mail.com", 99, "Student 1476" },
                    { 1477, "Student1477@mail.com", 99, "Student 1477" },
                    { 1478, "Student1478@mail.com", 99, "Student 1478" },
                    { 1479, "Student1479@mail.com", 99, "Student 1479" },
                    { 1480, "Student1480@mail.com", 99, "Student 1480" },
                    { 1481, "Student1481@mail.com", 99, "Student 1481" },
                    { 1482, "Student1482@mail.com", 99, "Student 1482" },
                    { 1483, "Student1483@mail.com", 99, "Student 1483" },
                    { 1484, "Student1484@mail.com", 99, "Student 1484" },
                    { 1485, "Student1485@mail.com", 99, "Student 1485" },
                    { 1486, "Student1486@mail.com", 100, "Student 1486" },
                    { 1487, "Student1487@mail.com", 100, "Student 1487" },
                    { 1488, "Student1488@mail.com", 100, "Student 1488" },
                    { 1489, "Student1489@mail.com", 100, "Student 1489" },
                    { 1490, "Student1490@mail.com", 100, "Student 1490" },
                    { 1491, "Student1491@mail.com", 100, "Student 1491" },
                    { 1492, "Student1492@mail.com", 100, "Student 1492" },
                    { 1493, "Student1493@mail.com", 100, "Student 1493" },
                    { 1494, "Student1494@mail.com", 100, "Student 1494" },
                    { 1495, "Student1495@mail.com", 100, "Student 1495" },
                    { 1496, "Student1496@mail.com", 100, "Student 1496" },
                    { 1497, "Student1497@mail.com", 100, "Student 1497" },
                    { 1498, "Student1498@mail.com", 100, "Student 1498" },
                    { 1499, "Student1499@mail.com", 100, "Student 1499" },
                    { 1500, "Student1500@mail.com", 100, "Student 1500" },
                    { 1501, "Student1501@mail.com", 101, "Student 1501" },
                    { 1502, "Student1502@mail.com", 101, "Student 1502" },
                    { 1503, "Student1503@mail.com", 101, "Student 1503" },
                    { 1504, "Student1504@mail.com", 101, "Student 1504" },
                    { 1505, "Student1505@mail.com", 101, "Student 1505" },
                    { 1506, "Student1506@mail.com", 101, "Student 1506" },
                    { 1507, "Student1507@mail.com", 101, "Student 1507" },
                    { 1508, "Student1508@mail.com", 101, "Student 1508" },
                    { 1509, "Student1509@mail.com", 101, "Student 1509" },
                    { 1510, "Student1510@mail.com", 101, "Student 1510" },
                    { 1511, "Student1511@mail.com", 101, "Student 1511" },
                    { 1512, "Student1512@mail.com", 101, "Student 1512" },
                    { 1513, "Student1513@mail.com", 101, "Student 1513" },
                    { 1514, "Student1514@mail.com", 101, "Student 1514" },
                    { 1515, "Student1515@mail.com", 101, "Student 1515" },
                    { 1516, "Student1516@mail.com", 102, "Student 1516" },
                    { 1517, "Student1517@mail.com", 102, "Student 1517" },
                    { 1518, "Student1518@mail.com", 102, "Student 1518" },
                    { 1519, "Student1519@mail.com", 102, "Student 1519" },
                    { 1520, "Student1520@mail.com", 102, "Student 1520" },
                    { 1521, "Student1521@mail.com", 102, "Student 1521" },
                    { 1522, "Student1522@mail.com", 102, "Student 1522" },
                    { 1523, "Student1523@mail.com", 102, "Student 1523" },
                    { 1524, "Student1524@mail.com", 102, "Student 1524" },
                    { 1525, "Student1525@mail.com", 102, "Student 1525" },
                    { 1526, "Student1526@mail.com", 102, "Student 1526" },
                    { 1527, "Student1527@mail.com", 102, "Student 1527" },
                    { 1528, "Student1528@mail.com", 102, "Student 1528" },
                    { 1529, "Student1529@mail.com", 102, "Student 1529" },
                    { 1530, "Student1530@mail.com", 102, "Student 1530" },
                    { 1531, "Student1531@mail.com", 103, "Student 1531" },
                    { 1532, "Student1532@mail.com", 103, "Student 1532" },
                    { 1533, "Student1533@mail.com", 103, "Student 1533" },
                    { 1534, "Student1534@mail.com", 103, "Student 1534" },
                    { 1535, "Student1535@mail.com", 103, "Student 1535" },
                    { 1536, "Student1536@mail.com", 103, "Student 1536" },
                    { 1537, "Student1537@mail.com", 103, "Student 1537" },
                    { 1538, "Student1538@mail.com", 103, "Student 1538" },
                    { 1539, "Student1539@mail.com", 103, "Student 1539" },
                    { 1540, "Student1540@mail.com", 103, "Student 1540" },
                    { 1541, "Student1541@mail.com", 103, "Student 1541" },
                    { 1542, "Student1542@mail.com", 103, "Student 1542" },
                    { 1543, "Student1543@mail.com", 103, "Student 1543" },
                    { 1544, "Student1544@mail.com", 103, "Student 1544" },
                    { 1545, "Student1545@mail.com", 103, "Student 1545" },
                    { 1546, "Student1546@mail.com", 104, "Student 1546" },
                    { 1547, "Student1547@mail.com", 104, "Student 1547" },
                    { 1548, "Student1548@mail.com", 104, "Student 1548" },
                    { 1549, "Student1549@mail.com", 104, "Student 1549" },
                    { 1550, "Student1550@mail.com", 104, "Student 1550" },
                    { 1551, "Student1551@mail.com", 104, "Student 1551" },
                    { 1552, "Student1552@mail.com", 104, "Student 1552" },
                    { 1553, "Student1553@mail.com", 104, "Student 1553" },
                    { 1554, "Student1554@mail.com", 104, "Student 1554" },
                    { 1555, "Student1555@mail.com", 104, "Student 1555" },
                    { 1556, "Student1556@mail.com", 104, "Student 1556" },
                    { 1557, "Student1557@mail.com", 104, "Student 1557" },
                    { 1558, "Student1558@mail.com", 104, "Student 1558" },
                    { 1559, "Student1559@mail.com", 104, "Student 1559" },
                    { 1560, "Student1560@mail.com", 104, "Student 1560" },
                    { 1561, "Student1561@mail.com", 105, "Student 1561" },
                    { 1562, "Student1562@mail.com", 105, "Student 1562" },
                    { 1563, "Student1563@mail.com", 105, "Student 1563" },
                    { 1564, "Student1564@mail.com", 105, "Student 1564" },
                    { 1565, "Student1565@mail.com", 105, "Student 1565" },
                    { 1566, "Student1566@mail.com", 105, "Student 1566" },
                    { 1567, "Student1567@mail.com", 105, "Student 1567" },
                    { 1568, "Student1568@mail.com", 105, "Student 1568" },
                    { 1569, "Student1569@mail.com", 105, "Student 1569" },
                    { 1570, "Student1570@mail.com", 105, "Student 1570" },
                    { 1571, "Student1571@mail.com", 105, "Student 1571" },
                    { 1572, "Student1572@mail.com", 105, "Student 1572" },
                    { 1573, "Student1573@mail.com", 105, "Student 1573" },
                    { 1574, "Student1574@mail.com", 105, "Student 1574" },
                    { 1575, "Student1575@mail.com", 105, "Student 1575" },
                    { 1576, "Student1576@mail.com", 106, "Student 1576" },
                    { 1577, "Student1577@mail.com", 106, "Student 1577" },
                    { 1578, "Student1578@mail.com", 106, "Student 1578" },
                    { 1579, "Student1579@mail.com", 106, "Student 1579" },
                    { 1580, "Student1580@mail.com", 106, "Student 1580" },
                    { 1581, "Student1581@mail.com", 106, "Student 1581" },
                    { 1582, "Student1582@mail.com", 106, "Student 1582" },
                    { 1583, "Student1583@mail.com", 106, "Student 1583" },
                    { 1584, "Student1584@mail.com", 106, "Student 1584" },
                    { 1585, "Student1585@mail.com", 106, "Student 1585" },
                    { 1586, "Student1586@mail.com", 106, "Student 1586" },
                    { 1587, "Student1587@mail.com", 106, "Student 1587" },
                    { 1588, "Student1588@mail.com", 106, "Student 1588" },
                    { 1589, "Student1589@mail.com", 106, "Student 1589" },
                    { 1590, "Student1590@mail.com", 106, "Student 1590" },
                    { 1591, "Student1591@mail.com", 107, "Student 1591" },
                    { 1592, "Student1592@mail.com", 107, "Student 1592" },
                    { 1593, "Student1593@mail.com", 107, "Student 1593" },
                    { 1594, "Student1594@mail.com", 107, "Student 1594" },
                    { 1595, "Student1595@mail.com", 107, "Student 1595" },
                    { 1596, "Student1596@mail.com", 107, "Student 1596" },
                    { 1597, "Student1597@mail.com", 107, "Student 1597" },
                    { 1598, "Student1598@mail.com", 107, "Student 1598" },
                    { 1599, "Student1599@mail.com", 107, "Student 1599" },
                    { 1600, "Student1600@mail.com", 107, "Student 1600" },
                    { 1601, "Student1601@mail.com", 107, "Student 1601" },
                    { 1602, "Student1602@mail.com", 107, "Student 1602" },
                    { 1603, "Student1603@mail.com", 107, "Student 1603" },
                    { 1604, "Student1604@mail.com", 107, "Student 1604" },
                    { 1605, "Student1605@mail.com", 107, "Student 1605" },
                    { 1606, "Student1606@mail.com", 108, "Student 1606" },
                    { 1607, "Student1607@mail.com", 108, "Student 1607" },
                    { 1608, "Student1608@mail.com", 108, "Student 1608" },
                    { 1609, "Student1609@mail.com", 108, "Student 1609" },
                    { 1610, "Student1610@mail.com", 108, "Student 1610" },
                    { 1611, "Student1611@mail.com", 108, "Student 1611" },
                    { 1612, "Student1612@mail.com", 108, "Student 1612" },
                    { 1613, "Student1613@mail.com", 108, "Student 1613" },
                    { 1614, "Student1614@mail.com", 108, "Student 1614" },
                    { 1615, "Student1615@mail.com", 108, "Student 1615" },
                    { 1616, "Student1616@mail.com", 108, "Student 1616" },
                    { 1617, "Student1617@mail.com", 108, "Student 1617" },
                    { 1618, "Student1618@mail.com", 108, "Student 1618" },
                    { 1619, "Student1619@mail.com", 108, "Student 1619" },
                    { 1620, "Student1620@mail.com", 108, "Student 1620" },
                    { 1621, "Student1621@mail.com", 109, "Student 1621" },
                    { 1622, "Student1622@mail.com", 109, "Student 1622" },
                    { 1623, "Student1623@mail.com", 109, "Student 1623" },
                    { 1624, "Student1624@mail.com", 109, "Student 1624" },
                    { 1625, "Student1625@mail.com", 109, "Student 1625" },
                    { 1626, "Student1626@mail.com", 109, "Student 1626" },
                    { 1627, "Student1627@mail.com", 109, "Student 1627" },
                    { 1628, "Student1628@mail.com", 109, "Student 1628" },
                    { 1629, "Student1629@mail.com", 109, "Student 1629" },
                    { 1630, "Student1630@mail.com", 109, "Student 1630" },
                    { 1631, "Student1631@mail.com", 109, "Student 1631" },
                    { 1632, "Student1632@mail.com", 109, "Student 1632" },
                    { 1633, "Student1633@mail.com", 109, "Student 1633" },
                    { 1634, "Student1634@mail.com", 109, "Student 1634" },
                    { 1635, "Student1635@mail.com", 109, "Student 1635" },
                    { 1636, "Student1636@mail.com", 110, "Student 1636" },
                    { 1637, "Student1637@mail.com", 110, "Student 1637" },
                    { 1638, "Student1638@mail.com", 110, "Student 1638" },
                    { 1639, "Student1639@mail.com", 110, "Student 1639" },
                    { 1640, "Student1640@mail.com", 110, "Student 1640" },
                    { 1641, "Student1641@mail.com", 110, "Student 1641" },
                    { 1642, "Student1642@mail.com", 110, "Student 1642" },
                    { 1643, "Student1643@mail.com", 110, "Student 1643" },
                    { 1644, "Student1644@mail.com", 110, "Student 1644" },
                    { 1645, "Student1645@mail.com", 110, "Student 1645" },
                    { 1646, "Student1646@mail.com", 110, "Student 1646" },
                    { 1647, "Student1647@mail.com", 110, "Student 1647" },
                    { 1648, "Student1648@mail.com", 110, "Student 1648" },
                    { 1649, "Student1649@mail.com", 110, "Student 1649" },
                    { 1650, "Student1650@mail.com", 110, "Student 1650" },
                    { 1651, "Student1651@mail.com", 111, "Student 1651" },
                    { 1652, "Student1652@mail.com", 111, "Student 1652" },
                    { 1653, "Student1653@mail.com", 111, "Student 1653" },
                    { 1654, "Student1654@mail.com", 111, "Student 1654" },
                    { 1655, "Student1655@mail.com", 111, "Student 1655" },
                    { 1656, "Student1656@mail.com", 111, "Student 1656" },
                    { 1657, "Student1657@mail.com", 111, "Student 1657" },
                    { 1658, "Student1658@mail.com", 111, "Student 1658" },
                    { 1659, "Student1659@mail.com", 111, "Student 1659" },
                    { 1660, "Student1660@mail.com", 111, "Student 1660" },
                    { 1661, "Student1661@mail.com", 111, "Student 1661" },
                    { 1662, "Student1662@mail.com", 111, "Student 1662" },
                    { 1663, "Student1663@mail.com", 111, "Student 1663" },
                    { 1664, "Student1664@mail.com", 111, "Student 1664" },
                    { 1665, "Student1665@mail.com", 111, "Student 1665" },
                    { 1666, "Student1666@mail.com", 112, "Student 1666" },
                    { 1667, "Student1667@mail.com", 112, "Student 1667" },
                    { 1668, "Student1668@mail.com", 112, "Student 1668" },
                    { 1669, "Student1669@mail.com", 112, "Student 1669" },
                    { 1670, "Student1670@mail.com", 112, "Student 1670" },
                    { 1671, "Student1671@mail.com", 112, "Student 1671" },
                    { 1672, "Student1672@mail.com", 112, "Student 1672" },
                    { 1673, "Student1673@mail.com", 112, "Student 1673" },
                    { 1674, "Student1674@mail.com", 112, "Student 1674" },
                    { 1675, "Student1675@mail.com", 112, "Student 1675" },
                    { 1676, "Student1676@mail.com", 112, "Student 1676" },
                    { 1677, "Student1677@mail.com", 112, "Student 1677" },
                    { 1678, "Student1678@mail.com", 112, "Student 1678" },
                    { 1679, "Student1679@mail.com", 112, "Student 1679" },
                    { 1680, "Student1680@mail.com", 112, "Student 1680" },
                    { 1681, "Student1681@mail.com", 113, "Student 1681" },
                    { 1682, "Student1682@mail.com", 113, "Student 1682" },
                    { 1683, "Student1683@mail.com", 113, "Student 1683" },
                    { 1684, "Student1684@mail.com", 113, "Student 1684" },
                    { 1685, "Student1685@mail.com", 113, "Student 1685" },
                    { 1686, "Student1686@mail.com", 113, "Student 1686" },
                    { 1687, "Student1687@mail.com", 113, "Student 1687" },
                    { 1688, "Student1688@mail.com", 113, "Student 1688" },
                    { 1689, "Student1689@mail.com", 113, "Student 1689" },
                    { 1690, "Student1690@mail.com", 113, "Student 1690" },
                    { 1691, "Student1691@mail.com", 113, "Student 1691" },
                    { 1692, "Student1692@mail.com", 113, "Student 1692" },
                    { 1693, "Student1693@mail.com", 113, "Student 1693" },
                    { 1694, "Student1694@mail.com", 113, "Student 1694" },
                    { 1695, "Student1695@mail.com", 113, "Student 1695" },
                    { 1696, "Student1696@mail.com", 114, "Student 1696" },
                    { 1697, "Student1697@mail.com", 114, "Student 1697" },
                    { 1698, "Student1698@mail.com", 114, "Student 1698" },
                    { 1699, "Student1699@mail.com", 114, "Student 1699" },
                    { 1700, "Student1700@mail.com", 114, "Student 1700" },
                    { 1701, "Student1701@mail.com", 114, "Student 1701" },
                    { 1702, "Student1702@mail.com", 114, "Student 1702" },
                    { 1703, "Student1703@mail.com", 114, "Student 1703" },
                    { 1704, "Student1704@mail.com", 114, "Student 1704" },
                    { 1705, "Student1705@mail.com", 114, "Student 1705" },
                    { 1706, "Student1706@mail.com", 114, "Student 1706" },
                    { 1707, "Student1707@mail.com", 114, "Student 1707" },
                    { 1708, "Student1708@mail.com", 114, "Student 1708" },
                    { 1709, "Student1709@mail.com", 114, "Student 1709" },
                    { 1710, "Student1710@mail.com", 114, "Student 1710" },
                    { 1711, "Student1711@mail.com", 115, "Student 1711" },
                    { 1712, "Student1712@mail.com", 115, "Student 1712" },
                    { 1713, "Student1713@mail.com", 115, "Student 1713" },
                    { 1714, "Student1714@mail.com", 115, "Student 1714" },
                    { 1715, "Student1715@mail.com", 115, "Student 1715" },
                    { 1716, "Student1716@mail.com", 115, "Student 1716" },
                    { 1717, "Student1717@mail.com", 115, "Student 1717" },
                    { 1718, "Student1718@mail.com", 115, "Student 1718" },
                    { 1719, "Student1719@mail.com", 115, "Student 1719" },
                    { 1720, "Student1720@mail.com", 115, "Student 1720" },
                    { 1721, "Student1721@mail.com", 115, "Student 1721" },
                    { 1722, "Student1722@mail.com", 115, "Student 1722" },
                    { 1723, "Student1723@mail.com", 115, "Student 1723" },
                    { 1724, "Student1724@mail.com", 115, "Student 1724" },
                    { 1725, "Student1725@mail.com", 115, "Student 1725" },
                    { 1726, "Student1726@mail.com", 116, "Student 1726" },
                    { 1727, "Student1727@mail.com", 116, "Student 1727" },
                    { 1728, "Student1728@mail.com", 116, "Student 1728" },
                    { 1729, "Student1729@mail.com", 116, "Student 1729" },
                    { 1730, "Student1730@mail.com", 116, "Student 1730" },
                    { 1731, "Student1731@mail.com", 116, "Student 1731" },
                    { 1732, "Student1732@mail.com", 116, "Student 1732" },
                    { 1733, "Student1733@mail.com", 116, "Student 1733" },
                    { 1734, "Student1734@mail.com", 116, "Student 1734" },
                    { 1735, "Student1735@mail.com", 116, "Student 1735" },
                    { 1736, "Student1736@mail.com", 116, "Student 1736" },
                    { 1737, "Student1737@mail.com", 116, "Student 1737" },
                    { 1738, "Student1738@mail.com", 116, "Student 1738" },
                    { 1739, "Student1739@mail.com", 116, "Student 1739" },
                    { 1740, "Student1740@mail.com", 116, "Student 1740" },
                    { 1741, "Student1741@mail.com", 117, "Student 1741" },
                    { 1742, "Student1742@mail.com", 117, "Student 1742" },
                    { 1743, "Student1743@mail.com", 117, "Student 1743" },
                    { 1744, "Student1744@mail.com", 117, "Student 1744" },
                    { 1745, "Student1745@mail.com", 117, "Student 1745" },
                    { 1746, "Student1746@mail.com", 117, "Student 1746" },
                    { 1747, "Student1747@mail.com", 117, "Student 1747" },
                    { 1748, "Student1748@mail.com", 117, "Student 1748" },
                    { 1749, "Student1749@mail.com", 117, "Student 1749" },
                    { 1750, "Student1750@mail.com", 117, "Student 1750" },
                    { 1751, "Student1751@mail.com", 117, "Student 1751" },
                    { 1752, "Student1752@mail.com", 117, "Student 1752" },
                    { 1753, "Student1753@mail.com", 117, "Student 1753" },
                    { 1754, "Student1754@mail.com", 117, "Student 1754" },
                    { 1755, "Student1755@mail.com", 117, "Student 1755" },
                    { 1756, "Student1756@mail.com", 118, "Student 1756" },
                    { 1757, "Student1757@mail.com", 118, "Student 1757" },
                    { 1758, "Student1758@mail.com", 118, "Student 1758" },
                    { 1759, "Student1759@mail.com", 118, "Student 1759" },
                    { 1760, "Student1760@mail.com", 118, "Student 1760" },
                    { 1761, "Student1761@mail.com", 118, "Student 1761" },
                    { 1762, "Student1762@mail.com", 118, "Student 1762" },
                    { 1763, "Student1763@mail.com", 118, "Student 1763" },
                    { 1764, "Student1764@mail.com", 118, "Student 1764" },
                    { 1765, "Student1765@mail.com", 118, "Student 1765" },
                    { 1766, "Student1766@mail.com", 118, "Student 1766" },
                    { 1767, "Student1767@mail.com", 118, "Student 1767" },
                    { 1768, "Student1768@mail.com", 118, "Student 1768" },
                    { 1769, "Student1769@mail.com", 118, "Student 1769" },
                    { 1770, "Student1770@mail.com", 118, "Student 1770" },
                    { 1771, "Student1771@mail.com", 119, "Student 1771" },
                    { 1772, "Student1772@mail.com", 119, "Student 1772" },
                    { 1773, "Student1773@mail.com", 119, "Student 1773" },
                    { 1774, "Student1774@mail.com", 119, "Student 1774" },
                    { 1775, "Student1775@mail.com", 119, "Student 1775" },
                    { 1776, "Student1776@mail.com", 119, "Student 1776" },
                    { 1777, "Student1777@mail.com", 119, "Student 1777" },
                    { 1778, "Student1778@mail.com", 119, "Student 1778" },
                    { 1779, "Student1779@mail.com", 119, "Student 1779" },
                    { 1780, "Student1780@mail.com", 119, "Student 1780" },
                    { 1781, "Student1781@mail.com", 119, "Student 1781" },
                    { 1782, "Student1782@mail.com", 119, "Student 1782" },
                    { 1783, "Student1783@mail.com", 119, "Student 1783" },
                    { 1784, "Student1784@mail.com", 119, "Student 1784" },
                    { 1785, "Student1785@mail.com", 119, "Student 1785" },
                    { 1786, "Student1786@mail.com", 120, "Student 1786" },
                    { 1787, "Student1787@mail.com", 120, "Student 1787" },
                    { 1788, "Student1788@mail.com", 120, "Student 1788" },
                    { 1789, "Student1789@mail.com", 120, "Student 1789" },
                    { 1790, "Student1790@mail.com", 120, "Student 1790" },
                    { 1791, "Student1791@mail.com", 120, "Student 1791" },
                    { 1792, "Student1792@mail.com", 120, "Student 1792" },
                    { 1793, "Student1793@mail.com", 120, "Student 1793" },
                    { 1794, "Student1794@mail.com", 120, "Student 1794" },
                    { 1795, "Student1795@mail.com", 120, "Student 1795" },
                    { 1796, "Student1796@mail.com", 120, "Student 1796" },
                    { 1797, "Student1797@mail.com", 120, "Student 1797" },
                    { 1798, "Student1798@mail.com", 120, "Student 1798" },
                    { 1799, "Student1799@mail.com", 120, "Student 1799" },
                    { 1800, "Student1800@mail.com", 120, "Student 1800" },
                    { 1801, "Student1801@mail.com", 121, "Student 1801" },
                    { 1802, "Student1802@mail.com", 121, "Student 1802" },
                    { 1803, "Student1803@mail.com", 121, "Student 1803" },
                    { 1804, "Student1804@mail.com", 121, "Student 1804" },
                    { 1805, "Student1805@mail.com", 121, "Student 1805" },
                    { 1806, "Student1806@mail.com", 121, "Student 1806" },
                    { 1807, "Student1807@mail.com", 121, "Student 1807" },
                    { 1808, "Student1808@mail.com", 121, "Student 1808" },
                    { 1809, "Student1809@mail.com", 121, "Student 1809" },
                    { 1810, "Student1810@mail.com", 121, "Student 1810" },
                    { 1811, "Student1811@mail.com", 121, "Student 1811" },
                    { 1812, "Student1812@mail.com", 121, "Student 1812" },
                    { 1813, "Student1813@mail.com", 121, "Student 1813" },
                    { 1814, "Student1814@mail.com", 121, "Student 1814" },
                    { 1815, "Student1815@mail.com", 121, "Student 1815" },
                    { 1816, "Student1816@mail.com", 122, "Student 1816" },
                    { 1817, "Student1817@mail.com", 122, "Student 1817" },
                    { 1818, "Student1818@mail.com", 122, "Student 1818" },
                    { 1819, "Student1819@mail.com", 122, "Student 1819" },
                    { 1820, "Student1820@mail.com", 122, "Student 1820" },
                    { 1821, "Student1821@mail.com", 122, "Student 1821" },
                    { 1822, "Student1822@mail.com", 122, "Student 1822" },
                    { 1823, "Student1823@mail.com", 122, "Student 1823" },
                    { 1824, "Student1824@mail.com", 122, "Student 1824" },
                    { 1825, "Student1825@mail.com", 122, "Student 1825" },
                    { 1826, "Student1826@mail.com", 122, "Student 1826" },
                    { 1827, "Student1827@mail.com", 122, "Student 1827" },
                    { 1828, "Student1828@mail.com", 122, "Student 1828" },
                    { 1829, "Student1829@mail.com", 122, "Student 1829" },
                    { 1830, "Student1830@mail.com", 122, "Student 1830" },
                    { 1831, "Student1831@mail.com", 123, "Student 1831" },
                    { 1832, "Student1832@mail.com", 123, "Student 1832" },
                    { 1833, "Student1833@mail.com", 123, "Student 1833" },
                    { 1834, "Student1834@mail.com", 123, "Student 1834" },
                    { 1835, "Student1835@mail.com", 123, "Student 1835" },
                    { 1836, "Student1836@mail.com", 123, "Student 1836" },
                    { 1837, "Student1837@mail.com", 123, "Student 1837" },
                    { 1838, "Student1838@mail.com", 123, "Student 1838" },
                    { 1839, "Student1839@mail.com", 123, "Student 1839" },
                    { 1840, "Student1840@mail.com", 123, "Student 1840" },
                    { 1841, "Student1841@mail.com", 123, "Student 1841" },
                    { 1842, "Student1842@mail.com", 123, "Student 1842" },
                    { 1843, "Student1843@mail.com", 123, "Student 1843" },
                    { 1844, "Student1844@mail.com", 123, "Student 1844" },
                    { 1845, "Student1845@mail.com", 123, "Student 1845" },
                    { 1846, "Student1846@mail.com", 124, "Student 1846" },
                    { 1847, "Student1847@mail.com", 124, "Student 1847" },
                    { 1848, "Student1848@mail.com", 124, "Student 1848" },
                    { 1849, "Student1849@mail.com", 124, "Student 1849" },
                    { 1850, "Student1850@mail.com", 124, "Student 1850" },
                    { 1851, "Student1851@mail.com", 124, "Student 1851" },
                    { 1852, "Student1852@mail.com", 124, "Student 1852" },
                    { 1853, "Student1853@mail.com", 124, "Student 1853" },
                    { 1854, "Student1854@mail.com", 124, "Student 1854" },
                    { 1855, "Student1855@mail.com", 124, "Student 1855" },
                    { 1856, "Student1856@mail.com", 124, "Student 1856" },
                    { 1857, "Student1857@mail.com", 124, "Student 1857" },
                    { 1858, "Student1858@mail.com", 124, "Student 1858" },
                    { 1859, "Student1859@mail.com", 124, "Student 1859" },
                    { 1860, "Student1860@mail.com", 124, "Student 1860" },
                    { 1861, "Student1861@mail.com", 125, "Student 1861" },
                    { 1862, "Student1862@mail.com", 125, "Student 1862" },
                    { 1863, "Student1863@mail.com", 125, "Student 1863" },
                    { 1864, "Student1864@mail.com", 125, "Student 1864" },
                    { 1865, "Student1865@mail.com", 125, "Student 1865" },
                    { 1866, "Student1866@mail.com", 125, "Student 1866" },
                    { 1867, "Student1867@mail.com", 125, "Student 1867" },
                    { 1868, "Student1868@mail.com", 125, "Student 1868" },
                    { 1869, "Student1869@mail.com", 125, "Student 1869" },
                    { 1870, "Student1870@mail.com", 125, "Student 1870" },
                    { 1871, "Student1871@mail.com", 125, "Student 1871" },
                    { 1872, "Student1872@mail.com", 125, "Student 1872" },
                    { 1873, "Student1873@mail.com", 125, "Student 1873" },
                    { 1874, "Student1874@mail.com", 125, "Student 1874" },
                    { 1875, "Student1875@mail.com", 125, "Student 1875" },
                    { 1876, "Student1876@mail.com", 126, "Student 1876" },
                    { 1877, "Student1877@mail.com", 126, "Student 1877" },
                    { 1878, "Student1878@mail.com", 126, "Student 1878" },
                    { 1879, "Student1879@mail.com", 126, "Student 1879" },
                    { 1880, "Student1880@mail.com", 126, "Student 1880" },
                    { 1881, "Student1881@mail.com", 126, "Student 1881" },
                    { 1882, "Student1882@mail.com", 126, "Student 1882" },
                    { 1883, "Student1883@mail.com", 126, "Student 1883" },
                    { 1884, "Student1884@mail.com", 126, "Student 1884" },
                    { 1885, "Student1885@mail.com", 126, "Student 1885" },
                    { 1886, "Student1886@mail.com", 126, "Student 1886" },
                    { 1887, "Student1887@mail.com", 126, "Student 1887" },
                    { 1888, "Student1888@mail.com", 126, "Student 1888" },
                    { 1889, "Student1889@mail.com", 126, "Student 1889" },
                    { 1890, "Student1890@mail.com", 126, "Student 1890" },
                    { 1891, "Student1891@mail.com", 127, "Student 1891" },
                    { 1892, "Student1892@mail.com", 127, "Student 1892" },
                    { 1893, "Student1893@mail.com", 127, "Student 1893" },
                    { 1894, "Student1894@mail.com", 127, "Student 1894" },
                    { 1895, "Student1895@mail.com", 127, "Student 1895" },
                    { 1896, "Student1896@mail.com", 127, "Student 1896" },
                    { 1897, "Student1897@mail.com", 127, "Student 1897" },
                    { 1898, "Student1898@mail.com", 127, "Student 1898" },
                    { 1899, "Student1899@mail.com", 127, "Student 1899" },
                    { 1900, "Student1900@mail.com", 127, "Student 1900" },
                    { 1901, "Student1901@mail.com", 127, "Student 1901" },
                    { 1902, "Student1902@mail.com", 127, "Student 1902" },
                    { 1903, "Student1903@mail.com", 127, "Student 1903" },
                    { 1904, "Student1904@mail.com", 127, "Student 1904" },
                    { 1905, "Student1905@mail.com", 127, "Student 1905" },
                    { 1906, "Student1906@mail.com", 128, "Student 1906" },
                    { 1907, "Student1907@mail.com", 128, "Student 1907" },
                    { 1908, "Student1908@mail.com", 128, "Student 1908" },
                    { 1909, "Student1909@mail.com", 128, "Student 1909" },
                    { 1910, "Student1910@mail.com", 128, "Student 1910" },
                    { 1911, "Student1911@mail.com", 128, "Student 1911" },
                    { 1912, "Student1912@mail.com", 128, "Student 1912" },
                    { 1913, "Student1913@mail.com", 128, "Student 1913" },
                    { 1914, "Student1914@mail.com", 128, "Student 1914" },
                    { 1915, "Student1915@mail.com", 128, "Student 1915" },
                    { 1916, "Student1916@mail.com", 128, "Student 1916" },
                    { 1917, "Student1917@mail.com", 128, "Student 1917" },
                    { 1918, "Student1918@mail.com", 128, "Student 1918" },
                    { 1919, "Student1919@mail.com", 128, "Student 1919" },
                    { 1920, "Student1920@mail.com", 128, "Student 1920" },
                    { 1921, "Student1921@mail.com", 129, "Student 1921" },
                    { 1922, "Student1922@mail.com", 129, "Student 1922" },
                    { 1923, "Student1923@mail.com", 129, "Student 1923" },
                    { 1924, "Student1924@mail.com", 129, "Student 1924" },
                    { 1925, "Student1925@mail.com", 129, "Student 1925" },
                    { 1926, "Student1926@mail.com", 129, "Student 1926" },
                    { 1927, "Student1927@mail.com", 129, "Student 1927" },
                    { 1928, "Student1928@mail.com", 129, "Student 1928" },
                    { 1929, "Student1929@mail.com", 129, "Student 1929" },
                    { 1930, "Student1930@mail.com", 129, "Student 1930" },
                    { 1931, "Student1931@mail.com", 129, "Student 1931" },
                    { 1932, "Student1932@mail.com", 129, "Student 1932" },
                    { 1933, "Student1933@mail.com", 129, "Student 1933" },
                    { 1934, "Student1934@mail.com", 129, "Student 1934" },
                    { 1935, "Student1935@mail.com", 129, "Student 1935" },
                    { 1936, "Student1936@mail.com", 130, "Student 1936" },
                    { 1937, "Student1937@mail.com", 130, "Student 1937" },
                    { 1938, "Student1938@mail.com", 130, "Student 1938" },
                    { 1939, "Student1939@mail.com", 130, "Student 1939" },
                    { 1940, "Student1940@mail.com", 130, "Student 1940" },
                    { 1941, "Student1941@mail.com", 130, "Student 1941" },
                    { 1942, "Student1942@mail.com", 130, "Student 1942" },
                    { 1943, "Student1943@mail.com", 130, "Student 1943" },
                    { 1944, "Student1944@mail.com", 130, "Student 1944" },
                    { 1945, "Student1945@mail.com", 130, "Student 1945" },
                    { 1946, "Student1946@mail.com", 130, "Student 1946" },
                    { 1947, "Student1947@mail.com", 130, "Student 1947" },
                    { 1948, "Student1948@mail.com", 130, "Student 1948" },
                    { 1949, "Student1949@mail.com", 130, "Student 1949" },
                    { 1950, "Student1950@mail.com", 130, "Student 1950" },
                    { 1951, "Student1951@mail.com", 131, "Student 1951" },
                    { 1952, "Student1952@mail.com", 131, "Student 1952" },
                    { 1953, "Student1953@mail.com", 131, "Student 1953" },
                    { 1954, "Student1954@mail.com", 131, "Student 1954" },
                    { 1955, "Student1955@mail.com", 131, "Student 1955" },
                    { 1956, "Student1956@mail.com", 131, "Student 1956" },
                    { 1957, "Student1957@mail.com", 131, "Student 1957" },
                    { 1958, "Student1958@mail.com", 131, "Student 1958" },
                    { 1959, "Student1959@mail.com", 131, "Student 1959" },
                    { 1960, "Student1960@mail.com", 131, "Student 1960" },
                    { 1961, "Student1961@mail.com", 131, "Student 1961" },
                    { 1962, "Student1962@mail.com", 131, "Student 1962" },
                    { 1963, "Student1963@mail.com", 131, "Student 1963" },
                    { 1964, "Student1964@mail.com", 131, "Student 1964" },
                    { 1965, "Student1965@mail.com", 131, "Student 1965" },
                    { 1966, "Student1966@mail.com", 132, "Student 1966" },
                    { 1967, "Student1967@mail.com", 132, "Student 1967" },
                    { 1968, "Student1968@mail.com", 132, "Student 1968" },
                    { 1969, "Student1969@mail.com", 132, "Student 1969" },
                    { 1970, "Student1970@mail.com", 132, "Student 1970" },
                    { 1971, "Student1971@mail.com", 132, "Student 1971" },
                    { 1972, "Student1972@mail.com", 132, "Student 1972" },
                    { 1973, "Student1973@mail.com", 132, "Student 1973" },
                    { 1974, "Student1974@mail.com", 132, "Student 1974" },
                    { 1975, "Student1975@mail.com", 132, "Student 1975" },
                    { 1976, "Student1976@mail.com", 132, "Student 1976" },
                    { 1977, "Student1977@mail.com", 132, "Student 1977" },
                    { 1978, "Student1978@mail.com", 132, "Student 1978" },
                    { 1979, "Student1979@mail.com", 132, "Student 1979" },
                    { 1980, "Student1980@mail.com", 132, "Student 1980" },
                    { 1981, "Student1981@mail.com", 133, "Student 1981" },
                    { 1982, "Student1982@mail.com", 133, "Student 1982" },
                    { 1983, "Student1983@mail.com", 133, "Student 1983" },
                    { 1984, "Student1984@mail.com", 133, "Student 1984" },
                    { 1985, "Student1985@mail.com", 133, "Student 1985" },
                    { 1986, "Student1986@mail.com", 133, "Student 1986" },
                    { 1987, "Student1987@mail.com", 133, "Student 1987" },
                    { 1988, "Student1988@mail.com", 133, "Student 1988" },
                    { 1989, "Student1989@mail.com", 133, "Student 1989" },
                    { 1990, "Student1990@mail.com", 133, "Student 1990" },
                    { 1991, "Student1991@mail.com", 133, "Student 1991" },
                    { 1992, "Student1992@mail.com", 133, "Student 1992" },
                    { 1993, "Student1993@mail.com", 133, "Student 1993" },
                    { 1994, "Student1994@mail.com", 133, "Student 1994" },
                    { 1995, "Student1995@mail.com", 133, "Student 1995" },
                    { 1996, "Student1996@mail.com", 134, "Student 1996" },
                    { 1997, "Student1997@mail.com", 134, "Student 1997" },
                    { 1998, "Student1998@mail.com", 134, "Student 1998" },
                    { 1999, "Student1999@mail.com", 134, "Student 1999" },
                    { 2000, "Student2000@mail.com", 134, "Student 2000" },
                    { 2001, "Student2001@mail.com", 134, "Student 2001" },
                    { 2002, "Student2002@mail.com", 134, "Student 2002" },
                    { 2003, "Student2003@mail.com", 134, "Student 2003" },
                    { 2004, "Student2004@mail.com", 134, "Student 2004" },
                    { 2005, "Student2005@mail.com", 134, "Student 2005" },
                    { 2006, "Student2006@mail.com", 134, "Student 2006" },
                    { 2007, "Student2007@mail.com", 134, "Student 2007" },
                    { 2008, "Student2008@mail.com", 134, "Student 2008" },
                    { 2009, "Student2009@mail.com", 134, "Student 2009" },
                    { 2010, "Student2010@mail.com", 134, "Student 2010" },
                    { 2011, "Student2011@mail.com", 135, "Student 2011" },
                    { 2012, "Student2012@mail.com", 135, "Student 2012" },
                    { 2013, "Student2013@mail.com", 135, "Student 2013" },
                    { 2014, "Student2014@mail.com", 135, "Student 2014" },
                    { 2015, "Student2015@mail.com", 135, "Student 2015" },
                    { 2016, "Student2016@mail.com", 135, "Student 2016" },
                    { 2017, "Student2017@mail.com", 135, "Student 2017" },
                    { 2018, "Student2018@mail.com", 135, "Student 2018" },
                    { 2019, "Student2019@mail.com", 135, "Student 2019" },
                    { 2020, "Student2020@mail.com", 135, "Student 2020" },
                    { 2021, "Student2021@mail.com", 135, "Student 2021" },
                    { 2022, "Student2022@mail.com", 135, "Student 2022" },
                    { 2023, "Student2023@mail.com", 135, "Student 2023" },
                    { 2024, "Student2024@mail.com", 135, "Student 2024" },
                    { 2025, "Student2025@mail.com", 135, "Student 2025" },
                    { 2026, "Student2026@mail.com", 136, "Student 2026" },
                    { 2027, "Student2027@mail.com", 136, "Student 2027" },
                    { 2028, "Student2028@mail.com", 136, "Student 2028" },
                    { 2029, "Student2029@mail.com", 136, "Student 2029" },
                    { 2030, "Student2030@mail.com", 136, "Student 2030" },
                    { 2031, "Student2031@mail.com", 136, "Student 2031" },
                    { 2032, "Student2032@mail.com", 136, "Student 2032" },
                    { 2033, "Student2033@mail.com", 136, "Student 2033" },
                    { 2034, "Student2034@mail.com", 136, "Student 2034" },
                    { 2035, "Student2035@mail.com", 136, "Student 2035" },
                    { 2036, "Student2036@mail.com", 136, "Student 2036" },
                    { 2037, "Student2037@mail.com", 136, "Student 2037" },
                    { 2038, "Student2038@mail.com", 136, "Student 2038" },
                    { 2039, "Student2039@mail.com", 136, "Student 2039" },
                    { 2040, "Student2040@mail.com", 136, "Student 2040" },
                    { 2041, "Student2041@mail.com", 137, "Student 2041" },
                    { 2042, "Student2042@mail.com", 137, "Student 2042" },
                    { 2043, "Student2043@mail.com", 137, "Student 2043" },
                    { 2044, "Student2044@mail.com", 137, "Student 2044" },
                    { 2045, "Student2045@mail.com", 137, "Student 2045" },
                    { 2046, "Student2046@mail.com", 137, "Student 2046" },
                    { 2047, "Student2047@mail.com", 137, "Student 2047" },
                    { 2048, "Student2048@mail.com", 137, "Student 2048" },
                    { 2049, "Student2049@mail.com", 137, "Student 2049" },
                    { 2050, "Student2050@mail.com", 137, "Student 2050" },
                    { 2051, "Student2051@mail.com", 137, "Student 2051" },
                    { 2052, "Student2052@mail.com", 137, "Student 2052" },
                    { 2053, "Student2053@mail.com", 137, "Student 2053" },
                    { 2054, "Student2054@mail.com", 137, "Student 2054" },
                    { 2055, "Student2055@mail.com", 137, "Student 2055" },
                    { 2056, "Student2056@mail.com", 138, "Student 2056" },
                    { 2057, "Student2057@mail.com", 138, "Student 2057" },
                    { 2058, "Student2058@mail.com", 138, "Student 2058" },
                    { 2059, "Student2059@mail.com", 138, "Student 2059" },
                    { 2060, "Student2060@mail.com", 138, "Student 2060" },
                    { 2061, "Student2061@mail.com", 138, "Student 2061" },
                    { 2062, "Student2062@mail.com", 138, "Student 2062" },
                    { 2063, "Student2063@mail.com", 138, "Student 2063" },
                    { 2064, "Student2064@mail.com", 138, "Student 2064" },
                    { 2065, "Student2065@mail.com", 138, "Student 2065" },
                    { 2066, "Student2066@mail.com", 138, "Student 2066" },
                    { 2067, "Student2067@mail.com", 138, "Student 2067" },
                    { 2068, "Student2068@mail.com", 138, "Student 2068" },
                    { 2069, "Student2069@mail.com", 138, "Student 2069" },
                    { 2070, "Student2070@mail.com", 138, "Student 2070" },
                    { 2071, "Student2071@mail.com", 139, "Student 2071" },
                    { 2072, "Student2072@mail.com", 139, "Student 2072" },
                    { 2073, "Student2073@mail.com", 139, "Student 2073" },
                    { 2074, "Student2074@mail.com", 139, "Student 2074" },
                    { 2075, "Student2075@mail.com", 139, "Student 2075" },
                    { 2076, "Student2076@mail.com", 139, "Student 2076" },
                    { 2077, "Student2077@mail.com", 139, "Student 2077" },
                    { 2078, "Student2078@mail.com", 139, "Student 2078" },
                    { 2079, "Student2079@mail.com", 139, "Student 2079" },
                    { 2080, "Student2080@mail.com", 139, "Student 2080" },
                    { 2081, "Student2081@mail.com", 139, "Student 2081" },
                    { 2082, "Student2082@mail.com", 139, "Student 2082" },
                    { 2083, "Student2083@mail.com", 139, "Student 2083" },
                    { 2084, "Student2084@mail.com", 139, "Student 2084" },
                    { 2085, "Student2085@mail.com", 139, "Student 2085" },
                    { 2086, "Student2086@mail.com", 140, "Student 2086" },
                    { 2087, "Student2087@mail.com", 140, "Student 2087" },
                    { 2088, "Student2088@mail.com", 140, "Student 2088" },
                    { 2089, "Student2089@mail.com", 140, "Student 2089" },
                    { 2090, "Student2090@mail.com", 140, "Student 2090" },
                    { 2091, "Student2091@mail.com", 140, "Student 2091" },
                    { 2092, "Student2092@mail.com", 140, "Student 2092" },
                    { 2093, "Student2093@mail.com", 140, "Student 2093" },
                    { 2094, "Student2094@mail.com", 140, "Student 2094" },
                    { 2095, "Student2095@mail.com", 140, "Student 2095" },
                    { 2096, "Student2096@mail.com", 140, "Student 2096" },
                    { 2097, "Student2097@mail.com", 140, "Student 2097" },
                    { 2098, "Student2098@mail.com", 140, "Student 2098" },
                    { 2099, "Student2099@mail.com", 140, "Student 2099" },
                    { 2100, "Student2100@mail.com", 140, "Student 2100" },
                    { 2101, "Student2101@mail.com", 141, "Student 2101" },
                    { 2102, "Student2102@mail.com", 141, "Student 2102" },
                    { 2103, "Student2103@mail.com", 141, "Student 2103" },
                    { 2104, "Student2104@mail.com", 141, "Student 2104" },
                    { 2105, "Student2105@mail.com", 141, "Student 2105" },
                    { 2106, "Student2106@mail.com", 141, "Student 2106" },
                    { 2107, "Student2107@mail.com", 141, "Student 2107" },
                    { 2108, "Student2108@mail.com", 141, "Student 2108" },
                    { 2109, "Student2109@mail.com", 141, "Student 2109" },
                    { 2110, "Student2110@mail.com", 141, "Student 2110" },
                    { 2111, "Student2111@mail.com", 141, "Student 2111" },
                    { 2112, "Student2112@mail.com", 141, "Student 2112" },
                    { 2113, "Student2113@mail.com", 141, "Student 2113" },
                    { 2114, "Student2114@mail.com", 141, "Student 2114" },
                    { 2115, "Student2115@mail.com", 141, "Student 2115" },
                    { 2116, "Student2116@mail.com", 142, "Student 2116" },
                    { 2117, "Student2117@mail.com", 142, "Student 2117" },
                    { 2118, "Student2118@mail.com", 142, "Student 2118" },
                    { 2119, "Student2119@mail.com", 142, "Student 2119" },
                    { 2120, "Student2120@mail.com", 142, "Student 2120" },
                    { 2121, "Student2121@mail.com", 142, "Student 2121" },
                    { 2122, "Student2122@mail.com", 142, "Student 2122" },
                    { 2123, "Student2123@mail.com", 142, "Student 2123" },
                    { 2124, "Student2124@mail.com", 142, "Student 2124" },
                    { 2125, "Student2125@mail.com", 142, "Student 2125" },
                    { 2126, "Student2126@mail.com", 142, "Student 2126" },
                    { 2127, "Student2127@mail.com", 142, "Student 2127" },
                    { 2128, "Student2128@mail.com", 142, "Student 2128" },
                    { 2129, "Student2129@mail.com", 142, "Student 2129" },
                    { 2130, "Student2130@mail.com", 142, "Student 2130" },
                    { 2131, "Student2131@mail.com", 143, "Student 2131" },
                    { 2132, "Student2132@mail.com", 143, "Student 2132" },
                    { 2133, "Student2133@mail.com", 143, "Student 2133" },
                    { 2134, "Student2134@mail.com", 143, "Student 2134" },
                    { 2135, "Student2135@mail.com", 143, "Student 2135" },
                    { 2136, "Student2136@mail.com", 143, "Student 2136" },
                    { 2137, "Student2137@mail.com", 143, "Student 2137" },
                    { 2138, "Student2138@mail.com", 143, "Student 2138" },
                    { 2139, "Student2139@mail.com", 143, "Student 2139" },
                    { 2140, "Student2140@mail.com", 143, "Student 2140" },
                    { 2141, "Student2141@mail.com", 143, "Student 2141" },
                    { 2142, "Student2142@mail.com", 143, "Student 2142" },
                    { 2143, "Student2143@mail.com", 143, "Student 2143" },
                    { 2144, "Student2144@mail.com", 143, "Student 2144" },
                    { 2145, "Student2145@mail.com", 143, "Student 2145" },
                    { 2146, "Student2146@mail.com", 144, "Student 2146" },
                    { 2147, "Student2147@mail.com", 144, "Student 2147" },
                    { 2148, "Student2148@mail.com", 144, "Student 2148" },
                    { 2149, "Student2149@mail.com", 144, "Student 2149" },
                    { 2150, "Student2150@mail.com", 144, "Student 2150" },
                    { 2151, "Student2151@mail.com", 144, "Student 2151" },
                    { 2152, "Student2152@mail.com", 144, "Student 2152" },
                    { 2153, "Student2153@mail.com", 144, "Student 2153" },
                    { 2154, "Student2154@mail.com", 144, "Student 2154" },
                    { 2155, "Student2155@mail.com", 144, "Student 2155" },
                    { 2156, "Student2156@mail.com", 144, "Student 2156" },
                    { 2157, "Student2157@mail.com", 144, "Student 2157" },
                    { 2158, "Student2158@mail.com", 144, "Student 2158" },
                    { 2159, "Student2159@mail.com", 144, "Student 2159" },
                    { 2160, "Student2160@mail.com", 144, "Student 2160" },
                    { 2161, "Student2161@mail.com", 145, "Student 2161" },
                    { 2162, "Student2162@mail.com", 145, "Student 2162" },
                    { 2163, "Student2163@mail.com", 145, "Student 2163" },
                    { 2164, "Student2164@mail.com", 145, "Student 2164" },
                    { 2165, "Student2165@mail.com", 145, "Student 2165" },
                    { 2166, "Student2166@mail.com", 145, "Student 2166" },
                    { 2167, "Student2167@mail.com", 145, "Student 2167" },
                    { 2168, "Student2168@mail.com", 145, "Student 2168" },
                    { 2169, "Student2169@mail.com", 145, "Student 2169" },
                    { 2170, "Student2170@mail.com", 145, "Student 2170" },
                    { 2171, "Student2171@mail.com", 145, "Student 2171" },
                    { 2172, "Student2172@mail.com", 145, "Student 2172" },
                    { 2173, "Student2173@mail.com", 145, "Student 2173" },
                    { 2174, "Student2174@mail.com", 145, "Student 2174" },
                    { 2175, "Student2175@mail.com", 145, "Student 2175" },
                    { 2176, "Student2176@mail.com", 146, "Student 2176" },
                    { 2177, "Student2177@mail.com", 146, "Student 2177" },
                    { 2178, "Student2178@mail.com", 146, "Student 2178" },
                    { 2179, "Student2179@mail.com", 146, "Student 2179" },
                    { 2180, "Student2180@mail.com", 146, "Student 2180" },
                    { 2181, "Student2181@mail.com", 146, "Student 2181" },
                    { 2182, "Student2182@mail.com", 146, "Student 2182" },
                    { 2183, "Student2183@mail.com", 146, "Student 2183" },
                    { 2184, "Student2184@mail.com", 146, "Student 2184" },
                    { 2185, "Student2185@mail.com", 146, "Student 2185" },
                    { 2186, "Student2186@mail.com", 146, "Student 2186" },
                    { 2187, "Student2187@mail.com", 146, "Student 2187" },
                    { 2188, "Student2188@mail.com", 146, "Student 2188" },
                    { 2189, "Student2189@mail.com", 146, "Student 2189" },
                    { 2190, "Student2190@mail.com", 146, "Student 2190" },
                    { 2191, "Student2191@mail.com", 147, "Student 2191" },
                    { 2192, "Student2192@mail.com", 147, "Student 2192" },
                    { 2193, "Student2193@mail.com", 147, "Student 2193" },
                    { 2194, "Student2194@mail.com", 147, "Student 2194" },
                    { 2195, "Student2195@mail.com", 147, "Student 2195" },
                    { 2196, "Student2196@mail.com", 147, "Student 2196" },
                    { 2197, "Student2197@mail.com", 147, "Student 2197" },
                    { 2198, "Student2198@mail.com", 147, "Student 2198" },
                    { 2199, "Student2199@mail.com", 147, "Student 2199" },
                    { 2200, "Student2200@mail.com", 147, "Student 2200" },
                    { 2201, "Student2201@mail.com", 147, "Student 2201" },
                    { 2202, "Student2202@mail.com", 147, "Student 2202" },
                    { 2203, "Student2203@mail.com", 147, "Student 2203" },
                    { 2204, "Student2204@mail.com", 147, "Student 2204" },
                    { 2205, "Student2205@mail.com", 147, "Student 2205" },
                    { 2206, "Student2206@mail.com", 148, "Student 2206" },
                    { 2207, "Student2207@mail.com", 148, "Student 2207" },
                    { 2208, "Student2208@mail.com", 148, "Student 2208" },
                    { 2209, "Student2209@mail.com", 148, "Student 2209" },
                    { 2210, "Student2210@mail.com", 148, "Student 2210" },
                    { 2211, "Student2211@mail.com", 148, "Student 2211" },
                    { 2212, "Student2212@mail.com", 148, "Student 2212" },
                    { 2213, "Student2213@mail.com", 148, "Student 2213" },
                    { 2214, "Student2214@mail.com", 148, "Student 2214" },
                    { 2215, "Student2215@mail.com", 148, "Student 2215" },
                    { 2216, "Student2216@mail.com", 148, "Student 2216" },
                    { 2217, "Student2217@mail.com", 148, "Student 2217" },
                    { 2218, "Student2218@mail.com", 148, "Student 2218" },
                    { 2219, "Student2219@mail.com", 148, "Student 2219" },
                    { 2220, "Student2220@mail.com", 148, "Student 2220" },
                    { 2221, "Student2221@mail.com", 149, "Student 2221" },
                    { 2222, "Student2222@mail.com", 149, "Student 2222" },
                    { 2223, "Student2223@mail.com", 149, "Student 2223" },
                    { 2224, "Student2224@mail.com", 149, "Student 2224" },
                    { 2225, "Student2225@mail.com", 149, "Student 2225" },
                    { 2226, "Student2226@mail.com", 149, "Student 2226" },
                    { 2227, "Student2227@mail.com", 149, "Student 2227" },
                    { 2228, "Student2228@mail.com", 149, "Student 2228" },
                    { 2229, "Student2229@mail.com", 149, "Student 2229" },
                    { 2230, "Student2230@mail.com", 149, "Student 2230" },
                    { 2231, "Student2231@mail.com", 149, "Student 2231" },
                    { 2232, "Student2232@mail.com", 149, "Student 2232" },
                    { 2233, "Student2233@mail.com", 149, "Student 2233" },
                    { 2234, "Student2234@mail.com", 149, "Student 2234" },
                    { 2235, "Student2235@mail.com", 149, "Student 2235" },
                    { 2236, "Student2236@mail.com", 150, "Student 2236" },
                    { 2237, "Student2237@mail.com", 150, "Student 2237" },
                    { 2238, "Student2238@mail.com", 150, "Student 2238" },
                    { 2239, "Student2239@mail.com", 150, "Student 2239" },
                    { 2240, "Student2240@mail.com", 150, "Student 2240" },
                    { 2241, "Student2241@mail.com", 150, "Student 2241" },
                    { 2242, "Student2242@mail.com", 150, "Student 2242" },
                    { 2243, "Student2243@mail.com", 150, "Student 2243" },
                    { 2244, "Student2244@mail.com", 150, "Student 2244" },
                    { 2245, "Student2245@mail.com", 150, "Student 2245" },
                    { 2246, "Student2246@mail.com", 150, "Student 2246" },
                    { 2247, "Student2247@mail.com", 150, "Student 2247" },
                    { 2248, "Student2248@mail.com", 150, "Student 2248" },
                    { 2249, "Student2249@mail.com", 150, "Student 2249" },
                    { 2250, "Student2250@mail.com", 150, "Student 2250" },
                    { 2251, "Student2251@mail.com", 151, "Student 2251" },
                    { 2252, "Student2252@mail.com", 151, "Student 2252" },
                    { 2253, "Student2253@mail.com", 151, "Student 2253" },
                    { 2254, "Student2254@mail.com", 151, "Student 2254" },
                    { 2255, "Student2255@mail.com", 151, "Student 2255" },
                    { 2256, "Student2256@mail.com", 151, "Student 2256" },
                    { 2257, "Student2257@mail.com", 151, "Student 2257" },
                    { 2258, "Student2258@mail.com", 151, "Student 2258" },
                    { 2259, "Student2259@mail.com", 151, "Student 2259" },
                    { 2260, "Student2260@mail.com", 151, "Student 2260" },
                    { 2261, "Student2261@mail.com", 151, "Student 2261" },
                    { 2262, "Student2262@mail.com", 151, "Student 2262" },
                    { 2263, "Student2263@mail.com", 151, "Student 2263" },
                    { 2264, "Student2264@mail.com", 151, "Student 2264" },
                    { 2265, "Student2265@mail.com", 151, "Student 2265" },
                    { 2266, "Student2266@mail.com", 152, "Student 2266" },
                    { 2267, "Student2267@mail.com", 152, "Student 2267" },
                    { 2268, "Student2268@mail.com", 152, "Student 2268" },
                    { 2269, "Student2269@mail.com", 152, "Student 2269" },
                    { 2270, "Student2270@mail.com", 152, "Student 2270" },
                    { 2271, "Student2271@mail.com", 152, "Student 2271" },
                    { 2272, "Student2272@mail.com", 152, "Student 2272" },
                    { 2273, "Student2273@mail.com", 152, "Student 2273" },
                    { 2274, "Student2274@mail.com", 152, "Student 2274" },
                    { 2275, "Student2275@mail.com", 152, "Student 2275" },
                    { 2276, "Student2276@mail.com", 152, "Student 2276" },
                    { 2277, "Student2277@mail.com", 152, "Student 2277" },
                    { 2278, "Student2278@mail.com", 152, "Student 2278" },
                    { 2279, "Student2279@mail.com", 152, "Student 2279" },
                    { 2280, "Student2280@mail.com", 152, "Student 2280" },
                    { 2281, "Student2281@mail.com", 153, "Student 2281" },
                    { 2282, "Student2282@mail.com", 153, "Student 2282" },
                    { 2283, "Student2283@mail.com", 153, "Student 2283" },
                    { 2284, "Student2284@mail.com", 153, "Student 2284" },
                    { 2285, "Student2285@mail.com", 153, "Student 2285" },
                    { 2286, "Student2286@mail.com", 153, "Student 2286" },
                    { 2287, "Student2287@mail.com", 153, "Student 2287" },
                    { 2288, "Student2288@mail.com", 153, "Student 2288" },
                    { 2289, "Student2289@mail.com", 153, "Student 2289" },
                    { 2290, "Student2290@mail.com", 153, "Student 2290" },
                    { 2291, "Student2291@mail.com", 153, "Student 2291" },
                    { 2292, "Student2292@mail.com", 153, "Student 2292" },
                    { 2293, "Student2293@mail.com", 153, "Student 2293" },
                    { 2294, "Student2294@mail.com", 153, "Student 2294" },
                    { 2295, "Student2295@mail.com", 153, "Student 2295" },
                    { 2296, "Student2296@mail.com", 154, "Student 2296" },
                    { 2297, "Student2297@mail.com", 154, "Student 2297" },
                    { 2298, "Student2298@mail.com", 154, "Student 2298" },
                    { 2299, "Student2299@mail.com", 154, "Student 2299" },
                    { 2300, "Student2300@mail.com", 154, "Student 2300" },
                    { 2301, "Student2301@mail.com", 154, "Student 2301" },
                    { 2302, "Student2302@mail.com", 154, "Student 2302" },
                    { 2303, "Student2303@mail.com", 154, "Student 2303" },
                    { 2304, "Student2304@mail.com", 154, "Student 2304" },
                    { 2305, "Student2305@mail.com", 154, "Student 2305" },
                    { 2306, "Student2306@mail.com", 154, "Student 2306" },
                    { 2307, "Student2307@mail.com", 154, "Student 2307" },
                    { 2308, "Student2308@mail.com", 154, "Student 2308" },
                    { 2309, "Student2309@mail.com", 154, "Student 2309" },
                    { 2310, "Student2310@mail.com", 154, "Student 2310" },
                    { 2311, "Student2311@mail.com", 155, "Student 2311" },
                    { 2312, "Student2312@mail.com", 155, "Student 2312" },
                    { 2313, "Student2313@mail.com", 155, "Student 2313" },
                    { 2314, "Student2314@mail.com", 155, "Student 2314" },
                    { 2315, "Student2315@mail.com", 155, "Student 2315" },
                    { 2316, "Student2316@mail.com", 155, "Student 2316" },
                    { 2317, "Student2317@mail.com", 155, "Student 2317" },
                    { 2318, "Student2318@mail.com", 155, "Student 2318" },
                    { 2319, "Student2319@mail.com", 155, "Student 2319" },
                    { 2320, "Student2320@mail.com", 155, "Student 2320" },
                    { 2321, "Student2321@mail.com", 155, "Student 2321" },
                    { 2322, "Student2322@mail.com", 155, "Student 2322" },
                    { 2323, "Student2323@mail.com", 155, "Student 2323" },
                    { 2324, "Student2324@mail.com", 155, "Student 2324" },
                    { 2325, "Student2325@mail.com", 155, "Student 2325" },
                    { 2326, "Student2326@mail.com", 156, "Student 2326" },
                    { 2327, "Student2327@mail.com", 156, "Student 2327" },
                    { 2328, "Student2328@mail.com", 156, "Student 2328" },
                    { 2329, "Student2329@mail.com", 156, "Student 2329" },
                    { 2330, "Student2330@mail.com", 156, "Student 2330" },
                    { 2331, "Student2331@mail.com", 156, "Student 2331" },
                    { 2332, "Student2332@mail.com", 156, "Student 2332" },
                    { 2333, "Student2333@mail.com", 156, "Student 2333" },
                    { 2334, "Student2334@mail.com", 156, "Student 2334" },
                    { 2335, "Student2335@mail.com", 156, "Student 2335" },
                    { 2336, "Student2336@mail.com", 156, "Student 2336" },
                    { 2337, "Student2337@mail.com", 156, "Student 2337" },
                    { 2338, "Student2338@mail.com", 156, "Student 2338" },
                    { 2339, "Student2339@mail.com", 156, "Student 2339" },
                    { 2340, "Student2340@mail.com", 156, "Student 2340" },
                    { 2341, "Student2341@mail.com", 157, "Student 2341" },
                    { 2342, "Student2342@mail.com", 157, "Student 2342" },
                    { 2343, "Student2343@mail.com", 157, "Student 2343" },
                    { 2344, "Student2344@mail.com", 157, "Student 2344" },
                    { 2345, "Student2345@mail.com", 157, "Student 2345" },
                    { 2346, "Student2346@mail.com", 157, "Student 2346" },
                    { 2347, "Student2347@mail.com", 157, "Student 2347" },
                    { 2348, "Student2348@mail.com", 157, "Student 2348" },
                    { 2349, "Student2349@mail.com", 157, "Student 2349" },
                    { 2350, "Student2350@mail.com", 157, "Student 2350" },
                    { 2351, "Student2351@mail.com", 157, "Student 2351" },
                    { 2352, "Student2352@mail.com", 157, "Student 2352" },
                    { 2353, "Student2353@mail.com", 157, "Student 2353" },
                    { 2354, "Student2354@mail.com", 157, "Student 2354" },
                    { 2355, "Student2355@mail.com", 157, "Student 2355" },
                    { 2356, "Student2356@mail.com", 158, "Student 2356" },
                    { 2357, "Student2357@mail.com", 158, "Student 2357" },
                    { 2358, "Student2358@mail.com", 158, "Student 2358" },
                    { 2359, "Student2359@mail.com", 158, "Student 2359" },
                    { 2360, "Student2360@mail.com", 158, "Student 2360" },
                    { 2361, "Student2361@mail.com", 158, "Student 2361" },
                    { 2362, "Student2362@mail.com", 158, "Student 2362" },
                    { 2363, "Student2363@mail.com", 158, "Student 2363" },
                    { 2364, "Student2364@mail.com", 158, "Student 2364" },
                    { 2365, "Student2365@mail.com", 158, "Student 2365" },
                    { 2366, "Student2366@mail.com", 158, "Student 2366" },
                    { 2367, "Student2367@mail.com", 158, "Student 2367" },
                    { 2368, "Student2368@mail.com", 158, "Student 2368" },
                    { 2369, "Student2369@mail.com", 158, "Student 2369" },
                    { 2370, "Student2370@mail.com", 158, "Student 2370" },
                    { 2371, "Student2371@mail.com", 159, "Student 2371" },
                    { 2372, "Student2372@mail.com", 159, "Student 2372" },
                    { 2373, "Student2373@mail.com", 159, "Student 2373" },
                    { 2374, "Student2374@mail.com", 159, "Student 2374" },
                    { 2375, "Student2375@mail.com", 159, "Student 2375" },
                    { 2376, "Student2376@mail.com", 159, "Student 2376" },
                    { 2377, "Student2377@mail.com", 159, "Student 2377" },
                    { 2378, "Student2378@mail.com", 159, "Student 2378" },
                    { 2379, "Student2379@mail.com", 159, "Student 2379" },
                    { 2380, "Student2380@mail.com", 159, "Student 2380" },
                    { 2381, "Student2381@mail.com", 159, "Student 2381" },
                    { 2382, "Student2382@mail.com", 159, "Student 2382" },
                    { 2383, "Student2383@mail.com", 159, "Student 2383" },
                    { 2384, "Student2384@mail.com", 159, "Student 2384" },
                    { 2385, "Student2385@mail.com", 159, "Student 2385" },
                    { 2386, "Student2386@mail.com", 160, "Student 2386" },
                    { 2387, "Student2387@mail.com", 160, "Student 2387" },
                    { 2388, "Student2388@mail.com", 160, "Student 2388" },
                    { 2389, "Student2389@mail.com", 160, "Student 2389" },
                    { 2390, "Student2390@mail.com", 160, "Student 2390" },
                    { 2391, "Student2391@mail.com", 160, "Student 2391" },
                    { 2392, "Student2392@mail.com", 160, "Student 2392" },
                    { 2393, "Student2393@mail.com", 160, "Student 2393" },
                    { 2394, "Student2394@mail.com", 160, "Student 2394" },
                    { 2395, "Student2395@mail.com", 160, "Student 2395" },
                    { 2396, "Student2396@mail.com", 160, "Student 2396" },
                    { 2397, "Student2397@mail.com", 160, "Student 2397" },
                    { 2398, "Student2398@mail.com", 160, "Student 2398" },
                    { 2399, "Student2399@mail.com", 160, "Student 2399" },
                    { 2400, "Student2400@mail.com", 160, "Student 2400" },
                    { 2401, "Student2401@mail.com", 161, "Student 2401" },
                    { 2402, "Student2402@mail.com", 161, "Student 2402" },
                    { 2403, "Student2403@mail.com", 161, "Student 2403" },
                    { 2404, "Student2404@mail.com", 161, "Student 2404" },
                    { 2405, "Student2405@mail.com", 161, "Student 2405" },
                    { 2406, "Student2406@mail.com", 161, "Student 2406" },
                    { 2407, "Student2407@mail.com", 161, "Student 2407" },
                    { 2408, "Student2408@mail.com", 161, "Student 2408" },
                    { 2409, "Student2409@mail.com", 161, "Student 2409" },
                    { 2410, "Student2410@mail.com", 161, "Student 2410" },
                    { 2411, "Student2411@mail.com", 161, "Student 2411" },
                    { 2412, "Student2412@mail.com", 161, "Student 2412" },
                    { 2413, "Student2413@mail.com", 161, "Student 2413" },
                    { 2414, "Student2414@mail.com", 161, "Student 2414" },
                    { 2415, "Student2415@mail.com", 161, "Student 2415" },
                    { 2416, "Student2416@mail.com", 162, "Student 2416" },
                    { 2417, "Student2417@mail.com", 162, "Student 2417" },
                    { 2418, "Student2418@mail.com", 162, "Student 2418" },
                    { 2419, "Student2419@mail.com", 162, "Student 2419" },
                    { 2420, "Student2420@mail.com", 162, "Student 2420" },
                    { 2421, "Student2421@mail.com", 162, "Student 2421" },
                    { 2422, "Student2422@mail.com", 162, "Student 2422" },
                    { 2423, "Student2423@mail.com", 162, "Student 2423" },
                    { 2424, "Student2424@mail.com", 162, "Student 2424" },
                    { 2425, "Student2425@mail.com", 162, "Student 2425" },
                    { 2426, "Student2426@mail.com", 162, "Student 2426" },
                    { 2427, "Student2427@mail.com", 162, "Student 2427" },
                    { 2428, "Student2428@mail.com", 162, "Student 2428" },
                    { 2429, "Student2429@mail.com", 162, "Student 2429" },
                    { 2430, "Student2430@mail.com", 162, "Student 2430" },
                    { 2431, "Student2431@mail.com", 163, "Student 2431" },
                    { 2432, "Student2432@mail.com", 163, "Student 2432" },
                    { 2433, "Student2433@mail.com", 163, "Student 2433" },
                    { 2434, "Student2434@mail.com", 163, "Student 2434" },
                    { 2435, "Student2435@mail.com", 163, "Student 2435" },
                    { 2436, "Student2436@mail.com", 163, "Student 2436" },
                    { 2437, "Student2437@mail.com", 163, "Student 2437" },
                    { 2438, "Student2438@mail.com", 163, "Student 2438" },
                    { 2439, "Student2439@mail.com", 163, "Student 2439" },
                    { 2440, "Student2440@mail.com", 163, "Student 2440" },
                    { 2441, "Student2441@mail.com", 163, "Student 2441" },
                    { 2442, "Student2442@mail.com", 163, "Student 2442" },
                    { 2443, "Student2443@mail.com", 163, "Student 2443" },
                    { 2444, "Student2444@mail.com", 163, "Student 2444" },
                    { 2445, "Student2445@mail.com", 163, "Student 2445" },
                    { 2446, "Student2446@mail.com", 164, "Student 2446" },
                    { 2447, "Student2447@mail.com", 164, "Student 2447" },
                    { 2448, "Student2448@mail.com", 164, "Student 2448" },
                    { 2449, "Student2449@mail.com", 164, "Student 2449" },
                    { 2450, "Student2450@mail.com", 164, "Student 2450" },
                    { 2451, "Student2451@mail.com", 164, "Student 2451" },
                    { 2452, "Student2452@mail.com", 164, "Student 2452" },
                    { 2453, "Student2453@mail.com", 164, "Student 2453" },
                    { 2454, "Student2454@mail.com", 164, "Student 2454" },
                    { 2455, "Student2455@mail.com", 164, "Student 2455" },
                    { 2456, "Student2456@mail.com", 164, "Student 2456" },
                    { 2457, "Student2457@mail.com", 164, "Student 2457" },
                    { 2458, "Student2458@mail.com", 164, "Student 2458" },
                    { 2459, "Student2459@mail.com", 164, "Student 2459" },
                    { 2460, "Student2460@mail.com", 164, "Student 2460" },
                    { 2461, "Student2461@mail.com", 165, "Student 2461" },
                    { 2462, "Student2462@mail.com", 165, "Student 2462" },
                    { 2463, "Student2463@mail.com", 165, "Student 2463" },
                    { 2464, "Student2464@mail.com", 165, "Student 2464" },
                    { 2465, "Student2465@mail.com", 165, "Student 2465" },
                    { 2466, "Student2466@mail.com", 165, "Student 2466" },
                    { 2467, "Student2467@mail.com", 165, "Student 2467" },
                    { 2468, "Student2468@mail.com", 165, "Student 2468" },
                    { 2469, "Student2469@mail.com", 165, "Student 2469" },
                    { 2470, "Student2470@mail.com", 165, "Student 2470" },
                    { 2471, "Student2471@mail.com", 165, "Student 2471" },
                    { 2472, "Student2472@mail.com", 165, "Student 2472" },
                    { 2473, "Student2473@mail.com", 165, "Student 2473" },
                    { 2474, "Student2474@mail.com", 165, "Student 2474" },
                    { 2475, "Student2475@mail.com", 165, "Student 2475" },
                    { 2476, "Student2476@mail.com", 166, "Student 2476" },
                    { 2477, "Student2477@mail.com", 166, "Student 2477" },
                    { 2478, "Student2478@mail.com", 166, "Student 2478" },
                    { 2479, "Student2479@mail.com", 166, "Student 2479" },
                    { 2480, "Student2480@mail.com", 166, "Student 2480" },
                    { 2481, "Student2481@mail.com", 166, "Student 2481" },
                    { 2482, "Student2482@mail.com", 166, "Student 2482" },
                    { 2483, "Student2483@mail.com", 166, "Student 2483" },
                    { 2484, "Student2484@mail.com", 166, "Student 2484" },
                    { 2485, "Student2485@mail.com", 166, "Student 2485" },
                    { 2486, "Student2486@mail.com", 166, "Student 2486" },
                    { 2487, "Student2487@mail.com", 166, "Student 2487" },
                    { 2488, "Student2488@mail.com", 166, "Student 2488" },
                    { 2489, "Student2489@mail.com", 166, "Student 2489" },
                    { 2490, "Student2490@mail.com", 166, "Student 2490" },
                    { 2491, "Student2491@mail.com", 167, "Student 2491" },
                    { 2492, "Student2492@mail.com", 167, "Student 2492" },
                    { 2493, "Student2493@mail.com", 167, "Student 2493" },
                    { 2494, "Student2494@mail.com", 167, "Student 2494" },
                    { 2495, "Student2495@mail.com", 167, "Student 2495" },
                    { 2496, "Student2496@mail.com", 167, "Student 2496" },
                    { 2497, "Student2497@mail.com", 167, "Student 2497" },
                    { 2498, "Student2498@mail.com", 167, "Student 2498" },
                    { 2499, "Student2499@mail.com", 167, "Student 2499" },
                    { 2500, "Student2500@mail.com", 167, "Student 2500" },
                    { 2501, "Student2501@mail.com", 167, "Student 2501" },
                    { 2502, "Student2502@mail.com", 167, "Student 2502" },
                    { 2503, "Student2503@mail.com", 167, "Student 2503" },
                    { 2504, "Student2504@mail.com", 167, "Student 2504" },
                    { 2505, "Student2505@mail.com", 167, "Student 2505" },
                    { 2506, "Student2506@mail.com", 168, "Student 2506" },
                    { 2507, "Student2507@mail.com", 168, "Student 2507" },
                    { 2508, "Student2508@mail.com", 168, "Student 2508" },
                    { 2509, "Student2509@mail.com", 168, "Student 2509" },
                    { 2510, "Student2510@mail.com", 168, "Student 2510" },
                    { 2511, "Student2511@mail.com", 168, "Student 2511" },
                    { 2512, "Student2512@mail.com", 168, "Student 2512" },
                    { 2513, "Student2513@mail.com", 168, "Student 2513" },
                    { 2514, "Student2514@mail.com", 168, "Student 2514" },
                    { 2515, "Student2515@mail.com", 168, "Student 2515" },
                    { 2516, "Student2516@mail.com", 168, "Student 2516" },
                    { 2517, "Student2517@mail.com", 168, "Student 2517" },
                    { 2518, "Student2518@mail.com", 168, "Student 2518" },
                    { 2519, "Student2519@mail.com", 168, "Student 2519" },
                    { 2520, "Student2520@mail.com", 168, "Student 2520" },
                    { 2521, "Student2521@mail.com", 169, "Student 2521" },
                    { 2522, "Student2522@mail.com", 169, "Student 2522" },
                    { 2523, "Student2523@mail.com", 169, "Student 2523" },
                    { 2524, "Student2524@mail.com", 169, "Student 2524" },
                    { 2525, "Student2525@mail.com", 169, "Student 2525" },
                    { 2526, "Student2526@mail.com", 169, "Student 2526" },
                    { 2527, "Student2527@mail.com", 169, "Student 2527" },
                    { 2528, "Student2528@mail.com", 169, "Student 2528" },
                    { 2529, "Student2529@mail.com", 169, "Student 2529" },
                    { 2530, "Student2530@mail.com", 169, "Student 2530" },
                    { 2531, "Student2531@mail.com", 169, "Student 2531" },
                    { 2532, "Student2532@mail.com", 169, "Student 2532" },
                    { 2533, "Student2533@mail.com", 169, "Student 2533" },
                    { 2534, "Student2534@mail.com", 169, "Student 2534" },
                    { 2535, "Student2535@mail.com", 169, "Student 2535" },
                    { 2536, "Student2536@mail.com", 170, "Student 2536" },
                    { 2537, "Student2537@mail.com", 170, "Student 2537" },
                    { 2538, "Student2538@mail.com", 170, "Student 2538" },
                    { 2539, "Student2539@mail.com", 170, "Student 2539" },
                    { 2540, "Student2540@mail.com", 170, "Student 2540" },
                    { 2541, "Student2541@mail.com", 170, "Student 2541" },
                    { 2542, "Student2542@mail.com", 170, "Student 2542" },
                    { 2543, "Student2543@mail.com", 170, "Student 2543" },
                    { 2544, "Student2544@mail.com", 170, "Student 2544" },
                    { 2545, "Student2545@mail.com", 170, "Student 2545" },
                    { 2546, "Student2546@mail.com", 170, "Student 2546" },
                    { 2547, "Student2547@mail.com", 170, "Student 2547" },
                    { 2548, "Student2548@mail.com", 170, "Student 2548" },
                    { 2549, "Student2549@mail.com", 170, "Student 2549" },
                    { 2550, "Student2550@mail.com", 170, "Student 2550" },
                    { 2551, "Student2551@mail.com", 171, "Student 2551" },
                    { 2552, "Student2552@mail.com", 171, "Student 2552" },
                    { 2553, "Student2553@mail.com", 171, "Student 2553" },
                    { 2554, "Student2554@mail.com", 171, "Student 2554" },
                    { 2555, "Student2555@mail.com", 171, "Student 2555" },
                    { 2556, "Student2556@mail.com", 171, "Student 2556" },
                    { 2557, "Student2557@mail.com", 171, "Student 2557" },
                    { 2558, "Student2558@mail.com", 171, "Student 2558" },
                    { 2559, "Student2559@mail.com", 171, "Student 2559" },
                    { 2560, "Student2560@mail.com", 171, "Student 2560" },
                    { 2561, "Student2561@mail.com", 171, "Student 2561" },
                    { 2562, "Student2562@mail.com", 171, "Student 2562" },
                    { 2563, "Student2563@mail.com", 171, "Student 2563" },
                    { 2564, "Student2564@mail.com", 171, "Student 2564" },
                    { 2565, "Student2565@mail.com", 171, "Student 2565" },
                    { 2566, "Student2566@mail.com", 172, "Student 2566" },
                    { 2567, "Student2567@mail.com", 172, "Student 2567" },
                    { 2568, "Student2568@mail.com", 172, "Student 2568" },
                    { 2569, "Student2569@mail.com", 172, "Student 2569" },
                    { 2570, "Student2570@mail.com", 172, "Student 2570" },
                    { 2571, "Student2571@mail.com", 172, "Student 2571" },
                    { 2572, "Student2572@mail.com", 172, "Student 2572" },
                    { 2573, "Student2573@mail.com", 172, "Student 2573" },
                    { 2574, "Student2574@mail.com", 172, "Student 2574" },
                    { 2575, "Student2575@mail.com", 172, "Student 2575" },
                    { 2576, "Student2576@mail.com", 172, "Student 2576" },
                    { 2577, "Student2577@mail.com", 172, "Student 2577" },
                    { 2578, "Student2578@mail.com", 172, "Student 2578" },
                    { 2579, "Student2579@mail.com", 172, "Student 2579" },
                    { 2580, "Student2580@mail.com", 172, "Student 2580" },
                    { 2581, "Student2581@mail.com", 173, "Student 2581" },
                    { 2582, "Student2582@mail.com", 173, "Student 2582" },
                    { 2583, "Student2583@mail.com", 173, "Student 2583" },
                    { 2584, "Student2584@mail.com", 173, "Student 2584" },
                    { 2585, "Student2585@mail.com", 173, "Student 2585" },
                    { 2586, "Student2586@mail.com", 173, "Student 2586" },
                    { 2587, "Student2587@mail.com", 173, "Student 2587" },
                    { 2588, "Student2588@mail.com", 173, "Student 2588" },
                    { 2589, "Student2589@mail.com", 173, "Student 2589" },
                    { 2590, "Student2590@mail.com", 173, "Student 2590" },
                    { 2591, "Student2591@mail.com", 173, "Student 2591" },
                    { 2592, "Student2592@mail.com", 173, "Student 2592" },
                    { 2593, "Student2593@mail.com", 173, "Student 2593" },
                    { 2594, "Student2594@mail.com", 173, "Student 2594" },
                    { 2595, "Student2595@mail.com", 173, "Student 2595" },
                    { 2596, "Student2596@mail.com", 174, "Student 2596" },
                    { 2597, "Student2597@mail.com", 174, "Student 2597" },
                    { 2598, "Student2598@mail.com", 174, "Student 2598" },
                    { 2599, "Student2599@mail.com", 174, "Student 2599" },
                    { 2600, "Student2600@mail.com", 174, "Student 2600" },
                    { 2601, "Student2601@mail.com", 174, "Student 2601" },
                    { 2602, "Student2602@mail.com", 174, "Student 2602" },
                    { 2603, "Student2603@mail.com", 174, "Student 2603" },
                    { 2604, "Student2604@mail.com", 174, "Student 2604" },
                    { 2605, "Student2605@mail.com", 174, "Student 2605" },
                    { 2606, "Student2606@mail.com", 174, "Student 2606" },
                    { 2607, "Student2607@mail.com", 174, "Student 2607" },
                    { 2608, "Student2608@mail.com", 174, "Student 2608" },
                    { 2609, "Student2609@mail.com", 174, "Student 2609" },
                    { 2610, "Student2610@mail.com", 174, "Student 2610" },
                    { 2611, "Student2611@mail.com", 175, "Student 2611" },
                    { 2612, "Student2612@mail.com", 175, "Student 2612" },
                    { 2613, "Student2613@mail.com", 175, "Student 2613" },
                    { 2614, "Student2614@mail.com", 175, "Student 2614" },
                    { 2615, "Student2615@mail.com", 175, "Student 2615" },
                    { 2616, "Student2616@mail.com", 175, "Student 2616" },
                    { 2617, "Student2617@mail.com", 175, "Student 2617" },
                    { 2618, "Student2618@mail.com", 175, "Student 2618" },
                    { 2619, "Student2619@mail.com", 175, "Student 2619" },
                    { 2620, "Student2620@mail.com", 175, "Student 2620" },
                    { 2621, "Student2621@mail.com", 175, "Student 2621" },
                    { 2622, "Student2622@mail.com", 175, "Student 2622" },
                    { 2623, "Student2623@mail.com", 175, "Student 2623" },
                    { 2624, "Student2624@mail.com", 175, "Student 2624" },
                    { 2625, "Student2625@mail.com", 175, "Student 2625" },
                    { 2626, "Student2626@mail.com", 176, "Student 2626" },
                    { 2627, "Student2627@mail.com", 176, "Student 2627" },
                    { 2628, "Student2628@mail.com", 176, "Student 2628" },
                    { 2629, "Student2629@mail.com", 176, "Student 2629" },
                    { 2630, "Student2630@mail.com", 176, "Student 2630" },
                    { 2631, "Student2631@mail.com", 176, "Student 2631" },
                    { 2632, "Student2632@mail.com", 176, "Student 2632" },
                    { 2633, "Student2633@mail.com", 176, "Student 2633" },
                    { 2634, "Student2634@mail.com", 176, "Student 2634" },
                    { 2635, "Student2635@mail.com", 176, "Student 2635" },
                    { 2636, "Student2636@mail.com", 176, "Student 2636" },
                    { 2637, "Student2637@mail.com", 176, "Student 2637" },
                    { 2638, "Student2638@mail.com", 176, "Student 2638" },
                    { 2639, "Student2639@mail.com", 176, "Student 2639" },
                    { 2640, "Student2640@mail.com", 176, "Student 2640" },
                    { 2641, "Student2641@mail.com", 177, "Student 2641" },
                    { 2642, "Student2642@mail.com", 177, "Student 2642" },
                    { 2643, "Student2643@mail.com", 177, "Student 2643" },
                    { 2644, "Student2644@mail.com", 177, "Student 2644" },
                    { 2645, "Student2645@mail.com", 177, "Student 2645" },
                    { 2646, "Student2646@mail.com", 177, "Student 2646" },
                    { 2647, "Student2647@mail.com", 177, "Student 2647" },
                    { 2648, "Student2648@mail.com", 177, "Student 2648" },
                    { 2649, "Student2649@mail.com", 177, "Student 2649" },
                    { 2650, "Student2650@mail.com", 177, "Student 2650" },
                    { 2651, "Student2651@mail.com", 177, "Student 2651" },
                    { 2652, "Student2652@mail.com", 177, "Student 2652" },
                    { 2653, "Student2653@mail.com", 177, "Student 2653" },
                    { 2654, "Student2654@mail.com", 177, "Student 2654" },
                    { 2655, "Student2655@mail.com", 177, "Student 2655" },
                    { 2656, "Student2656@mail.com", 178, "Student 2656" },
                    { 2657, "Student2657@mail.com", 178, "Student 2657" },
                    { 2658, "Student2658@mail.com", 178, "Student 2658" },
                    { 2659, "Student2659@mail.com", 178, "Student 2659" },
                    { 2660, "Student2660@mail.com", 178, "Student 2660" },
                    { 2661, "Student2661@mail.com", 178, "Student 2661" },
                    { 2662, "Student2662@mail.com", 178, "Student 2662" },
                    { 2663, "Student2663@mail.com", 178, "Student 2663" },
                    { 2664, "Student2664@mail.com", 178, "Student 2664" },
                    { 2665, "Student2665@mail.com", 178, "Student 2665" },
                    { 2666, "Student2666@mail.com", 178, "Student 2666" },
                    { 2667, "Student2667@mail.com", 178, "Student 2667" },
                    { 2668, "Student2668@mail.com", 178, "Student 2668" },
                    { 2669, "Student2669@mail.com", 178, "Student 2669" },
                    { 2670, "Student2670@mail.com", 178, "Student 2670" },
                    { 2671, "Student2671@mail.com", 179, "Student 2671" },
                    { 2672, "Student2672@mail.com", 179, "Student 2672" },
                    { 2673, "Student2673@mail.com", 179, "Student 2673" },
                    { 2674, "Student2674@mail.com", 179, "Student 2674" },
                    { 2675, "Student2675@mail.com", 179, "Student 2675" },
                    { 2676, "Student2676@mail.com", 179, "Student 2676" },
                    { 2677, "Student2677@mail.com", 179, "Student 2677" },
                    { 2678, "Student2678@mail.com", 179, "Student 2678" },
                    { 2679, "Student2679@mail.com", 179, "Student 2679" },
                    { 2680, "Student2680@mail.com", 179, "Student 2680" },
                    { 2681, "Student2681@mail.com", 179, "Student 2681" },
                    { 2682, "Student2682@mail.com", 179, "Student 2682" },
                    { 2683, "Student2683@mail.com", 179, "Student 2683" },
                    { 2684, "Student2684@mail.com", 179, "Student 2684" },
                    { 2685, "Student2685@mail.com", 179, "Student 2685" },
                    { 2686, "Student2686@mail.com", 180, "Student 2686" },
                    { 2687, "Student2687@mail.com", 180, "Student 2687" },
                    { 2688, "Student2688@mail.com", 180, "Student 2688" },
                    { 2689, "Student2689@mail.com", 180, "Student 2689" },
                    { 2690, "Student2690@mail.com", 180, "Student 2690" },
                    { 2691, "Student2691@mail.com", 180, "Student 2691" },
                    { 2692, "Student2692@mail.com", 180, "Student 2692" },
                    { 2693, "Student2693@mail.com", 180, "Student 2693" },
                    { 2694, "Student2694@mail.com", 180, "Student 2694" },
                    { 2695, "Student2695@mail.com", 180, "Student 2695" },
                    { 2696, "Student2696@mail.com", 180, "Student 2696" },
                    { 2697, "Student2697@mail.com", 180, "Student 2697" },
                    { 2698, "Student2698@mail.com", 180, "Student 2698" },
                    { 2699, "Student2699@mail.com", 180, "Student 2699" },
                    { 2700, "Student2700@mail.com", 180, "Student 2700" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SpecialityId_LevelId",
                table: "Exams",
                columns: new[] { "SpecialityId", "LevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SpecialityId_LevelId",
                table: "Classes",
                columns: new[] { "SpecialityId", "LevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_SpecialityLevels_SpecialityId_LevelId",
                table: "Classes",
                columns: new[] { "SpecialityId", "LevelId" },
                principalTable: "SpecialityLevels",
                principalColumns: new[] { "SpecialityId", "LevelId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_SpecialityLevels_SpecialityId_LevelId",
                table: "Exams",
                columns: new[] { "SpecialityId", "LevelId" },
                principalTable: "SpecialityLevels",
                principalColumns: new[] { "SpecialityId", "LevelId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Rooms_RoomId",
                table: "Groups",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_SpecialityLevels_SpecialityId_LevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_SpecialityLevels_SpecialityId_LevelId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Rooms_RoomId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SpecialityId_LevelId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SpecialityId_LevelId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d1e553d-8688-4a30-b9fb-1ab882c6fb05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8186cd24-7dee-4284-a5b4-c7490f7a406e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d97dc0a7-edb2-4ce3-9415-3b951b29dc42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f30c7cbe-1f71-46dd-9618-6375d6d16ee2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f692eb82-24a1-4400-9559-c2c0ef1c78e1");

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2563);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2566);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2567);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2568);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2571);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2572);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2573);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2574);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2575);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2576);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2577);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2578);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2579);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2580);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2581);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2582);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2583);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2584);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2585);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2586);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2587);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2588);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2589);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2590);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2591);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2594);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2595);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2596);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2597);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2598);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2599);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2607);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2608);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2612);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2615);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2616);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2617);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2618);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2619);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2621);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2622);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2625);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2626);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2627);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2628);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2629);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2631);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2632);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2634);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2635);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2636);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2637);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2638);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2639);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2641);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2643);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2644);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2645);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2646);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2647);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2648);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2649);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2651);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2652);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2654);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2655);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2656);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2658);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2659);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2661);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2662);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2664);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2668);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2669);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2672);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2682);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "SpecialityLevels",
                keyColumns: new[] { "LevelId", "SpecialityId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Groups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Groups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Exams",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exams",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelId",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelLevelId",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelSpecialityId",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelLevelId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityLevelSpecialityId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26bfc605-dab5-4925-88e3-c6f862db56af", null, "Teacher", "TEACHER" },
                    { "35f5ff75-c156-4d8e-ae21-cef814980769", null, "SuperAdmin", "SUPERADMIN" },
                    { "822a9478-0948-40a7-bef8-ac6c665b1b22", null, "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "d9cefcb0-c6e6-49f8-b058-d5eefd42b12a", null, "Director", "DIRECTOR" },
                    { "da809682-0d16-4ff5-893d-56d2bed8f489", null, "PrintingService", "PRINTINGSERVICE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Exams",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Classes",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Classes",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" },
                principalTable: "SpecialityLevels",
                principalColumns: new[] { "SpecialityId", "LevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Exams",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" },
                principalTable: "SpecialityLevels",
                principalColumns: new[] { "SpecialityId", "LevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Classes_ClassId",
                table: "Groups",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Rooms_RoomId",
                table: "Groups",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId");
        }
    }
}
