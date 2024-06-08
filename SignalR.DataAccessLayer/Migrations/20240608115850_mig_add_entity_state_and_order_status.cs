using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_entity_state_and_order_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Testimonials",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Products",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Categories",
                newName: "State");

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "SocialMedias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "OrderDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Features",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Discounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Testimonials",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Products",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Categories",
                newName: "Status");
        }
    }
}
