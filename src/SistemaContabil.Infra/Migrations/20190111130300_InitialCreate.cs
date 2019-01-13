using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaContabil.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroNf = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DataNf = table.Column<DateTime>(nullable: false),
                    CnpjEmissorNf = table.Column<string>(type: "varchar(30)", nullable: true),
                    CnpjDestinatarioNf = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaFiscal");
        }
    }
}
