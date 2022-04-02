using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PopularUsersERoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ae45af9-ffc2-4476-9c28-f0c1aece93f2", "04868c43-6d5c-40e7-9cec-670d4f0b47db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97ea6f14-8648-4b64-84d1-1a385b24e9e5", "b212a5b7-a746-4bb0-bb35-2031dcd47bb1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ae45af9-ffc2-4476-9c28-f0c1aece93f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97ea6f14-8648-4b64-84d1-1a385b24e9e5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2ae45af9-ffc2-4476-9c28-f0c1aece93f2", "c793b2a6-fd0b-453c-b8a5-8e097aae1e98", "Admin", "ADMIN" },
                    { "97ea6f14-8648-4b64-84d1-1a385b24e9e5", "0228e0b4-3898-44f8-b384-a457e176c344", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2ae45af9-ffc2-4476-9c28-f0c1aece93f2", "04868c43-6d5c-40e7-9cec-670d4f0b47db" },
                    { "97ea6f14-8648-4b64-84d1-1a385b24e9e5", "b212a5b7-a746-4bb0-bb35-2031dcd47bb1" }
                });
        }
    }
}
