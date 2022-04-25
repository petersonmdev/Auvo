using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auvo.Migrations
{
    public partial class PopularPrevisaoClima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 22.0, 26.0, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-21 00:00:00.0000000', 'Tempestade', 23.0, 24.0, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-22 00:00:00.0000000', 'Tempestade', 27.0, 28.0, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-23 00:00:00.0000000', 'Tempestade', 20.0, 26.5, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-24 00:00:00.0000000', 'Tempestade', 11.1, 15.3, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-25 00:00:00.0000000', 'Tempestade', 19.0, 23.0, 1)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-26 00:00:00.0000000', 'Tempestade', 25.4, 35.2, 1)");

            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 20.0, 26.5, 2)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 22.0, 23.9, 3)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 25.4, 35.2, 4)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 19.6, 22.6, 5)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 25.5, 34.0, 6)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 10.0, 20.7, 7)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 11.1, 15.3, 8)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 35.4, 38.2, 9)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 36.6, 39.1, 10)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 9.5, 11.0, 11)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 14.4, 16.4, 12)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 8.0, 10.1, 13)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 12.6, 16.4, 14)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 18.8, 22.1, 15)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 25.7, 28.1, 16)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 33.5, 35.4, 17)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 31.1, 33.1, 18)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 36.0, 38.0, 19)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 7.7, 9.1, 20)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 10.9, 13.4, 21)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 10.8, 12.1, 22)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 22.4, 23.3, 23)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 25.9, 27.3, 24)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 26.4, 28.7, 25)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 16.4, 20.7, 26)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 21.1, 22.4, 27)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 16.4, 18.4, 28)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 18.4, 30.6, 29)");
            migrationBuilder.Sql("INSERT INTO PrevisaoClima(DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima, CidadeId)" +
                "VALUES('2022-04-20 00:00:00.0000000', 'Tempestade', 12.0, 24.0, 30)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PrevisaoClima");
        }
    }
}
