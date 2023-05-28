using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class SliderColumnUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondTitle",
                table: "Sliders",
                newName: "Title2");

            migrationBuilder.RenameColumn(
                name: "FirstTitle",
                table: "Sliders",
                newName: "Title1");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Sliders",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "ButtonUrl",
                table: "Sliders",
                newName: "BtnUrl");

            migrationBuilder.RenameColumn(
                name: "ButtonText",
                table: "Sliders",
                newName: "BtnText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "Sliders",
                newName: "SecondTitle");

            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "Sliders",
                newName: "FirstTitle");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Sliders",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "BtnUrl",
                table: "Sliders",
                newName: "ButtonUrl");

            migrationBuilder.RenameColumn(
                name: "BtnText",
                table: "Sliders",
                newName: "ButtonText");
        }
    }
}
