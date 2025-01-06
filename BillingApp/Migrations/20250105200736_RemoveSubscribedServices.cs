using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSubscribedServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubscribedServices",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscribedServices",
                table: "Customers");
        }
    }
}
