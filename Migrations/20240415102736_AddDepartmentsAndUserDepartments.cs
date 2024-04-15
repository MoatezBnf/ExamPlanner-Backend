using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamPlanner_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentsAndUserDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a4b380-1f42-4802-b0e4-d3ef424c6d5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3cf808-24aa-40df-ae95-33fc22e4954e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36948849-0dad-4c14-98df-cdd4aad9e5de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754e18e0-d80b-4716-8f6a-3cf39533cfc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e147dd1d-d950-4884-83cd-b80cfbe79c4f");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentIds = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartments", x => new { x.UserId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_UserDepartments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Departments_DepartmentId",
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
                    { "30c57b24-e9d1-437a-9a8c-aa008731c585", null, "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "66a87b82-7c6d-4a46-8705-18269b6c4957", null, "Teacher", "TEACHER" },
                    { "9478bff6-dedc-467f-ba73-b3a6ba2017ab", null, "PrintingService", "PRINTINGSERVICE" },
                    { "9c6734f8-c4c2-4ff4-bbb1-31078d9dbcf2", null, "Director", "DIRECTOR" },
                    { "e6e55119-d537-4295-9ade-f5c18e96cd68", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, "SuperAdmin" },
                    { 2, "Digital" },
                    { 3, "Business" },
                    { 4, "Polytechnic" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropTable(
                name: "Departments");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a4b380-1f42-4802-b0e4-d3ef424c6d5e", null, "Teacher", "TEACHER" },
                    { "1c3cf808-24aa-40df-ae95-33fc22e4954e", null, "SuperAdmin", "SUPERADMIN" },
                    { "36948849-0dad-4c14-98df-cdd4aad9e5de", null, "PrintingService", "PRINTINGSERVICE" },
                    { "754e18e0-d80b-4716-8f6a-3cf39533cfc6", null, "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "e147dd1d-d950-4884-83cd-b80cfbe79c4f", null, "Director", "DIRECTOR" }
                });
        }
    }
}
