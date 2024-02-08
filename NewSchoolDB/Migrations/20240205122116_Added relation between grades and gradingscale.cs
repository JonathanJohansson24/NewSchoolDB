using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationbetweengradesandgradingscale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradingScalesID",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GradingScalesID",
                table: "Grades",
                column: "GradingScalesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_GradesScale_GradingScalesID",
                table: "Grades",
                column: "GradingScalesID",
                principalTable: "GradesScale",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_GradesScale_GradingScalesID",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_GradingScalesID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "GradingScalesID",
                table: "Grades");
        }
    }
}
