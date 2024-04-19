using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamPlanner_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Departments_DepartmentId",
                table: "Specialities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "121807c2-02f7-432d-80fa-65fac9615168");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d4ad566-3bee-4273-86a5-115826cd0294");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a9cec3-d06b-4fc0-9478-e0f5b2f4d503");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb0b608f-a7ed-40d5-89c5-5792b5b32b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5063e54-63f3-4cbc-9f61-5c796fb3d25a");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Specialities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialityLevels",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialityLevels", x => new { x.SpecialityId, x.LevelId });
                    table.ForeignKey(
                        name: "FK_SpecialityLevels_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialityLevels_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "SpecialityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityLevelId = table.Column<int>(type: "int", nullable: true),
                    SpecialityLevelSpecialityId = table.Column<int>(type: "int", nullable: true),
                    SpecialityLevelLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Classes_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                        columns: x => new { x.SpecialityLevelSpecialityId, x.SpecialityLevelLevelId },
                        principalTable: "SpecialityLevels",
                        principalColumns: new[] { "SpecialityId", "LevelId" });
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    SpecialityLevelId = table.Column<int>(type: "int", nullable: true),
                    SpecialityLevelSpecialityId = table.Column<int>(type: "int", nullable: true),
                    SpecialityLevelLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exams_SpecialityLevels_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                        columns: x => new { x.SpecialityLevelSpecialityId, x.SpecialityLevelLevelId },
                        principalTable: "SpecialityLevels",
                        principalColumns: new[] { "SpecialityId", "LevelId" });
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Groups_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId");
                });

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
                name: "IX_Classes_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Classes",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SpecialityLevelSpecialityId_SpecialityLevelLevelId",
                table: "Exams",
                columns: new[] { "SpecialityLevelSpecialityId", "SpecialityLevelLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ClassId",
                table: "Groups",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_RoomId",
                table: "Groups",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityLevels_LevelId",
                table: "SpecialityLevels",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Departments_DepartmentId",
                table: "Specialities",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Departments_DepartmentId",
                table: "Specialities");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "SpecialityLevels");

            migrationBuilder.DropTable(
                name: "Levels");

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

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Specialities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "121807c2-02f7-432d-80fa-65fac9615168", null, "SuperAdmin", "SUPERADMIN" },
                    { "7d4ad566-3bee-4273-86a5-115826cd0294", null, "Teacher", "TEACHER" },
                    { "a1a9cec3-d06b-4fc0-9478-e0f5b2f4d503", null, "PrintingService", "PRINTINGSERVICE" },
                    { "eb0b608f-a7ed-40d5-89c5-5792b5b32b4b", null, "Director", "DIRECTOR" },
                    { "f5063e54-63f3-4cbc-9f61-5c796fb3d25a", null, "StudentAffairsService", "STUDENTAFFAIRSSERVICE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Departments_DepartmentId",
                table: "Specialities",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
