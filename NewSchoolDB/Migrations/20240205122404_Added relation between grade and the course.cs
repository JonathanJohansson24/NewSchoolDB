using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationbetweengradeandthecourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseID",
                table: "Grades",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Courses_CourseID",
                table: "Grades",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Courses_CourseID",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_CourseID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Grades");
        }
    }
}
