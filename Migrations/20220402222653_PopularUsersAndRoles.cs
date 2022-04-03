using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PopularUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa", "71029eae-eaae-410f-bda2-09cf95943e2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72c195ff-79e5-4840-864a-ba1abc9dac33", "b2ad36f2-a35d-4820-b650-2d47cd096715" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c195ff-79e5-4840-864a-ba1abc9dac33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71029eae-eaae-410f-bda2-09cf95943e2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2ad36f2-a35d-4820-b650-2d47cd096715");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d709469-c2fa-413e-b240-c1c77389e2d5", "5701d617-bd5a-4719-8f5a-2638a0022aec", "Member", "MEMBER" },
                    { "af626e9d-106b-4f5a-bd53-40947faf73e1", "77375756-cdf6-4c49-9c3f-7bf321bbbc5b", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1970fd9c-2f80-4a0b-99ff-378a013f2d5d", 0, "9ad4fe7d-c0b3-4d1e-91d4-f26d99c41f10", "sysmember@localhost.com", true, false, null, "SYSMEMBER@LOCALHOST.COM", "SYSMEMBER", "Member123", null, false, "11ef2984-a4f3-4d84-818a-b7e48b43873a", false, "sysmember" },
                    { "672f3b13-7717-4b7b-aa71-a56c094535e1", 0, "27446710-1b19-43ce-b495-69ee2e988c73", "sysadmin@localhost.com", true, false, null, "SYSADMIN@LOCALHOST.COM", "SYSADMIN", "Admin123", null, false, "296f61b2-7df7-42c2-8101-14e7b05a08e8", false, "sysadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d709469-c2fa-413e-b240-c1c77389e2d5", "1970fd9c-2f80-4a0b-99ff-378a013f2d5d" },
                    { "af626e9d-106b-4f5a-bd53-40947faf73e1", "672f3b13-7717-4b7b-aa71-a56c094535e1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d709469-c2fa-413e-b240-c1c77389e2d5", "1970fd9c-2f80-4a0b-99ff-378a013f2d5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af626e9d-106b-4f5a-bd53-40947faf73e1", "672f3b13-7717-4b7b-aa71-a56c094535e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d709469-c2fa-413e-b240-c1c77389e2d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af626e9d-106b-4f5a-bd53-40947faf73e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1970fd9c-2f80-4a0b-99ff-378a013f2d5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "672f3b13-7717-4b7b-aa71-a56c094535e1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa", "2ff528fa-8e70-4b64-a305-499f9547333b", "Admin", "ADMIN" },
                    { "72c195ff-79e5-4840-864a-ba1abc9dac33", "1f007696-00ad-47e7-bd95-c49f5f501d02", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "71029eae-eaae-410f-bda2-09cf95943e2f", 0, "0e7b76b0-2f9b-467e-b76c-792012d58c3a", "sysadmin@localhost.com", true, false, null, "SYSADMIN@LOCALHOST.COM", "SYSADMIN", null, null, false, "c9a00d5b-3b1d-442e-bbc8-c8c31aaf3906", false, "sysadmin" },
                    { "b2ad36f2-a35d-4820-b650-2d47cd096715", 0, "038ebbde-dd34-429a-a9c5-14a9aefbbb2d", "sysmember@localhost.com", true, false, null, "SYSMEMBER@LOCALHOST.COM", "SYSMEMBER", null, null, false, "94ddbadd-cc72-4d2f-aa5b-961ff42e689b", false, "sysmember" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5f2dcdc6-a0da-4a21-aff6-cf7bc5985dfa", "71029eae-eaae-410f-bda2-09cf95943e2f" },
                    { "72c195ff-79e5-4840-864a-ba1abc9dac33", "b2ad36f2-a35d-4820-b650-2d47cd096715" }
                });
        }
    }
}
