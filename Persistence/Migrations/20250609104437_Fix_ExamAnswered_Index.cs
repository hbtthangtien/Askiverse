using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fix_ExamAnswered_Index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamssScoreds_Examss_ExamId",
                table: "ExamssScoreds");

            migrationBuilder.DropIndex(
                name: "IX_ExamAnswereds_AnswerId",
                table: "ExamAnswereds");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "ExamssScoreds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 183, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 9, 17, 44, 36, 184, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswereds_AnswerId",
                table: "ExamAnswereds",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamssScoreds_Examss_ExamId",
                table: "ExamssScoreds",
                column: "ExamId",
                principalTable: "Examss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamssScoreds_Examss_ExamId",
                table: "ExamssScoreds");

            migrationBuilder.DropIndex(
                name: "IX_ExamAnswereds_AnswerId",
                table: "ExamAnswereds");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "ExamssScoreds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswereds_AnswerId",
                table: "ExamAnswereds",
                column: "AnswerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamssScoreds_Examss_ExamId",
                table: "ExamssScoreds",
                column: "ExamId",
                principalTable: "Examss",
                principalColumn: "Id");
        }
    }
}
