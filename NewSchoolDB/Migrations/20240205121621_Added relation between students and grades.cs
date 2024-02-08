using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationbetweenstudentsandgrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stud_ID",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsID",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentsID",
                table: "Grades",
                column: "StudentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentsID",
                table: "Grades",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentsID",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentsID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Stud_ID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "StudentsID",
                table: "Grades");
        }
    }
}
