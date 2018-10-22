using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleWebMvc.Migrations
{
    public partial class DepartamentoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VENDEDORES_DEPARTAMENTOS_departmentid",
                table: "VENDEDORES");

            migrationBuilder.RenameColumn(
                name: "departmentid",
                table: "VENDEDORES",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_VENDEDORES_departmentid",
                table: "VENDEDORES",
                newName: "IX_VENDEDORES_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "VENDEDORES",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VENDEDORES_DEPARTAMENTOS_DepartmentId",
                table: "VENDEDORES",
                column: "DepartmentId",
                principalTable: "DEPARTAMENTOS",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VENDEDORES_DEPARTAMENTOS_DepartmentId",
                table: "VENDEDORES");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "VENDEDORES",
                newName: "departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_VENDEDORES_DepartmentId",
                table: "VENDEDORES",
                newName: "IX_VENDEDORES_departmentid");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "VENDEDORES",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_VENDEDORES_DEPARTAMENTOS_departmentid",
                table: "VENDEDORES",
                column: "departmentid",
                principalTable: "DEPARTAMENTOS",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
