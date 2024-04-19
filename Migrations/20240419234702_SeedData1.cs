using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamPlanner_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04515591-69ea-4eff-9a8e-0c27d4689a79", "3efb48e6-1af7-4a01-b010-0b2eb1297b62", "Director", "DIRECTOR" },
                    { "1672a4a9-8f5e-4e32-bec4-e29d75b23ea0", "dda16624-06ac-483b-b84b-c6aa76ac0912", "PrintingService", "PRINTINGSERVICE" },
                    { "6833b036-626f-49cc-b1c3-627ec0d7b204", "9e323118-1c97-4be2-b462-cb27a3a0509a", "StudentAffairsService", "STUDENTAFFAIRSSERVICE" },
                    { "9396bd49-fb79-4090-acca-2bffbea7740d", "a1c17324-7fda-401c-954f-5ccd5457bd72", "SuperAdmin", "SUPERADMIN" },
                    { "b4c62341-a4cf-4daf-8bd5-34f1cb61781e", "c7fd5524-8bad-46cc-81b6-4d33f19f19de", "Teacher", "TEACHER" }
                });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 928, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 46, 59, 929, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 9,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 10,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 11,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 12,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 13,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 14,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 15,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 16,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 17,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 18,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 19,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 20,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 21,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 22,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 23,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 24,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 25,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 26,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 27,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 28,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 29,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 30,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 31,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 32,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 33,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 34,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 35,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 36,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 37,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 38,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 39,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 40,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 41,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 42,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 43,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 44,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 45,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 46,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 47,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 48,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 49,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 50,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 51,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 52,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 53,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 54,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 55,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 56,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 57,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 58,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 59,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 60,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 61,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 62,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 63,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 64,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 65,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 66,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 67,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 68,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 69,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 70,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 71,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 72,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 73,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 74,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 75,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 76,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 77,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 78,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 79,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 80,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 81,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 82,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 83,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 84,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 85,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 86,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 87,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 88,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 89,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 90,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 91,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 92,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 93,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 94,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 95,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 96,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 97,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 98,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 99,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 100,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 101,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 102,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 103,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 104,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 105,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 106,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 107,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 108,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 109,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 110,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 111,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 112,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 113,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 114,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 115,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 116,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 117,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 118,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 119,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 120,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 121,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 122,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 123,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 124,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 125,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 126,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 127,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 128,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 129,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 130,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 131,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 132,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 133,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 134,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 135,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 136,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 137,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 138,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 139,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 140,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 141,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 142,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 143,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 144,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 145,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 146,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 147,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 148,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 149,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 150,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 151,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 152,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 153,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 154,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 155,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 156,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 157,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 158,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 159,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 160,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 161,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 162,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 163,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 164,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 165,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 166,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 167,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 168,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 169,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 170,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 171,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 172,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 173,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 174,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 175,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 176,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 177,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 178,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 179,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 180,
                column: "RoomId",
                value: 12);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04515591-69ea-4eff-9a8e-0c27d4689a79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1672a4a9-8f5e-4e32-bec4-e29d75b23ea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6833b036-626f-49cc-b1c3-627ec0d7b204");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9396bd49-fb79-4090-acca-2bffbea7740d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4c62341-a4cf-4daf-8bd5-34f1cb61781e");

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

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2024, 4, 21, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2024, 4, 22, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2024, 4, 23, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2024, 4, 24, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2024, 4, 25, 0, 32, 46, 943, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 9,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 10,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 11,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 12,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 13,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 14,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 15,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 16,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 17,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 18,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 19,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 20,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 21,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 22,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 23,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 24,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 25,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 26,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 27,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 28,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 29,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 30,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 31,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 32,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 33,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 34,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 35,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 36,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 37,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 38,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 39,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 40,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 41,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 42,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 43,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 44,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 45,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 46,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 47,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 48,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 49,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 50,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 51,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 52,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 53,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 54,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 55,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 56,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 57,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 58,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 59,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 60,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 61,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 62,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 63,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 64,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 65,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 66,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 67,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 68,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 69,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 70,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 71,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 72,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 73,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 74,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 75,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 76,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 77,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 78,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 79,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 80,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 81,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 82,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 83,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 84,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 85,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 86,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 87,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 88,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 89,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 90,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 91,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 92,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 93,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 94,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 95,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 96,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 97,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 98,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 99,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 100,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 101,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 102,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 103,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 104,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 105,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 106,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 107,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 108,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 109,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 110,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 111,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 112,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 113,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 114,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 115,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 116,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 117,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 118,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 119,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 120,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 121,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 122,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 123,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 124,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 125,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 126,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 127,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 128,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 129,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 130,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 131,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 132,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 133,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 134,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 135,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 136,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 137,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 138,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 139,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 140,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 141,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 142,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 143,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 144,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 145,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 146,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 147,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 148,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 149,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 150,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 151,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 152,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 153,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 154,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 155,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 156,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 157,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 158,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 159,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 160,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 161,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 162,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 163,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 164,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 165,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 166,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 167,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 168,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 169,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 170,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 171,
                column: "RoomId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 172,
                column: "RoomId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 173,
                column: "RoomId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 174,
                column: "RoomId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 175,
                column: "RoomId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 176,
                column: "RoomId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 177,
                column: "RoomId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 178,
                column: "RoomId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 179,
                column: "RoomId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 180,
                column: "RoomId",
                value: 1);
        }
    }
}
