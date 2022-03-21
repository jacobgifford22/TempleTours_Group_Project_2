using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTours.Migrations
{
    public partial class TimeSlots : Migration
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
                    TimeSlotStart = table.Column<string>(nullable: true),
                    TimeSlotDay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 1L, "Monday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 66L, "Saturday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 65L, "Friday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 64L, "Friday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 63L, "Friday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 62L, "Friday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 61L, "Friday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 60L, "Friday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 59L, "Friday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 58L, "Friday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 57L, "Friday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 56L, "Friday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 55L, "Friday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 54L, "Friday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 53L, "Friday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 52L, "Thursday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 51L, "Thursday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 50L, "Thursday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 49L, "Thursday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 48L, "Thursday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 67L, "Saturday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 47L, "Thursday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 68L, "Saturday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 70L, "Saturday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 89L, "Sunday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 88L, "Sunday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 87L, "Sunday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 86L, "Sunday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 85L, "Sunday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 84L, "Sunday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 83L, "Sunday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 82L, "Sunday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 81L, "Sunday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 80L, "Sunday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 79L, "Sunday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 78L, "Saturday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 77L, "Saturday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 76L, "Saturday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 75L, "Saturday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 74L, "Saturday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 73L, "Saturday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 72L, "Saturday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 71L, "Saturday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 69L, "Saturday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 90L, "Sunday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 46L, "Thursday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 44L, "Thursday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 20L, "Tuesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 19L, "Tuesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 18L, "Tuesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 17L, "Tuesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 16L, "Tuesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 15L, "Tuesday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 14L, "Tuesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 13L, "Monday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 12L, "Monday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 11L, "Monday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 10L, "Monday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 9L, "Monday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 8L, "Monday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 7L, "Monday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 6L, "Monday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 5L, "Monday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 4L, "Monday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 3L, "Monday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 2L, "Monday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 21L, "Tuesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 45L, "Thursday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 22L, "Tuesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 24L, "Tuesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 43L, "Thursday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 42L, "Thursday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 41L, "Thursday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 40L, "Thursday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 39L, "Wednesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 38L, "Wednesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 37L, "Wednesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 36L, "Wednesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 35L, "Wednesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 34L, "Wednesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 33L, "Wednesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 32L, "Wednesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 31L, "Wednesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 30L, "Wednesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 29L, "Wednesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 28L, "Wednesday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 27L, "Wednesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 26L, "Tuesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 25L, "Tuesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 23L, "Tuesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "TimeSlotDay", "TimeSlotStart" },
                values: new object[] { 91L, "Sunday", "8:00 PM" });
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
