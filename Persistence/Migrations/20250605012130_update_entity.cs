using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOfUsers_PackageDurations_PackageDurationId",
                table: "PackageOfUsers");

            migrationBuilder.DropTable(
                name: "PackageDurations");

            migrationBuilder.DropIndex(
                name: "IX_PackageOfUsers_PackageDurationId",
                table: "PackageOfUsers");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "PackageOfUsers");

            migrationBuilder.DropColumn(
                name: "PackageDurationId",
                table: "PackageOfUsers");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "SubcriptionPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SubcriptionPackages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "SubcriptionPackages");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SubcriptionPackages");

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "PackageOfUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackageDurationId",
                table: "PackageOfUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PackageDurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDurations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageOfUsers_PackageDurationId",
                table: "PackageOfUsers",
                column: "PackageDurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOfUsers_PackageDurations_PackageDurationId",
                table: "PackageOfUsers",
                column: "PackageDurationId",
                principalTable: "PackageDurations",
                principalColumn: "Id");
        }
    }
}
