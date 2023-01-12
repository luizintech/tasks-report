using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasksReportManager.EFPersistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tasktypeid = table.Column<int>(name: "task_type_id", type: "int", nullable: false),
                    activityid = table.Column<int>(name: "activity_id", type: "int", nullable: false),
                    url = table.Column<string>(type: "varchar(255)", nullable: true),
                    timeelapsed = table.Column<TimeSpan>(name: "time_elapsed", type: "time", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    deletedat = table.Column<DateTime>(name: "deleted_at", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tasks_Activities_activity_id",
                        column: x => x.activityid,
                        principalTable: "Activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_task_type_id",
                        column: x => x.tasktypeid,
                        principalTable: "TaskTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_activity_id",
                table: "Tasks",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_task_type_id",
                table: "Tasks",
                column: "task_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
