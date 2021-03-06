// <auto-generated />
using FoodOrderingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodOrderingSystem.Migrations
{
    [DbContext(typeof(FoodOrderingDBContext))]
    [Migration("20211013110829_FoodOrderingSystem.Models.FoodOrderingDBContext")]
    partial class FoodOrderingSystemModelsFoodOrderingDBContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodOrderingSystem.Models.Menu", b =>
                {
                    b.Property<long>("MenuIdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<long>("RestaurantID")
                        .HasColumnType("bigint");

                    b.HasKey("MenuIdID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Restaurant", b =>
                {
                    b.Property<long>("RestaurantID")
                        .HasColumnType("bigint");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<long>("RestaurantID")
                        .HasColumnType("bigint");

                    b.HasKey("ReviewId");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Table", b =>
                {
                    b.Property<int>("TableID")
                        .HasColumnType("int");

                    b.Property<long>("RestaurantID")
                        .HasColumnType("bigint");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<bool>("TableStatus")
                        .HasColumnType("bit");

                    b.HasKey("TableID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.User", b =>
                {
                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

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
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Table", b =>
                {
                    b.HasOne("FoodOrderingSystem.Models.Restaurant", null)
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodOrderingSystem.Models.Restaurant", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("Reviews");

                    b.Navigation("Tables");
                });
#pragma warning restore 612, 618
        }
    }
}
