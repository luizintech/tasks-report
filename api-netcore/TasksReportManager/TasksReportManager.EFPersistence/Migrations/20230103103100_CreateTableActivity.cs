using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasksReportManager.EFPersistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "datetime2", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    deletedat = table.Column<DateTime>(name: "deleted_at", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
