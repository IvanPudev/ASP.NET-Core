namespace KidsCenter.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Eventstableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Events");

            migrationBuilder.AddColumn<short>(
                name: "AdultsCount",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "ChildrenCount",
                table: "Events",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdultsCount",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ChildrenCount",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
