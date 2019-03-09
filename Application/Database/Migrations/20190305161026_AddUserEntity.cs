using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AddUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "MoinPersonal",
                table: "ProServices",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                schema: "MoinPersonal",
                table: "ProServices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
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
                    UserName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "MoinPersonal");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                schema: "MoinPersonal",
                table: "ProServices");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "MoinPersonal",
                table: "ProServices",
                newName: "ID");
        }
    }
}
