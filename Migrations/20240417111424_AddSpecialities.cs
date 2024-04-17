using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamPlanner_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecialities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30c57b24-e9d1-437a-9a8c-aa008731c585");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66a87b82-7c6d-4a46-8705-18269b6c4957");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9478bff6-dedc-467f-ba73-b3a6ba2017ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c6734f8-c4c2-4ff4-bbb1-31078d9dbcf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6e55119-d537-4295-9ade-f5c18e96cd68");

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SpecialityId);
                    table.ForeignKey(
                        name: "FK_Specialities_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_DepartmentId",
                table: "Specialities",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialities");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30c57b24-e9d1-437a-9a8c-aa008731c585", null, "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "66a87b82-7c6d-4a46-8705-18269b6c4957", null, "Teacher", "TEACHER" },
                    { "9478bff6-dedc-467f-ba73-b3a6ba2017ab", null, "PrintingService", "PRINTINGSERVICE" },
                    { "9c6734f8-c4c2-4ff4-bbb1-31078d9dbcf2", null, "Director", "DIRECTOR" },
                    { "e6e55119-d537-4295-9ade-f5c18e96cd68", null, "SuperAdmin", "SUPERADMIN" }
                });
        }
    }
}
