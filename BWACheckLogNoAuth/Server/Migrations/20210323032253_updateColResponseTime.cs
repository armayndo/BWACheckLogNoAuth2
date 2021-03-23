using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BWACheckLogNoAuth.Server.Migrations
{
    public partial class updateColResponseTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResponseTime",
                table: "ResponseDetails",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ResponseTime",
                table: "ResponseDetails",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
