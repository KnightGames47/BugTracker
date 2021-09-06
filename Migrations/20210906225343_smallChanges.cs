using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class smallChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dueDate",
                table: "Bug",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "creationDate",
                table: "Bug",
                newName: "CreationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Bug",
                newName: "dueDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Bug",
                newName: "creationDate");
        }
    }
}
