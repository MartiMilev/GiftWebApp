using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftWebApp.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Burthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftId = table.Column<int>(type: "int", nullable: false),
                    VoteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_Gifts_GiftId",
                        column: x => x.GiftId,
                        principalTable: "Gifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Burthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01a7baa9-c505-4ee9-81e1-7a742a64bc84", 0, new DateTime(1997, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8c45612-c23c-4961-8b81-358350e57a0e", "gabriela@gmail.com", false, "Gabriela", "Cvetanova", false, null, null, null, "AQAAAAEAACcQAAAAEPUvju6Hgdwl4o1Nj2L8YD5gn+GavD6JfHaENpPwshPpVs7fvG+80gEOXcMNKpTsuQ==", null, false, "78aed749-7b20-4299-b24a-a13b943dc751", false, null },
                    { "02b935ad-6a7e-452b-aea3-1146f0a4e42d", 0, new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "14c1214b-b6e0-4822-9dc0-93e8f9bff2ba", "raq@gmail.com", false, "Raq", "Angelova", false, null, null, null, "AQAAAAEAACcQAAAAEK/CVQjl/gBNThnffTS++znBsb9K+kgI5PEDHxxME6MHNXClzrvCgROt9MQNPkI2tQ==", null, false, "de18973c-3f1c-4eec-bbb6-8e225b581a68", false, null },
                    { "0c0f1447-b639-4707-bb31-88ca4e199531", 0, new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a9ad5b7-2485-45cb-ab9c-d8be562ba5dc", "mariq@gmail.com", false, "Mariq", "Krusteva", false, null, null, null, "AQAAAAEAACcQAAAAEKwvn3dmJV5S3s7KTvN0IaOIoPM3rip/tvtqn2fVxzdfMYm82UGXH9W1az2qffv1mA==", null, false, "53d41055-d4c1-42d4-a7d9-72ed4d206f5a", false, null },
                    { "332260b9-e3cd-477a-9718-8dce9cb0dbc8", 0, new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "7999a1f5-a07a-42ac-9c2f-c069eca83e46", "cvetelina@gmail.com", false, "Cvetelina", "Ivanova", false, null, null, null, "AQAAAAEAACcQAAAAEPVvCIlHyQ/iDJDZDapNuhrgEb1EMMi7SOw8eAbE7pgK6kGHhmFPMvTEVO9kDow8OA==", null, false, "6704d1e8-81b9-437d-a6e0-f2c32baafac3", false, null },
                    { "6d97f4b3-1915-4752-b475-042686c4e28a", 0, new DateTime(1990, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "a8c39b18-6ac7-4781-9447-f831bc21a2e9", "georgi@gmail.com", false, "Georgi", "Minkov", false, null, null, null, "AQAAAAEAACcQAAAAEMeSWr7rEBIXbS+wSgqLCljJCx4fRHpUQegNUdvGUz+FeZw/EqWlYd+jGEcjMpYe2g==", null, false, "26bd1d0a-d297-4174-8a40-4dec3479fd7e", false, null },
                    { "7002e358-3fb4-4851-bc70-a436be01207a", 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "650e929b-6749-40f5-97d6-de6e4be1733d", "svetlin@gmail.com", false, "Svetlin", "Simeonov", false, null, null, null, "AQAAAAEAACcQAAAAECWdBGB37Rl9JNXUY2oddCGiE/uzPm8bMNd4q3G7vQtoqm4hNTIKu75B6QRk1+vWPQ==", null, false, "bffe452f-513a-43c0-b668-b002f265188a", false, null },
                    { "8b0441e0-6d0f-472f-8153-4d8e26a468d5", 0, new DateTime(1993, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "b07482ad-7c66-4541-866c-e163493ed9c4", "misho@gmail.com", false, "Misho", "Vasilev", false, null, null, null, "AQAAAAEAACcQAAAAEPEzWwVO8f2QN8FWzgSJQEEC/TDANwbnxRz1SqjkvLybaBJaqGntFo3ctOAkisIySg==", null, false, "21b9cf77-14a8-4cb9-9138-0f0484ce4b0a", false, null },
                    { "8fe09159-d62f-4242-95ad-f0cf00f2b0b3", 0, new DateTime(1994, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "524a361d-b46c-49bf-b356-e0f96aab8f65", "ivan@gmail.com", false, "Ivan", "Stoikov", false, null, null, null, "AQAAAAEAACcQAAAAEGpo3mjrnohXDqx5VfQkbRS10a5exrHc3PPvHMRDKq7JJPVYa64cJDre5xHcCR25FQ==", null, false, "ef2e5757-0d76-4274-b1c0-7554fd4263f5", false, null },
                    { "d778478e-8be8-49df-a4a5-c18b4767e54f", 0, new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "456b650a-9f9a-4b1a-9707-8514c9988fe2", "vanesa@gmail.com", false, "Vanesa", "Nikolova", false, null, null, null, "AQAAAAEAACcQAAAAEE4/ERWqZDi6TQsPn9CWn95u3HvNCdfl8rqT+fjaUJEMIqvszUBhG75+XIgqhJHnTw==", null, false, "0921741d-e0fc-4296-a928-9af25584fdbf", false, null },
                    { "dd6d129e-81d2-48fc-905b-1aa6b843738b", 0, new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3bc5be28-ca35-40f9-ac01-6da2c4c1e535", "dimitar@gmail.com", false, "Dimitar", "Georgiev", false, null, null, null, "AQAAAAEAACcQAAAAEER7JMD4Qa52hiJvOEBzPrFnFnTX+T3d9Unis2Aj+a1p8H2GTpUiZdSM86Y0jeOvDQ==", null, false, "e6138753-c7ed-4f53-8952-d59e535dee62", false, null }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Iphone 12 Pro" },
                    { 2, "Samsung Galaxy Z Flip" },
                    { 3, "Smart watch" },
                    { 4, "Vacantion" },
                    { 5, "Store voucher" },
                    { 6, "Money" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_GiftId",
                table: "Votes",
                column: "GiftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Gifts");
        }
    }
}
