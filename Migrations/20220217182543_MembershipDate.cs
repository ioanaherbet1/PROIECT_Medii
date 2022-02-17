using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbet_Ioana_ONG.Migrations
{
    public partial class MembershipDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MembershipDate",
                table: "Voluntar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipDate",
                table: "Voluntar");
        }
    }
}
