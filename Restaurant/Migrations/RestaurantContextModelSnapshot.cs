// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.Models;

#nullable disable

namespace Restaurant.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Restaurant.Models.MenuItem", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ReservationReserveId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("ReservationReserveId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Restaurant.Models.Reservation", b =>
                {
                    b.Property<int>("ReserveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReserveId"), 1L, 1);

                    b.Property<string>("ReserveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReserveName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReserveId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Restaurant.Models.MenuItem", b =>
                {
                    b.HasOne("Restaurant.Models.Reservation", null)
                        .WithMany("menuItems")
                        .HasForeignKey("ReservationReserveId");
                });

            modelBuilder.Entity("Restaurant.Models.Reservation", b =>
                {
                    b.Navigation("menuItems");
                });
#pragma warning restore 612, 618
        }
    }
}
