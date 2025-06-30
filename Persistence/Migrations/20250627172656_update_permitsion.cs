using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_permitsion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Permission",
                table: "ExamAccessess",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permission",
                table: "ExamAccessess");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6082));
        }
    }
}
