using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectArticle1.Migrations
{
    public partial class NullAbleAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Author_AuthorId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Users",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Author_AuthorId",
                table: "Users",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Author_AuthorId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Author_AuthorId",
                table: "Users",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
