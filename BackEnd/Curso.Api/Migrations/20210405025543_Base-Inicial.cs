﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Curso.Api.Migrations
{
    public partial class BaseInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_USUARIO",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIO", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CURSO",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    CodigoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CURSO", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_TBL_CURSO_TBL_USUARIO_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CURSO_CodigoUsuario",
                table: "TBL_CURSO",
                column: "CodigoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_CURSO");

            migrationBuilder.DropTable(
                name: "TBL_USUARIO");
        }
    }
}
