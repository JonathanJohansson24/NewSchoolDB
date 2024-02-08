using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchoolDB.Migrations
{
    /// <inheritdoc />
    public partial class removedroleid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Role_ID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "EmployeeRole",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Role_ID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRole_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "EmployeeRole",
                principalColumn: "ID");
        }
    }
}
