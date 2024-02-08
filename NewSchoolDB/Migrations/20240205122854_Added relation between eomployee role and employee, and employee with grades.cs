using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationbetweeneomployeeroleandemployeeandemployeewithgrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleMeaning = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_EmployeeID",
                table: "Grades",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "EmployeeRole",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Employees_EmployeeID",
                table: "Grades",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Employees_EmployeeID",
                table: "Grades");

            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.DropIndex(
                name: "IX_Grades_EmployeeID",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RoleID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Employees");
        }
    }
}
