using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab1.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorksFor_Employees_EmpSSN",
                table: "WorksFor");

            migrationBuilder.DropForeignKey(
                name: "FK_WorksFor_Projects_ProjectsPnumber",
                table: "WorksFor");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsPnumber",
                table: "WorksFor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmpSSN",
                table: "WorksFor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WorksFor_Employees_EmpSSN",
                table: "WorksFor",
                column: "EmpSSN",
                principalTable: "Employees",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_WorksFor_Projects_ProjectsPnumber",
                table: "WorksFor",
                column: "ProjectsPnumber",
                principalTable: "Projects",
                principalColumn: "Pnumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorksFor_Employees_EmpSSN",
                table: "WorksFor");

            migrationBuilder.DropForeignKey(
                name: "FK_WorksFor_Projects_ProjectsPnumber",
                table: "WorksFor");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsPnumber",
                table: "WorksFor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpSSN",
                table: "WorksFor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorksFor_Employees_EmpSSN",
                table: "WorksFor",
                column: "EmpSSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WorksFor_Projects_ProjectsPnumber",
                table: "WorksFor",
                column: "ProjectsPnumber",
                principalTable: "Projects",
                principalColumn: "Pnumber",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
