using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiftWebApp.Migrations
{
    public partial class AddUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01a7baa9-c505-4ee9-81e1-7a742a64bc84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02b935ad-6a7e-452b-aea3-1146f0a4e42d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c0f1447-b639-4707-bb31-88ca4e199531");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "332260b9-e3cd-477a-9718-8dce9cb0dbc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d97f4b3-1915-4752-b475-042686c4e28a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7002e358-3fb4-4851-bc70-a436be01207a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b0441e0-6d0f-472f-8153-4d8e26a468d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fe09159-d62f-4242-95ad-f0cf00f2b0b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d778478e-8be8-49df-a4a5-c18b4767e54f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd6d129e-81d2-48fc-905b-1aa6b843738b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Burthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24d60149-a3f4-4ae3-a653-e490cde3d0c3", 0, new DateTime(1994, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ca5bbea9-a053-427e-9840-c67de4723eba", "ivan@gmail.com", false, "Ivan", "Stoikov", false, null, null, null, "AQAAAAEAACcQAAAAELlinCeNUbYkBzl4f7NnGSF3cJGOkn5m1inHpB5u/tOD046V5H7Ys8jxTWAzhvbK0g==", null, false, "2e355380-ffa0-407d-b93c-f9bc100d6504", false, null },
                    { "2f9e8785-57d1-4752-8e6d-b4799dff1a2a", 0, new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce177fac-6cd2-4608-9d99-0d9536cf8876", "cvetelina@gmail.com", false, "Cvetelina", "Ivanova", false, null, null, null, "AQAAAAEAACcQAAAAEG9aRSC94GtzDcvgKMSoWG04O86nsFfj5BZKaN6h/2XePAghP7RVThN0i+YHi03w+w==", null, false, "952aadb2-12a9-41df-82e4-0604d02c6213", false, null },
                    { "3f6bd9f5-6ac5-4fca-ad82-eb3b6277753d", 0, new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "230020f7-60e4-42eb-b618-f68bf720a206", "dimitar@gmail.com", false, "Dimitar", "Georgiev", false, null, null, null, "AQAAAAEAACcQAAAAEFqvX1MBgWk5zKg46f9Mc+T4aTTQmYAwYXkLXqHSO1eI5ZmfaHLSQp5162gMMrfWyQ==", null, false, "cd00d23a-e888-428e-aed6-694ad184a745", false, null },
                    { "3f9e8c74-743b-4672-a3f9-c13f572ff29f", 0, new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "9780ed60-21da-4124-bee9-79b30b0ccb4e", "vanesa@gmail.com", false, "Vanesa", "Nikolova", false, null, null, null, "AQAAAAEAACcQAAAAEGsYvpRtzoELdKNo5qePPwizwfSBomLpHAWvH0f3nLwPZgppAKzWmA8yzeJgLdratw==", null, false, "01e0e7b7-a582-4daf-8371-997707bfebfe", false, null },
                    { "4e37b35c-0628-4f47-8c58-98746af6fe9f", 0, new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d151c5c-2ced-4aef-82c0-2865f73c0d0b", "mariq@gmail.com", false, "Mariq", "Krusteva", false, null, null, null, "AQAAAAEAACcQAAAAEEH/r1Xxk7V9bPjECOUsAfSHnwU2TN6t5PDZb8WnvoCG4w2I+vkSCj+LtIpUhkqpMw==", null, false, "825e4970-9d56-4fd3-a12d-f8ad7cf0cb8b", false, null },
                    { "666515b9-9184-4653-8590-ea5e11bd0c94", 0, new DateTime(1990, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "b8faf67c-834e-4775-b0d5-d60adb3022b0", "georgi@gmail.com", false, "Georgi", "Minkov", false, null, null, null, "AQAAAAEAACcQAAAAEPx60RpaO9kWq9ldk85tm9E4J3gS/gSqtcD1sOZUuHsUcfFJMglBcn4bDgnDYN68zQ==", null, false, "a56dd310-ae37-40c1-83e4-184fdb93db3b", false, null },
                    { "a6503316-6f5f-4546-bbd7-32cb97979d02", 0, new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc11eaf0-eb67-443d-bfdf-54876d1dad8e", "raq@gmail.com", false, "Raq", "Angelova", false, null, null, null, "AQAAAAEAACcQAAAAEPdacl4Y3/q/7IdsWEEtY8Zdr1/E1btE4XdyTjmUmxfZq9hy8A/OB3sGdJgPGh3b3g==", null, false, "4fb977cc-0cf1-4ffa-8625-43bd3c391464", false, null },
                    { "bb44ef0d-b5d8-4cc3-9a71-3d1c0d85dbfb", 0, new DateTime(1997, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "400d5135-8271-489d-9390-638fca596e6d", "gabriela@gmail.com", false, "Gabriela", "Cvetanova", false, null, null, null, "AQAAAAEAACcQAAAAENBU4yskxiDtJvEyu+uB6cxaD9zPNYYJhAg3889VGYeH/gmM379P0yVpkbD1imUwMg==", null, false, "a8038a44-411c-4e57-b7bf-f3ccc9f1e618", false, null },
                    { "dff2d407-2f5e-468b-ad24-8791d81db63e", 0, new DateTime(1993, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdf8c44b-3aa2-4546-b707-c23eae3a5240", "misho@gmail.com", false, "Misho", "Vasilev", false, null, null, null, "AQAAAAEAACcQAAAAEAl58CsuK0hrkUNfZTPmhFd+dL9VEmEaHoAsJYT2NUdNevqDHdgnUG5FpVtocdxc2Q==", null, false, "3acadd31-341d-461f-a76c-197896df5a2e", false, null },
                    { "ffc63714-e108-429a-a72d-e434e723d179", 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5d9c1dc7-0b17-400a-a834-8ed4ff27065f", "svetlin@gmail.com", false, "Svetlin", "Simeonov", false, null, null, null, "AQAAAAEAACcQAAAAEP9UJpM4u3w7tLWdGclUQpD7JFoQnyf43V5dVt8QwzfkRU85hpNkpnEmYChJKGMjfw==", null, false, "5c4adea3-b7e4-43c1-9e50-01f1a539899b", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d60149-a3f4-4ae3-a653-e490cde3d0c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f9e8785-57d1-4752-8e6d-b4799dff1a2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f6bd9f5-6ac5-4fca-ad82-eb3b6277753d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9e8c74-743b-4672-a3f9-c13f572ff29f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e37b35c-0628-4f47-8c58-98746af6fe9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666515b9-9184-4653-8590-ea5e11bd0c94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6503316-6f5f-4546-bbd7-32cb97979d02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb44ef0d-b5d8-4cc3-9a71-3d1c0d85dbfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dff2d407-2f5e-468b-ad24-8791d81db63e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffc63714-e108-429a-a72d-e434e723d179");

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
        }
    }
}
