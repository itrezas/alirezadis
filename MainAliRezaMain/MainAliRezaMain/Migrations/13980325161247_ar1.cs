﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MainAliRezaMain.Migrations
{
    public partial class ar1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person1",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday_Day = table.Column<string>(nullable: true),
                    Birthday_Month = table.Column<string>(nullable: true),
                    Birthday_Year = table.Column<string>(nullable: true),
                    E_Mail = table.Column<string>(nullable: true),
                    Mobil = table.Column<string>(nullable: true),
                    Telephon = table.Column<string>(nullable: true),
                    Sath_E_Dastresy = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "product1",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Mojody_Anbar = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "productGEs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    General_Explanation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productGEs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "saveShoppingCartToDBs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonID = table.Column<string>(nullable: true),
                    PersonName = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<string>(nullable: true),
                    PersonUser = table.Column<string>(nullable: true),
                    PersonPass = table.Column<string>(nullable: true),
                    PayingByWhichBank = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saveShoppingCartToDBs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "person1");

            migrationBuilder.DropTable(
                name: "product1");

            migrationBuilder.DropTable(
                name: "productGEs");

            migrationBuilder.DropTable(
                name: "saveShoppingCartToDBs");
        }
    }
}
