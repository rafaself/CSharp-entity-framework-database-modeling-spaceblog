using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceBlogDb.Migrations
{
    /// <inheritdoc />
    public partial class SettingUpDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsCategoryPost_PostsCategories_PostsCategoryId",
                table: "PostsCategoryPost");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsCategoryPost_Posts_PostId",
                table: "PostsCategoryPost");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsCategoryPost_PostsCategories_PostsCategoryId",
                table: "PostsCategoryPost",
                column: "PostsCategoryId",
                principalTable: "PostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsCategoryPost_Posts_PostId",
                table: "PostsCategoryPost",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsCategoryPost_PostsCategories_PostsCategoryId",
                table: "PostsCategoryPost");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsCategoryPost_Posts_PostId",
                table: "PostsCategoryPost");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsCategoryPost_PostsCategories_PostsCategoryId",
                table: "PostsCategoryPost",
                column: "PostsCategoryId",
                principalTable: "PostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsCategoryPost_Posts_PostId",
                table: "PostsCategoryPost",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
