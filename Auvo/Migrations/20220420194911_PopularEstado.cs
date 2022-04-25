using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auvo.Migrations
{
    public partial class PopularEstado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Acre', 'AC')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Alagoas', 'AL')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Amapá', 'AP')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Amazonas', 'AM')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Bahia', 'BA')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Ceará', 'CE')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Espírito Santo', 'ES')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Goiás', 'GO')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Maranhão', 'MA')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Mato Grosso', 'MT')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Mato Grosso do Sul', 'MS')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Minas Gerais', 'MG')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Pará', 'PA')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Paraíba', 'PB')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Paraná', 'PR')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Pernambuco', 'PE')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Piauí', 'PI')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Rio de Janeiro', 'RJ')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Rio Grande do Norte', 'RN')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Rio Grande do Sul', 'RS')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Rondônia', 'RO')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Roraima', 'RR')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Santa Catarina', 'SC')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('São Paulo', 'SP')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Sergipe', 'SE')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Tocantins', 'TO')");
            migrationBuilder.Sql("INSERT INTO Estado(Nome, UF) " +
                "VALUES('Distrito Federal', 'DF')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Estado");
        }
    }
}
