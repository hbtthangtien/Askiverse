using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_packageUser_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOfUsers_PremiumUsers_UserId",
                table: "PackageOfUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOfUsers_BasicUser_UserId",
                table: "PackageOfUsers",
                column: "UserId",
                principalTable: "BasicUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOfUsers_BasicUser_UserId",
                table: "PackageOfUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOfUsers_PremiumUsers_UserId",
                table: "PackageOfUsers",
                column: "UserId",
                principalTable: "PremiumUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
