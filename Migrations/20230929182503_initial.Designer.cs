﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShephardsPies.Data;

#nullable disable

namespace shephards_pies.Migrations
{
    [DbContext(typeof(ShephardsPiesDbContext))]
    [Migration("20230929182503_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            ConcurrencyStamp = "964d9b9d-0a7e-4c2f-9f82-c4b0eab04992",
                            Name = "Admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0843ef9f-75a3-4eec-98b5-a3989b6d5636",
                            Email = "admina@strator.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEB8bw/0JRZGIi2MEFMkDSownsj6aMzoLqgbs7LSyYN4Q8DGY+uzZraPhsS1LvYFmBQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a969798a-6e70-44bd-af82-63c188938565",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "0dfba183-52c7-4e19-b9c9-98d81954c8aa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e284345-17bf-4941-b260-d27acfa6df05",
                            Email = "Caleb@Email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEMArHoL6Z0Tj3EsmNuuWBqwYsFxRugf9Mpd71rIXbYa4NDCjW6yXDM4EiKt0tLQ3yQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e6b5c2b-23d9-4ae3-b0ed-08ebd690f84a",
                            TwoFactorEnabled = false,
                            UserName = "Caleb"
                        },
                        new
                        {
                            Id = "e6e6e14d-15b3-4a63-9f94-9f78c49ffbb2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9dec17a-205c-4e4e-9f52-c0da9dd77b10",
                            Email = "Jackson@Email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELpQkX8TmtP8k/l7buOIzeWobrYKoCbaxkuM1rCIt19gWy2pjh3cxyJOL/b9WF509A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1035787-a949-4fc3-a031-3f51c56eb556",
                            TwoFactorEnabled = false,
                            UserName = "Jackson"
                        },
                        new
                        {
                            Id = "f754ad17-11bf-4b2e-8ca0-9c04812fcf68",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "205d89d4-337d-42dc-b993-b4a6348b4b34",
                            Email = "Courtney@Email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEBwcZ2q/lKLxW9h8v5ytMwFLK8QjlqgTLIFULV3sNLP3ydZeliUMe30i6bBoRjcCww==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d0441d23-30be-4e4c-b5b6-6cc803cc3989",
                            TwoFactorEnabled = false,
                            UserName = "Courtney"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        },
                        new
                        {
                            UserId = "0dfba183-52c7-4e19-b9c9-98d81954c8aa",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        },
                        new
                        {
                            UserId = "e6e6e14d-15b3-4a63-9f94-9f78c49ffbb2",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        },
                        new
                        {
                            UserId = "f754ad17-11bf-4b2e-8ca0-9c04812fcf68",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ShephardsPies.Models.Cheese", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cheeses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Buffalo Mozzarella"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Four Cheese"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "None"
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeliveryDriverId")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeRecieverId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimePlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("TipAmount")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryDriverId");

                    b.HasIndex("EmployeeRecieverId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeRecieverId = 1,
                            TimePlaced = new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipAmount = 15.0
                        },
                        new
                        {
                            Id = 2,
                            DeliveryDriverId = 2,
                            EmployeeRecieverId = 1,
                            TimePlaced = new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipAmount = 25.0
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CheeseId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("PizzaSizeId")
                        .HasColumnType("integer");

                    b.Property<int>("SauceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CheeseId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaSizeId");

                    b.HasIndex("SauceId");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheeseId = 1,
                            OrderId = 1,
                            PizzaSizeId = 2,
                            SauceId = 1
                        },
                        new
                        {
                            Id = 2,
                            CheeseId = 4,
                            OrderId = 1,
                            PizzaSizeId = 3,
                            SauceId = 4
                        },
                        new
                        {
                            Id = 3,
                            CheeseId = 3,
                            OrderId = 1,
                            PizzaSizeId = 1,
                            SauceId = 2
                        },
                        new
                        {
                            Id = 4,
                            CheeseId = 2,
                            OrderId = 1,
                            PizzaSizeId = 2,
                            SauceId = 2
                        },
                        new
                        {
                            Id = 5,
                            CheeseId = 2,
                            OrderId = 2,
                            PizzaSizeId = 3,
                            SauceId = 3
                        },
                        new
                        {
                            Id = 6,
                            CheeseId = 3,
                            OrderId = 2,
                            PizzaSizeId = 1,
                            SauceId = 2
                        },
                        new
                        {
                            Id = 7,
                            CheeseId = 2,
                            OrderId = 2,
                            PizzaSizeId = 2,
                            SauceId = 1
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.PizzaSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PizzaSizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 10.0,
                            Name = "small (10\")"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 12.0,
                            Name = "medium (14\")"
                        },
                        new
                        {
                            Id = 3,
                            Cost = 15.0,
                            Name = "large (18\")"
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.PizzaTopping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PizzaId")
                        .HasColumnType("integer");

                    b.Property<int>("ToppingId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaToppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PizzaId = 2,
                            ToppingId = 2
                        },
                        new
                        {
                            Id = 2,
                            PizzaId = 2,
                            ToppingId = 3
                        },
                        new
                        {
                            Id = 3,
                            PizzaId = 3,
                            ToppingId = 1
                        },
                        new
                        {
                            Id = 4,
                            PizzaId = 2,
                            ToppingId = 1
                        },
                        new
                        {
                            Id = 5,
                            PizzaId = 4,
                            ToppingId = 1
                        },
                        new
                        {
                            Id = 6,
                            PizzaId = 4,
                            ToppingId = 3
                        },
                        new
                        {
                            Id = 7,
                            PizzaId = 5,
                            ToppingId = 1
                        },
                        new
                        {
                            Id = 8,
                            PizzaId = 5,
                            ToppingId = 3
                        },
                        new
                        {
                            Id = 9,
                            PizzaId = 6,
                            ToppingId = 3
                        },
                        new
                        {
                            Id = 10,
                            PizzaId = 6,
                            ToppingId = 2
                        },
                        new
                        {
                            Id = 11,
                            PizzaId = 7,
                            ToppingId = 1
                        },
                        new
                        {
                            Id = 12,
                            PizzaId = 7,
                            ToppingId = 3
                        },
                        new
                        {
                            Id = 13,
                            PizzaId = 7,
                            ToppingId = 2
                        },
                        new
                        {
                            Id = 14,
                            PizzaId = 4,
                            ToppingId = 1
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.Sauce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sauces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marinara"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Arrabbiata"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Garlic White"
                        },
                        new
                        {
                            Id = 4,
                            Name = "None"
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "sausage"
                        },
                        new
                        {
                            Id = 2,
                            Name = "pepperoni"
                        },
                        new
                        {
                            Id = 3,
                            Name = "mushroom"
                        },
                        new
                        {
                            Id = 4,
                            Name = "onion"
                        },
                        new
                        {
                            Id = 5,
                            Name = "green pepper"
                        },
                        new
                        {
                            Id = 6,
                            Name = "black olive"
                        },
                        new
                        {
                            Id = 7,
                            Name = "basil"
                        },
                        new
                        {
                            Id = 8,
                            Name = "extra cheese"
                        });
                });

            modelBuilder.Entity("ShephardsPies.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "101 Main Street",
                            FirstName = "Admina",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            LastName = "Strator"
                        },
                        new
                        {
                            Id = 2,
                            Address = "122 Main Street",
                            FirstName = "Caleb",
                            IdentityUserId = "0dfba183-52c7-4e19-b9c9-98d81954c8aa",
                            LastName = "Sullivan"
                        },
                        new
                        {
                            Id = 3,
                            Address = "156 Main Street",
                            FirstName = "Jackson",
                            IdentityUserId = "e6e6e14d-15b3-4a63-9f94-9f78c49ffbb2",
                            LastName = "Henderson"
                        },
                        new
                        {
                            Id = 4,
                            Address = "172 Main Street",
                            FirstName = "Courtney",
                            IdentityUserId = "f754ad17-11bf-4b2e-8ca0-9c04812fcf68",
                            LastName = "Gulledge"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShephardsPies.Models.Order", b =>
                {
                    b.HasOne("ShephardsPies.Models.UserProfile", "DeliveryDriver")
                        .WithMany()
                        .HasForeignKey("DeliveryDriverId");

                    b.HasOne("ShephardsPies.Models.UserProfile", "EmployeeReciever")
                        .WithMany()
                        .HasForeignKey("EmployeeRecieverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryDriver");

                    b.Navigation("EmployeeReciever");
                });

            modelBuilder.Entity("ShephardsPies.Models.Pizza", b =>
                {
                    b.HasOne("ShephardsPies.Models.Cheese", "Cheese")
                        .WithMany()
                        .HasForeignKey("CheeseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShephardsPies.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShephardsPies.Models.PizzaSize", "PizzaSize")
                        .WithMany()
                        .HasForeignKey("PizzaSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShephardsPies.Models.Sauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cheese");

                    b.Navigation("PizzaSize");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("ShephardsPies.Models.PizzaTopping", b =>
                {
                    b.HasOne("ShephardsPies.Models.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShephardsPies.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("ShephardsPies.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("ShephardsPies.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("ShephardsPies.Models.Pizza", b =>
                {
                    b.Navigation("PizzaToppings");
                });
#pragma warning restore 612, 618
        }
    }
}
