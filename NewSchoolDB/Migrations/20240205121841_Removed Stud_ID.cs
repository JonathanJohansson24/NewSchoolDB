using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class RemovedStud_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stud_ID",
                table: "Grades");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stud_ID",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
