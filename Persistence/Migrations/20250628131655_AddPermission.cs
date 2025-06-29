using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8892));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 0, 26, 56, 152, DateTimeKind.Local).AddTicks(5153));
        }
    }
}
