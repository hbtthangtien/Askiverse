using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_timespan_exam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTime",
                table: "Examss",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalTime" },
                values: new object[] { new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7739), new TimeSpan(0, 0, 0, 10, 0) });

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalTime" },
                values: new object[] { new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(7751), new TimeSpan(0, 0, 0, 10, 0) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 10, 21, 19, 6, 807, DateTimeKind.Local).AddTicks(8126));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "Examss");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 89, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 22, 25, 54, 90, DateTimeKind.Local).AddTicks(387));
        }
    }
}
