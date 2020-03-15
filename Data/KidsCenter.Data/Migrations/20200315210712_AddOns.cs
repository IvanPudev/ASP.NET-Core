namespace KidsCenter.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddOns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddOns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PriceId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddOns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddOns_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventAddOn",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    AddOnId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAddOn", x => new { x.EventId, x.AddOnId });
                    table.ForeignKey(
                        name: "FK_EventAddOn_AddOns_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "AddOns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventAddOn_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddOns_IsDeleted",
                table: "AddOns",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_AddOns_PriceId",
                table: "AddOns",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAddOn_AddOnId",
                table: "EventAddOn",
                column: "AddOnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAddOn");

            migrationBuilder.DropTable(
                name: "AddOns");
        }
    }
}
