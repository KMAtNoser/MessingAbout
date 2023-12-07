using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KevinEntities.Migrations
{
    /// <inheritdoc />
    public partial class GotRidOfFarenheitInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemperatureF",
                table: "WeatherForecast");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TemperatureF",
                table: "WeatherForecast",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
