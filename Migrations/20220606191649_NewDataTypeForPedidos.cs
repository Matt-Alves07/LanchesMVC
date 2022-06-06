using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class NewDataTypeForPedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(name: "datapedido", table: "lanches", schema: "pedidos");

            migrationBuilder.AddColumn<DateTime>(
                name: "datapedido",
                schema: "pedidos",
                table: "lanches",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.DropColumn(name: "dataenvio", table: "lanches", schema: "pedidos");

            migrationBuilder.AddColumn<DateTime>(
                name: "dataenvio",
                schema: "pedidos",
                table: "lanches",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c63f58d0-78bd-4dbc-9b41-59beb74b5005", "8ce1472d-f0dc-4b68-b431-7f8adf82c6aa", "Member", "MEMBER" },
                    { "db3e281a-5a99-4ea5-9a36-52de3ddc8f1a", "4ea9201d-4794-48c8-b91d-df3dbd7a3946", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93e9c4dc-9944-4068-91f5-7165406c4903", 0, "ee476a64-6682-4253-8771-07d089a33877", "sysmember@localhost.com", true, false, null, "SYSMEMBER@LOCALHOST.COM", "SYSMEMBER", "Member123", null, false, "84796ba4-2012-4cab-98e4-58827adf97b2", false, "sysmember" },
                    { "b17b4e65-b1ab-4900-85a2-3c76c3686e1f", 0, "a310db99-a584-45d5-a3d0-b7f7755f5c6f", "sysadmin@localhost.com", true, false, null, "SYSADMIN@LOCALHOST.COM", "SYSADMIN", "Admin123", null, false, "81034254-113b-4e76-9223-d2606c68a710", false, "sysadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c63f58d0-78bd-4dbc-9b41-59beb74b5005", "93e9c4dc-9944-4068-91f5-7165406c4903" },
                    { "db3e281a-5a99-4ea5-9a36-52de3ddc8f1a", "b17b4e65-b1ab-4900-85a2-3c76c3686e1f" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c63f58d0-78bd-4dbc-9b41-59beb74b5005", "93e9c4dc-9944-4068-91f5-7165406c4903" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db3e281a-5a99-4ea5-9a36-52de3ddc8f1a", "b17b4e65-b1ab-4900-85a2-3c76c3686e1f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63f58d0-78bd-4dbc-9b41-59beb74b5005");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db3e281a-5a99-4ea5-9a36-52de3ddc8f1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93e9c4dc-9944-4068-91f5-7165406c4903");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b17b4e65-b1ab-4900-85a2-3c76c3686e1f");

            migrationBuilder.AlterColumn<string>(
                name: "datapedido",
                schema: "pedidos",
                table: "lanches",
                type: "text",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "dataenvio",
                schema: "pedidos",
                table: "lanches",
                type: "text",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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
                    { "1970fd9c-2f80-4a0b-99ff-378a013f2d5d", 0, "9ad4fe7d-c0b3-4d1e-91d4-f26d99c41f10", "sysmember@localhost.com", true, false, null, "SYSMEMBER@LOCALHOST.COM", "SYSMEMBER", "KUQtJcxLbPgxjPty4CM6ARiTLu0A+3ncojtUqfZThUQ=", null, false, "11ef2984-a4f3-4d84-818a-b7e48b43873a", false, "sysmember" },
                    { "672f3b13-7717-4b7b-aa71-a56c094535e1", 0, "27446710-1b19-43ce-b495-69ee2e988c73", "sysadmin@localhost.com", true, false, null, "SYSADMIN@LOCALHOST.COM", "SYSADMIN", "7fmvQUWGAQQJTZb3rsYK9jBodY6ZXd/CP6oXvj5y7Jo=", null, false, "296f61b2-7df7-42c2-8101-14e7b05a08e8", false, "sysadmin" }
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
    }
}
