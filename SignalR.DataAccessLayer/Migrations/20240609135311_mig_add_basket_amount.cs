using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_basket_amount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Baskets");
        }
    }
}
