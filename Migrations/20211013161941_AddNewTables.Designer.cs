﻿// <auto-generated />
using FoodOrderingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodOrderingSystem.Migrations
{
    [DbContext(typeof(FoodOrderingDBContext))]
    [Migration("20211013161941_AddNewTables")]
    partial class AddNewTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodOrderingSystem.Models.Booking", b =>
                {
                    b.Property<long>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BookingStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("CancellationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookingID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Menu", b =>
                {
                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("MenuName", "RestaurantID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Restaurant", b =>
                {
                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OverallRating")
                        .HasColumnType("float");

                    b.Property<bool>("PureVeg")
                        .HasColumnType("bit");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantID = "Rest101",
                            Address = "Near Mukai Chauk, Ravet",
                            Name = "Krishna Pure Veg",
                            OverallRating = 4.7000000000000002,
                            PureVeg = true
                        },
                        new
                        {
                            RestaurantID = "Rest102",
                            Address = "Phase 1, Hinjewadi",
                            Name = "Mezza9",
                            OverallRating = 4.5,
                            PureVeg = false
                        });
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Review", b =>
                {
                    b.Property<long>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("RestaurantID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReviewId");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Table", b =>
                {
                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<long>("RestaurantID")
                        .HasColumnType("bigint");

                    b.Property<string>("RestaurantID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("TableStatus")
                        .HasColumnType("bit");

                    b.HasKey("TableNumber", "RestaurantID");

                    b.HasIndex("RestaurantID1");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = "sunildalvi",
                            Email = "sunil123@gmail.com",
                            FirstName = "Sunil",
                            LastName = "Dalvi",
                            PhoneNumber = "7588064645"
                        },
                        new
                        {
                            UserID = "sandippatil",
                            Email = "sandip123@gmail.com",
                            FirstName = "Sandip",
                            LastName = "Patil",
                            PhoneNumber = "9049276187"
                        });
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Booking", b =>
                {
                    b.HasOne("FoodOrderingSystem.Models.Restaurant", null)
                        .WithMany("Bookings")
                        .HasForeignKey("RestaurantID");

                    b.HasOne("FoodOrderingSystem.Models.User", null)
                        .WithMany("Bookings")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Menu", b =>
                {
                    b.HasOne("FoodOrderingSystem.Models.Restaurant", null)
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Review", b =>
                {
                    b.HasOne("FoodOrderingSystem.Models.Restaurant", null)
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodOrderingSystem.Models.User", null)
                        .WithMany("Reviews")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Table", b =>
                {
                    b.HasOne("FoodOrderingSystem.Models.Restaurant", null)
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantID1");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Restaurant", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Menus");

                    b.Navigation("Reviews");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
