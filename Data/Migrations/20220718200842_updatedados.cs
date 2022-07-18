using Microsoft.EntityFrameworkCore.Migrations;

namespace Jauto.Data.Migrations
{
    public partial class updatedados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "5639eaac-69f5-46db-aedc-9c976ad222ca", "Admin", "ADMIN" },
                    { "C", "d498394e-6ff5-49ea-aaa3-010995d15185", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "MetodoPagamento",
                columns: new[] { "IdPagamento", "TipoPagamento" },
                values: new object[,]
                {
                    { 1, "Multibanco" },
                    { 3, "Cartão de Crédito" },
                    { 2, "MBway" }
                });

            migrationBuilder.InsertData(
                table: "Oficinas",
                columns: new[] { "IdOficina", "CodigoPostal", "Imagem", "Localidade", "Morada", "Nome", "NumTelemovel" },
                values: new object[,]
                {
                    { 1, "1400 - 145", "id1_boxcarvulcolisboa.jpg", "Lisboa", "Rua Fernão Mendes Pinto Lote M-T", "Boxcar Vulco Lisboa", "912 360 073" },
                    { 12, "5300-107", "id12.jpg", "Bragança", "Avenida das Cantarias n.º 130", "Auto Imperial", "273 302 600" },
                    { 11, "3800-301", "id11_corvauto.jpg", "Aveiro", "Rua Duarte Ludgero, Esgueira", "Corvauto", "234 303 150" },
                    { 10, "2460-477", "id10.jpg", "Alcobaça, Leiria", "Zona Industrial Cabeço de Deus", "Auto Nogueiras", "262 585 252" },
                    { 9, "2005-002", "id9_martinho.jpg", "Santarém", "Rua Doutor Hilário Barreiro Nunes Lote 26B, Zona Industrial", "Martinho Auto", "243 302 228" },
                    { 13, "8100-289", "id13_rinoauto.jpg", "Loulé, Faro", "Cerro Cabeça de Câmara", "Rino - Auto Alexandre", "289 410 660" },
                    { 7, "3500-188", "id7_automotor.jpg", "Viseu", "Travassós de Baixo, Estrada São João da Carreira", "Automotorsport", "918 702 101" },
                    { 6, "3105-238", "id6_meiricarro.jpg", "Pombal, Leiria", "Rua das Covinhas, Santiago de Litém", "MEIRICARRO", "236 948 477" },
                    { 5, "2825 - 895", "id5_jsa.jpg", "Almada, Setúbal", "Rua 27 de Julho n.º 27, Trafaria", "JSA", "960 306 191" },
                    { 4, "2900 - 395", "id4.jpg", "Setúbal", "Rua Guilherme Gomes Fernandes n.º 1", "Manuel Jorge Santos Pereira", "921321817" },
                    { 3, "4445 - 245", "id3_autoarcadgua2.jpg", "Valongo, Porto", "Rua 1º de Maio n.º 614B, Alfena", "Auto Arca D'Água 2", "229 689 811" },
                    { 2, "4705 - 084", "id2_braga.jpg", "Braga", "Avenida Cidade do Porto n.º 182, Ferreiros", "Confiauto Braga", "252 248 500" },
                    { 8, "3070-604", "id8.jpg", "Mira, Coimbra", "Rua da Floresta n.º 255, Carapelhos", "Auto Carapelhos", "231 451 782" }
                });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "IdServ", "Servico" },
                values: new object[,]
                {
                    { 14, "GPL Auto" },
                    { 13, "Assistência em Viagem" },
                    { 12, "Tuning" },
                    { 11, "Pintura" },
                    { 10, "Lavagem" },
                    { 9, "Eletricidade/Eletrónica" },
                    { 6, "Inspeção Periódica" },
                    { 7, "Bate-chapas" },
                    { 5, "Pneus" },
                    { 4, "Mecânica" },
                    { 3, "Vidros" },
                    { 1, "Ar Condicionado" },
                    { 8, "Cortesia/Mobilidade" },
                    { 2, "Estofos" }
                });

            migrationBuilder.InsertData(
                table: "OficinasServicos",
                columns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 10, 9 },
                    { 9, 9 },
                    { 8, 9 },
                    { 7, 9 },
                    { 6, 9 },
                    { 4, 9 },
                    { 3, 9 },
                    { 2, 9 },
                    { 1, 9 },
                    { 13, 8 },
                    { 12, 8 },
                    { 9, 8 },
                    { 11, 9 },
                    { 8, 8 },
                    { 6, 8 },
                    { 4, 8 },
                    { 2, 8 },
                    { 1, 8 },
                    { 13, 7 },
                    { 12, 7 },
                    { 11, 7 },
                    { 10, 7 },
                    { 9, 7 },
                    { 8, 7 },
                    { 7, 7 },
                    { 6, 7 },
                    { 7, 8 },
                    { 12, 9 },
                    { 13, 9 },
                    { 1, 10 },
                    { 5, 14 },
                    { 4, 14 },
                    { 1, 14 },
                    { 13, 13 },
                    { 10, 13 },
                    { 8, 13 },
                    { 4, 13 },
                    { 13, 12 },
                    { 7, 12 },
                    { 3, 12 },
                    { 13, 11 }
                });

            migrationBuilder.InsertData(
                table: "OficinasServicos",
                columns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                values: new object[,]
                {
                    { 12, 11 },
                    { 11, 11 },
                    { 10, 11 },
                    { 9, 11 },
                    { 8, 11 },
                    { 7, 11 },
                    { 6, 11 },
                    { 5, 11 },
                    { 4, 11 },
                    { 3, 11 },
                    { 1, 11 },
                    { 13, 10 },
                    { 12, 10 },
                    { 9, 10 },
                    { 8, 10 },
                    { 4, 10 },
                    { 5, 7 },
                    { 4, 7 },
                    { 3, 7 },
                    { 2, 7 },
                    { 12, 3 },
                    { 10, 3 },
                    { 9, 3 },
                    { 8, 3 },
                    { 7, 3 },
                    { 4, 3 },
                    { 3, 3 },
                    { 2, 3 },
                    { 13, 2 },
                    { 12, 2 },
                    { 9, 2 },
                    { 8, 2 },
                    { 7, 2 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 13, 1 },
                    { 12, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "OficinasServicos",
                columns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 13, 3 },
                    { 12, 14 },
                    { 1, 4 },
                    { 3, 4 },
                    { 1, 7 },
                    { 13, 6 },
                    { 12, 6 },
                    { 11, 6 },
                    { 9, 6 },
                    { 8, 6 },
                    { 7, 6 },
                    { 6, 6 },
                    { 4, 6 },
                    { 2, 6 },
                    { 13, 5 },
                    { 12, 5 },
                    { 10, 5 },
                    { 8, 5 },
                    { 7, 5 },
                    { 4, 5 },
                    { 3, 5 },
                    { 2, 5 },
                    { 13, 4 },
                    { 12, 4 },
                    { 10, 4 },
                    { 9, 4 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 4 },
                    { 5, 4 },
                    { 4, 4 },
                    { 2, 4 },
                    { 13, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "MetodoPagamento",
                keyColumn: "IdPagamento",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MetodoPagamento",
                keyColumn: "IdPagamento",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MetodoPagamento",
                keyColumn: "IdPagamento",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "OficinasServicos",
                keyColumns: new[] { "ListaOficinasIdOficina", "ListaServicosIdServ" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Oficinas",
                keyColumn: "IdOficina",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Servicos",
                keyColumn: "IdServ",
                keyValue: 14);
        }
    }
}
