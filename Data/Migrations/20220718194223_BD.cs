using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jauto.Data.Migrations
{
    public partial class BD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdClientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimeiroNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NCartaConducao = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Morada = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CodPostal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ntelemovel = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdClientes);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPagamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagamento", x => x.IdPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Oficinas",
                columns: table => new
                {
                    IdOficina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NumTelemovel = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficinas", x => x.IdOficina);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    IdServ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.IdServ);
                });

            migrationBuilder.CreateTable(
                name: "Marcacoes",
                columns: table => new
                {
                    IdMarcacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caucao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPagamento = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdOficina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacoes", x => x.IdMarcacao);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdClientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marcacoes_MetodoPagamento_IdPagamento",
                        column: x => x.IdPagamento,
                        principalTable: "MetodoPagamento",
                        principalColumn: "IdPagamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Oficinas_IdOficina",
                        column: x => x.IdOficina,
                        principalTable: "Oficinas",
                        principalColumn: "IdOficina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OficinasServicos",
                columns: table => new
                {
                    ListaOficinasIdOficina = table.Column<int>(type: "int", nullable: false),
                    ListaServicosIdServ = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OficinasServicos", x => new { x.ListaOficinasIdOficina, x.ListaServicosIdServ });
                    table.ForeignKey(
                        name: "FK_OficinasServicos_Oficinas_ListaOficinasIdOficina",
                        column: x => x.ListaOficinasIdOficina,
                        principalTable: "Oficinas",
                        principalColumn: "IdOficina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OficinasServicos_Servicos_ListaServicosIdServ",
                        column: x => x.ListaServicosIdServ,
                        principalTable: "Servicos",
                        principalColumn: "IdServ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_IdCliente",
                table: "Marcacoes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_IdOficina",
                table: "Marcacoes",
                column: "IdOficina");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_IdPagamento",
                table: "Marcacoes",
                column: "IdPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_OficinasServicos_ListaServicosIdServ",
                table: "OficinasServicos",
                column: "ListaServicosIdServ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcacoes");

            migrationBuilder.DropTable(
                name: "OficinasServicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "MetodoPagamento");

            migrationBuilder.DropTable(
                name: "Oficinas");

            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
