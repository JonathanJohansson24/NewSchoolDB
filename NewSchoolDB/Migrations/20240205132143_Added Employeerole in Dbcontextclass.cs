using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeroleinDbcontextclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole");

            migrationBuilder.RenameTable(
                name: "EmployeeRole",
                newName: "EmployeesRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesRole",
                table: "EmployeesRole",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeesRole_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "EmployeesRole",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeesRole_RoleID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesRole",
                table: "EmployeesRole");

            migrationBuilder.RenameTable(
                name: "EmployeesRole",
                newName: "EmployeeRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "EmployeeRole",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
