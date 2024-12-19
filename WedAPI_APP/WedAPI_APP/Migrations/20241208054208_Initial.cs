using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WedAPI_APP.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchandises",
                columns: table => new
                {
                    MerchandiseCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MerchandiseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MerchandiseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandisePrice = table.Column<double>(type: "float", nullable: false),
                    MerchandiseDiscuss = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandises", x => x.MerchandiseCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchandises");
        }
    }
}
