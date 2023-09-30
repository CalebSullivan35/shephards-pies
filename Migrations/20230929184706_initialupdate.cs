using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shephards_pies.Migrations
{
    public partial class initialupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "57cc707d-9be3-4047-89d0-4ac8d90457d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dfba183-52c7-4e19-b9c9-98d81954c8aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c147c8-10e3-43de-84c4-d39b38da2ec6", "AQAAAAEAACcQAAAAEGnkFHEWwYSYfPMuO4Ylztf/mGiOpH0pUsEIyCC3fGDN1N6lEP+zGLKp/zb2OrArEw==", "252c1b3e-daab-4382-90f4-76dd7cac9ecc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc803ab6-b2ec-495c-87d8-caaa8f0ca2f8", "AQAAAAEAACcQAAAAEOXT5RyO6ZTTZ69AMFS2L11Rdd/sbpFoJ3HJXk5H0qYX5NS4MYf8bfv/7kZur5itIQ==", "71f45362-7e2d-4a4e-bc0d-2f402ea6551c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6e6e14d-15b3-4a63-9f94-9f78c49ffbb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "277acc31-f5ef-4e82-ac14-29d679d2ad67", "AQAAAAEAACcQAAAAEPD7yeRIt+wFu3U3KXNTHG05izJoxM2mm9laCyY2xWcGES0oQbXohEqiDpA4oVGplQ==", "d5e0687f-3e6a-42b4-934f-f832a077c5f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f754ad17-11bf-4b2e-8ca0-9c04812fcf68",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6085f69f-b0b6-4ba4-a9f9-8e3697f84ec9", "AQAAAAEAACcQAAAAECUtKj6aHhOtkyixz3GQoQZX/MaeAihHmIobdSZaFEICJ2Ak0e7k3worp0I+rpcC4g==", "bff3dcf7-42bd-401d-8f5a-05ec22a82651" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TableId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "964d9b9d-0a7e-4c2f-9f82-c4b0eab04992");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dfba183-52c7-4e19-b9c9-98d81954c8aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e284345-17bf-4941-b260-d27acfa6df05", "AQAAAAEAACcQAAAAEMArHoL6Z0Tj3EsmNuuWBqwYsFxRugf9Mpd71rIXbYa4NDCjW6yXDM4EiKt0tLQ3yQ==", "1e6b5c2b-23d9-4ae3-b0ed-08ebd690f84a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0843ef9f-75a3-4eec-98b5-a3989b6d5636", "AQAAAAEAACcQAAAAEB8bw/0JRZGIi2MEFMkDSownsj6aMzoLqgbs7LSyYN4Q8DGY+uzZraPhsS1LvYFmBQ==", "a969798a-6e70-44bd-af82-63c188938565" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6e6e14d-15b3-4a63-9f94-9f78c49ffbb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9dec17a-205c-4e4e-9f52-c0da9dd77b10", "AQAAAAEAACcQAAAAELpQkX8TmtP8k/l7buOIzeWobrYKoCbaxkuM1rCIt19gWy2pjh3cxyJOL/b9WF509A==", "a1035787-a949-4fc3-a031-3f51c56eb556" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f754ad17-11bf-4b2e-8ca0-9c04812fcf68",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "205d89d4-337d-42dc-b993-b4a6348b4b34", "AQAAAAEAACcQAAAAEBwcZ2q/lKLxW9h8v5ytMwFLK8QjlqgTLIFULV3sNLP3ydZeliUMe30i6bBoRjcCww==", "d0441d23-30be-4e4c-b5b6-6cc803cc3989" });
        }
    }
}
