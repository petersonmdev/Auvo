using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auvo.Migrations
{
    public partial class PopularCidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('São Paulo', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Rio de Janeiro', 18)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Brasília', 27)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Salvador', 5)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Fortaleza', 6)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Belo Horizonte', 12)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Manaus', 4)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Curitiba', 15)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Recife', 16)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Goiânia', 8)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Belém', 13)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Porto Alegre', 20)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Guarulhos', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Campinas', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('São Luís', 9)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('São Gonçalo', 18)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Maceió', 2)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Duque de Caxias', 18)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Bandeira de Campo Grande', 11)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Natal', 19)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Teresina', 17)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('São Bernardo do Campo', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Nova Iguaçu', 18)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('João Pessoa', 14)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('São José dos Campos', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Santo André', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Ribeirão Preto', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Jaboatão dos Guararapes', 16)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Osasco', 24)");
            migrationBuilder.Sql("INSERT INTO Cidade(Nome, EstadoId)" +
                "VALUES('Uberlândia', 12)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cidade");
        }
    }
}
