using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleWebMvc.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEPARTAMENTOS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTAMENTOS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VENDEDORES",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_vendedor = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 30, nullable: true),
                    salario_base = table.Column<double>(nullable: false),
                    data_nascimento = table.Column<DateTime>(nullable: false),
                    departmentid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDEDORES", x => x.id);
                    table.ForeignKey(
                        name: "FK_VENDEDORES_DEPARTAMENTOS_departmentid",
                        column: x => x.departmentid,
                        principalTable: "DEPARTAMENTOS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VENDAS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    data_venda = table.Column<DateTime>(nullable: false),
                    total = table.Column<double>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    sellerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDAS", x => x.id);
                    table.ForeignKey(
                        name: "FK_VENDAS_VENDEDORES_sellerid",
                        column: x => x.sellerid,
                        principalTable: "VENDEDORES",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_sellerid",
                table: "VENDAS",
                column: "sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_VENDEDORES_departmentid",
                table: "VENDEDORES",
                column: "departmentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VENDAS");

            migrationBuilder.DropTable(
                name: "VENDEDORES");

            migrationBuilder.DropTable(
                name: "DEPARTAMENTOS");
        }
    }
}
