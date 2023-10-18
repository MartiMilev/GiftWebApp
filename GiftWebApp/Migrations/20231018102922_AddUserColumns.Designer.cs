﻿// <auto-generated />
using System;
using GiftWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GiftWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231018102922_AddUserColumns")]
    partial class AddUserColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GiftApp.Data.Enteties.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Burthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "24d60149-a3f4-4ae3-a653-e490cde3d0c3",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1994, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "ca5bbea9-a053-427e-9840-c67de4723eba",
                            Email = "ivan@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Stoikov",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELlinCeNUbYkBzl4f7NnGSF3cJGOkn5m1inHpB5u/tOD046V5H7Ys8jxTWAzhvbK0g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e355380-ffa0-407d-b93c-f9bc100d6504",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "666515b9-9184-4653-8590-ea5e11bd0c94",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1990, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "b8faf67c-834e-4775-b0d5-d60adb3022b0",
                            Email = "georgi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Georgi",
                            LastName = "Minkov",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEPx60RpaO9kWq9ldk85tm9E4J3gS/gSqtcD1sOZUuHsUcfFJMglBcn4bDgnDYN68zQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a56dd310-ae37-40c1-83e4-184fdb93db3b",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "dff2d407-2f5e-468b-ad24-8791d81db63e",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1993, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "cdf8c44b-3aa2-4546-b707-c23eae3a5240",
                            Email = "misho@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Misho",
                            LastName = "Vasilev",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEAl58CsuK0hrkUNfZTPmhFd+dL9VEmEaHoAsJYT2NUdNevqDHdgnUG5FpVtocdxc2Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3acadd31-341d-461f-a76c-197896df5a2e",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3f6bd9f5-6ac5-4fca-ad82-eb3b6277753d",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "230020f7-60e4-42eb-b618-f68bf720a206",
                            Email = "dimitar@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Dimitar",
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEFqvX1MBgWk5zKg46f9Mc+T4aTTQmYAwYXkLXqHSO1eI5ZmfaHLSQp5162gMMrfWyQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cd00d23a-e888-428e-aed6-694ad184a745",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "ffc63714-e108-429a-a72d-e434e723d179",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "5d9c1dc7-0b17-400a-a834-8ed4ff27065f",
                            Email = "svetlin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Svetlin",
                            LastName = "Simeonov",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEP9UJpM4u3w7tLWdGclUQpD7JFoQnyf43V5dVt8QwzfkRU85hpNkpnEmYChJKGMjfw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5c4adea3-b7e4-43c1-9e50-01f1a539899b",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "a6503316-6f5f-4546-bbd7-32cb97979d02",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "dc11eaf0-eb67-443d-bfdf-54876d1dad8e",
                            Email = "raq@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Raq",
                            LastName = "Angelova",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEPdacl4Y3/q/7IdsWEEtY8Zdr1/E1btE4XdyTjmUmxfZq9hy8A/OB3sGdJgPGh3b3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4fb977cc-0cf1-4ffa-8625-43bd3c391464",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "4e37b35c-0628-4f47-8c58-98746af6fe9f",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "6d151c5c-2ced-4aef-82c0-2865f73c0d0b",
                            Email = "mariq@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mariq",
                            LastName = "Krusteva",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEEH/r1Xxk7V9bPjECOUsAfSHnwU2TN6t5PDZb8WnvoCG4w2I+vkSCj+LtIpUhkqpMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "825e4970-9d56-4fd3-a12d-f8ad7cf0cb8b",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "bb44ef0d-b5d8-4cc3-9a71-3d1c0d85dbfb",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1997, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "400d5135-8271-489d-9390-638fca596e6d",
                            Email = "gabriela@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Gabriela",
                            LastName = "Cvetanova",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAENBU4yskxiDtJvEyu+uB6cxaD9zPNYYJhAg3889VGYeH/gmM379P0yVpkbD1imUwMg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a8038a44-411c-4e57-b7bf-f3ccc9f1e618",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "2f9e8785-57d1-4752-8e6d-b4799dff1a2a",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "ce177fac-6cd2-4608-9d99-0d9536cf8876",
                            Email = "cvetelina@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Cvetelina",
                            LastName = "Ivanova",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEG9aRSC94GtzDcvgKMSoWG04O86nsFfj5BZKaN6h/2XePAghP7RVThN0i+YHi03w+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "952aadb2-12a9-41df-82e4-0604d02c6213",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3f9e8c74-743b-4672-a3f9-c13f572ff29f",
                            AccessFailedCount = 0,
                            Burthday = new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "9780ed60-21da-4124-bee9-79b30b0ccb4e",
                            Email = "vanesa@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Vanesa",
                            LastName = "Nikolova",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEGsYvpRtzoELdKNo5qePPwizwfSBomLpHAWvH0f3nLwPZgppAKzWmA8yzeJgLdratw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01e0e7b7-a582-4daf-8371-997707bfebfe",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("GiftApp.Data.Enteties.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gifts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Iphone 12 Pro"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Samsung Galaxy Z Flip"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Smart watch"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Vacantion"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Store voucher"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Money"
                        });
                });

            modelBuilder.Entity("GiftApp.Data.Enteties.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GiftId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VoteTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GiftApp.Data.Enteties.Vote", b =>
                {
                    b.HasOne("GiftApp.Data.Enteties.Gift", "Gift")
                        .WithMany()
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gift");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GiftApp.Data.Enteties.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GiftApp.Data.Enteties.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftApp.Data.Enteties.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GiftApp.Data.Enteties.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
