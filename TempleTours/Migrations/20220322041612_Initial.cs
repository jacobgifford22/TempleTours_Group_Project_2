using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTours.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlotDay = table.Column<string>(nullable: true),
                    TimeSlotStart = table.Column<int>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_TimeSlots_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 1, true, "Monday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 66, true, "Saturday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 65, true, "Friday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 64, true, "Friday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 63, true, "Friday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 62, true, "Friday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 61, true, "Friday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 60, true, "Friday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 59, true, "Friday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 58, true, "Friday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 57, true, "Friday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 56, true, "Friday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 55, true, "Friday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 54, true, "Friday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 53, true, "Friday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 52, true, "Thursday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 51, true, "Thursday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 50, true, "Thursday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 49, true, "Thursday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 48, true, "Thursday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 67, true, "Saturday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 47, true, "Thursday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 68, true, "Saturday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 70, true, "Saturday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 89, true, "Sunday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 88, true, "Sunday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 87, true, "Sunday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 86, true, "Sunday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 85, true, "Sunday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 84, true, "Sunday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 83, true, "Sunday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 82, true, "Sunday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 81, true, "Sunday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 80, true, "Sunday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 79, true, "Sunday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 78, true, "Saturday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 77, true, "Saturday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 76, true, "Saturday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 75, true, "Saturday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 74, true, "Saturday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 73, true, "Saturday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 72, true, "Saturday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 71, true, "Saturday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 69, true, "Saturday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 90, true, "Sunday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 46, true, "Thursday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 44, true, "Thursday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 20, true, "Tuesday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 19, true, "Tuesday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 18, true, "Tuesday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 17, true, "Tuesday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 16, true, "Tuesday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 15, true, "Tuesday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 14, true, "Tuesday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 13, true, "Monday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 12, true, "Monday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 11, true, "Monday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 10, true, "Monday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 9, true, "Monday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 8, true, "Monday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 7, true, "Monday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 6, true, "Monday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 5, true, "Monday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 4, true, "Monday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 3, true, "Monday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 2, true, "Monday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 21, true, "Tuesday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 45, true, "Thursday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 22, true, "Tuesday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 24, true, "Tuesday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 43, true, "Thursday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 42, true, "Thursday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 41, true, "Thursday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 40, true, "Thursday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 39, true, "Wednesday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 38, true, "Wednesday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 37, true, "Wednesday", 18 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 36, true, "Wednesday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 35, true, "Wednesday", 16 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 34, true, "Wednesday", 15 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 33, true, "Wednesday", 14 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 32, true, "Wednesday", 13 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 31, true, "Wednesday", 12 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 30, true, "Wednesday", 11 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 29, true, "Wednesday", 10 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 28, true, "Wednesday", 9 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 27, true, "Wednesday", 8 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 26, true, "Tuesday", 20 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 25, true, "Tuesday", 19 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 23, true, "Tuesday", 17 });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Available", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 91, true, "Sunday", 20 });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeSlotId",
                table: "Appointments",
                column: "TimeSlotId");
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
