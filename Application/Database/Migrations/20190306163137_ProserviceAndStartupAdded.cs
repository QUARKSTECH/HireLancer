using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class ProserviceAndStartupAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                schema: "MoinPersonal",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StartUps",
                schema: "MoinPersonal",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IsDraft = table.Column<bool>(nullable: false),
                    ExternalID = table.Column<Guid>(nullable: false),
                    VentureName = table.Column<string>(nullable: true),
                    InvestmentRequired = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    SubSector = table.Column<string>(nullable: true),
                    CurrentStage = table.Column<string>(nullable: true),
                    ExtraMessage = table.Column<string>(nullable: true),
                    GetToKnow = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartUps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartUps",
                schema: "MoinPersonal");

            migrationBuilder.DropColumn(
                name: "City",
                schema: "MoinPersonal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "MoinPersonal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "MoinPersonal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "MoinPersonal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "MoinPersonal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                schema: "MoinPersonal",
                table: "Users");
        }
    }
}
