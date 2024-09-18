﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taxi24.Infra.Data;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230404125538_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Taxi24.Core.Entity.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CarCheck")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CarCollor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CarDelegation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("CarYear")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<string>("Licence")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Favirote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<string>("PlaceId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Favirote");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<string>("PlaceId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SecondaryText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("ApplicationPrice")
                        .HasColumnType("double");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<double>("DriverPrice")
                        .HasColumnType("double");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<int?>("PromoCodeId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("PromoCodeId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.OrderPaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("OrderPaymentMethod");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cash"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Credit"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wallet"
                        });
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lng")
                        .HasColumnType("double");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.PromoCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("PriceType")
                        .HasColumnType("int");

                    b.Property<int>("PromoCodeStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("PromoCode");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Driver"
                        });
                });

            modelBuilder.Entity("Taxi24.Core.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CreationUser")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModificationUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Driver", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithOne()
                        .HasForeignKey("Taxi24.Core.Entity.Driver", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Favirote", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithMany("Favirotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Location", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Order", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.Driver", "Driver")
                        .WithMany("Orders")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Taxi24.Core.Entity.PromoCode", "PromoCode")
                        .WithOne("Order")
                        .HasForeignKey("Taxi24.Core.Entity.Order", "PromoCodeId");

                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("PromoCode");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.OrderPaymentMethod", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.Order", "Order")
                        .WithMany("OrderPaymentMethods")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Taxi24.Core.Entity.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Point", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.Order", "Order")
                        .WithMany("Points")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.PromoCode", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithMany("PromoCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.UserRole", b =>
                {
                    b.HasOne("Taxi24.Core.Entity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Taxi24.Core.Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Driver", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.Order", b =>
                {
                    b.Navigation("OrderPaymentMethods");

                    b.Navigation("Points");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.PromoCode", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Taxi24.Core.Entity.User", b =>
                {
                    b.Navigation("Favirotes");

                    b.Navigation("Locations");

                    b.Navigation("Orders");

                    b.Navigation("PromoCodes");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
