// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopsRUsRetailStore.Data.Concrete.EntityFramework.Contexts;

#nullable disable

namespace ShopsRUsRetailStore.Data.Migrations
{
    [DbContext(typeof(ShopsRUsDbContext))]
    partial class ShopsRUsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<bool>("IsPercentage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<decimal>("Rate")
                        .HasPrecision(18, 2)
                        .HasColumnType("numeric(18,2)");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IsPercentage");

                    b.HasIndex("Rate");

                    b.ToTable("Discounts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Affiliate D.",
                            IsPercentage = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 10m,
                            UserType = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Employee D.",
                            IsPercentage = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 30m,
                            UserType = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Loyal Customer D.",
                            IsPercentage = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 5m,
                            UserType = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Price D.",
                            IsPercentage = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 5m,
                            UserType = 0
                        });
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("numeric(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Invoices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 28, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "INV202022000026801",
                            OrderId = 1,
                            TotalPrice = 100m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 28, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "INV202022000026802",
                            OrderId = 2,
                            TotalPrice = 200m
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 7, 28, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "INV202022000026803",
                            OrderId = 3,
                            TotalPrice = 300m
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 7, 28, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "INV202022000026804",
                            OrderId = 4,
                            TotalPrice = 400m
                        });
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.InvoiceDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("ProductId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceDetails", (string)null);
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 28, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "RAM202022000026801",
                            TotalPrice = 400m,
                            UserId = "f575f-a333-4d94-81f1-ad27652a1461"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 28, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "RAM202022000026802",
                            TotalPrice = 800m,
                            UserId = "f575f-a333-4d94-81f1-ad27652a1462"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 7, 28, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "RAM202022000026803",
                            TotalPrice = 1200m,
                            UserId = "f575f-a333-4d94-81f1-ad27652a1463"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 7, 28, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2022, 7, 28, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "RAM202022000026804",
                            TotalPrice = 1600m,
                            UserId = "f575f-a333-4d94-81f1-ad27652a1464"
                        });
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

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
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

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

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

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
                            Id = "f575f-a333-4d94-81f1-ad27652a1461",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                            CreatedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ramazann1@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ramazan 1",
                            LastName = "Gunes 1",
                            LockoutEnabled = false,
                            NormalizedEmail = "RAMAZANN1@GMAİL.COM",
                            NormalizedUserName = "RAMAZAN1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                            TwoFactorEnabled = false,
                            Type = 0,
                            UserName = "ramazan1"
                        },
                        new
                        {
                            Id = "f575f-a333-4d94-81f1-ad27652a1462",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                            CreatedDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ramazann2@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ramazan 2",
                            LastName = "Gunes 2",
                            LockoutEnabled = false,
                            NormalizedEmail = "RAMAZANN2@GMAİL.COM",
                            NormalizedUserName = "RAMAZAN2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                            TwoFactorEnabled = false,
                            Type = 1,
                            UserName = "ramazan2"
                        },
                        new
                        {
                            Id = "f575f-a333-4d94-81f1-ad27652a1463",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                            CreatedDate = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ramazann3@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ramazan 3",
                            LastName = "Gunes 3",
                            LockoutEnabled = false,
                            NormalizedEmail = "RAMAZANN3@GMAİL.COM",
                            NormalizedUserName = "RAMAZAN3",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                            TwoFactorEnabled = false,
                            Type = 2,
                            UserName = "ramazan3"
                        },
                        new
                        {
                            Id = "f575f-a333-4d94-81f1-ad27652a1464",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                            CreatedDate = new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ramazann4@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ramazan 4",
                            LastName = "Gunes 4",
                            LockoutEnabled = false,
                            NormalizedEmail = "RAMAZANN4@GMAİL.COM",
                            NormalizedUserName = "RAMAZAN4",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                            TwoFactorEnabled = false,
                            Type = 3,
                            UserName = "ramazan4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Invoice", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.InvoiceDetail", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.Invoice", "Invoice")
                        .WithMany("Details")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Order", b =>
                {
                    b.HasOne("ShopsRUsRetailStore.Entities.Concrete.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Invoice", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.Order", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("ShopsRUsRetailStore.Entities.Concrete.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
