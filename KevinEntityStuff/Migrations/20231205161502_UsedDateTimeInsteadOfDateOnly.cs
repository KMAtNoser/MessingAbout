using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KevinEntities.Migrations
{
    /// <inheritdoc />
    public partial class UsedDateTimeInsteadOfDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecast",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "WeatherForecast",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
