using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class remove_commentById_from_ForumComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumComments_ForumPosts_CommentById",
                table: "ForumComments");

            migrationBuilder.DropIndex(
                name: "IX_ForumComments_CommentById",
                table: "ForumComments");

            migrationBuilder.DropColumn(
                name: "CommentById",
                table: "ForumComments");

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 13, 3, 45, 490, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComments_ForumPosts_Id",
                table: "ForumComments",
                column: "Id",
                principalTable: "ForumPosts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumComments_ForumPosts_Id",
                table: "ForumComments");

            migrationBuilder.AddColumn<int>(
                name: "CommentById",
                table: "ForumComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 10, 28, 2, 601, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_CommentById",
                table: "ForumComments",
                column: "CommentById");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComments_ForumPosts_CommentById",
                table: "ForumComments",
                column: "CommentById",
                principalTable: "ForumPosts",
                principalColumn: "Id");
        }
    }
}
