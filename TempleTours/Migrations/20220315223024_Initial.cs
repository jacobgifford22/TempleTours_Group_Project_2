using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTours.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentTime = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlotStart = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotStart" },
                values: new object[] { 1L, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotStart" },
                values: new object[] { 2L, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotStart" },
                values: new object[] { 3L, "10:00 AM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
