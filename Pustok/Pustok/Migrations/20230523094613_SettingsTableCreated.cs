using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class SettingsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTags",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookImages",
                table: "BookImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "BookTags",
                newName: "BookTag");

            migrationBuilder.RenameTable(
                name: "BookImages",
                newName: "BookImage");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_BookTags_TagId",
                table: "BookTag",
                newName: "IX_BookTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_BookImages_BookId",
                table: "BookImage",
                newName: "IX_BookImage_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTag",
                table: "BookTag",
                columns: new[] { "BookId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookImage",
                table: "BookImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookImage_Books_BookId",
                table: "BookImage",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTag_Books_BookId",
                table: "BookTag",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTag_Tags_TagId",
                table: "BookTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImage_Books_BookId",
                table: "BookImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTag_Books_BookId",
                table: "BookTag");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTag_Tags_TagId",
                table: "BookTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTag",
                table: "BookTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookImage",
                table: "BookImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "BookTag",
                newName: "BookTags");

            migrationBuilder.RenameTable(
                name: "BookImage",
                newName: "BookImages");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_BookTag_TagId",
                table: "BookTags",
                newName: "IX_BookTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_BookImage_BookId",
                table: "BookImages",
                newName: "IX_BookImages_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTags",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookImages",
                table: "BookImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
