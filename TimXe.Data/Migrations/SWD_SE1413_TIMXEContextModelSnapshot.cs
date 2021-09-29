﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimXe.Data.Context;

namespace TimXe.Data.Migrations
{
    [DbContext(typeof(SWD_SE1413_TIMXEContext))]
    partial class SWD_SE1413_TIMXEContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimXe.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PassWord")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Booking", b =>
                {
                    b.Property<int>("IdOwner")
                        .HasColumnType("int");

                    b.Property<int>("IdTrip")
                        .HasColumnType("int");

                    b.Property<int?>("IdDriver")
                        .HasColumnType("int");

                    b.HasKey("IdOwner", "IdTrip");

                    b.HasIndex("IdDriver");

                    b.HasIndex("IdTrip");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdChannelType")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdChannelType");

                    b.HasIndex("IdGroup");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("TimXe.Data.Entities.ChannelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ChannelType");
                });

            modelBuilder.Entity("TimXe.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DriverPhone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<int?>("IdOwner")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdOwner");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("IdAcount")
                        .HasColumnType("int");

                    b.Property<int?>("IdCity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdAcount");

                    b.HasIndex("IdCity");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Coordinates")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("IdTrip")
                        .HasColumnType("int");

                    b.Property<string>("LatLon")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PointTypeValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTrip");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TimXe.Data.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("News");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IdAcount")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdVehicleType")
                        .HasColumnType("int");

                    b.Property<double?>("Price1")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.HasIndex("IdVehicleType");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("TimXe.Data.Entities.PriceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FromKm")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdPrice")
                        .HasColumnType("int");

                    b.Property<string>("Tokm")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPrice");

                    b.ToTable("PriceItem");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdAcount")
                        .HasColumnType("int");

                    b.Property<int?>("IdChannel")
                        .HasColumnType("int");

                    b.Property<int?>("IdVehicle")
                        .HasColumnType("int");

                    b.Property<string>("NameCustomer")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneCustomer")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<double?>("PriceBooking")
                        .HasColumnType("float");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdAcount");

                    b.HasIndex("IdChannel");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdOwner")
                        .HasColumnType("int");

                    b.Property<int?>("IdVehicleType")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdOwner");

                    b.HasIndex("IdVehicleType");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("TimXe.Data.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdAcount")
                        .HasColumnType("int");

                    b.Property<int?>("IdTrip")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IdAcount");

                    b.HasIndex("IdTrip");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Account", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Acount_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Booking", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Driver", "IdDriverNavigation")
                        .WithMany("Bookings")
                        .HasForeignKey("IdDriver")
                        .HasConstraintName("FK_Booking_Driver");

                    b.HasOne("TimXe.Data.Entities.Owner", "IdOwnerNavigation")
                        .WithMany("Bookings")
                        .HasForeignKey("IdOwner")
                        .HasConstraintName("FK_Booking_Owner")
                        .IsRequired();

                    b.HasOne("TimXe.Data.Entities.Trip", "IdTripNavigation")
                        .WithMany("Bookings")
                        .HasForeignKey("IdTrip")
                        .HasConstraintName("FK_Booking_Trip")
                        .IsRequired();

                    b.Navigation("IdDriverNavigation");

                    b.Navigation("IdOwnerNavigation");

                    b.Navigation("IdTripNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Channel", b =>
                {
                    b.HasOne("TimXe.Data.Entities.ChannelType", "IdChannelTypeNavigation")
                        .WithMany("Channels")
                        .HasForeignKey("IdChannelType")
                        .HasConstraintName("FK_Channel_ChannelType");

                    b.HasOne("TimXe.Data.Entities.Group", "IdGroupNavigation")
                        .WithMany("Channels")
                        .HasForeignKey("IdGroup")
                        .HasConstraintName("FK_Channel_Group");

                    b.Navigation("IdChannelTypeNavigation");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Driver", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Owner", "IdOwnerNavigation")
                        .WithMany("Drivers")
                        .HasForeignKey("IdOwner")
                        .HasConstraintName("FK_Driver_Owner");

                    b.Navigation("IdOwnerNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Group", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Account", "IdAcountNavigation")
                        .WithMany("Groups")
                        .HasForeignKey("IdAcount")
                        .HasConstraintName("FK_Group_Acount");

                    b.HasOne("TimXe.Data.Entities.City", "IdCityNavigation")
                        .WithMany("Groups")
                        .HasForeignKey("IdCity")
                        .HasConstraintName("FK_Group_City");

                    b.Navigation("IdAcountNavigation");

                    b.Navigation("IdCityNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Location", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Trip", "IdTripNavigation")
                        .WithMany("Locations")
                        .HasForeignKey("IdTrip")
                        .HasConstraintName("FK_Point_Trip");

                    b.Navigation("IdTripNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.News", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Group", "IdGroupNavigation")
                        .WithMany("News")
                        .HasForeignKey("IdGroup")
                        .HasConstraintName("FK_News_Group");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Owner", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Group", "IdGroupNavigation")
                        .WithMany("Owners")
                        .HasForeignKey("IdGroup")
                        .HasConstraintName("FK_Owner_Group");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Price", b =>
                {
                    b.HasOne("TimXe.Data.Entities.VehicleType", "IdVehicleTypeNavigation")
                        .WithMany("Prices")
                        .HasForeignKey("IdVehicleType")
                        .HasConstraintName("FK_Price_VehicleType");

                    b.Navigation("IdVehicleTypeNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.PriceItem", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Price", "IdPriceNavigation")
                        .WithMany("PriceItems")
                        .HasForeignKey("IdPrice")
                        .HasConstraintName("FK_PriceItem_Price");

                    b.Navigation("IdPriceNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Trip", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Account", "IdAcountNavigation")
                        .WithMany("Trips")
                        .HasForeignKey("IdAcount")
                        .HasConstraintName("FK_Trip_Acount");

                    b.HasOne("TimXe.Data.Entities.Channel", "IdChannelNavigation")
                        .WithMany("Trips")
                        .HasForeignKey("IdChannel")
                        .HasConstraintName("FK_Trip_Channel");

                    b.Navigation("IdAcountNavigation");

                    b.Navigation("IdChannelNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Vehicle", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Owner", "IdOwnerNavigation")
                        .WithMany("Vehicles")
                        .HasForeignKey("IdOwner")
                        .HasConstraintName("FK_Vehicle_Owner");

                    b.HasOne("TimXe.Data.Entities.VehicleType", "IdVehicleTypeNavigation")
                        .WithMany("Vehicles")
                        .HasForeignKey("IdVehicleType")
                        .HasConstraintName("FK_Vehicle_VehicleType");

                    b.Navigation("IdOwnerNavigation");

                    b.Navigation("IdVehicleTypeNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.VehicleType", b =>
                {
                    b.HasOne("TimXe.Data.Entities.Account", "IdAcountNavigation")
                        .WithMany("VehicleTypes")
                        .HasForeignKey("IdAcount")
                        .HasConstraintName("FK_VehicleType_Acount");

                    b.HasOne("TimXe.Data.Entities.Trip", "IdTripNavigation")
                        .WithMany("VehicleTypes")
                        .HasForeignKey("IdTrip")
                        .HasConstraintName("FK_VehicleType_Trip");

                    b.Navigation("IdAcountNavigation");

                    b.Navigation("IdTripNavigation");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Account", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Trips");

                    b.Navigation("VehicleTypes");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Channel", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("TimXe.Data.Entities.ChannelType", b =>
                {
                    b.Navigation("Channels");
                });

            modelBuilder.Entity("TimXe.Data.Entities.City", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Driver", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Group", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("News");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Owner", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Drivers");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Price", b =>
                {
                    b.Navigation("PriceItems");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("TimXe.Data.Entities.Trip", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Locations");

                    b.Navigation("VehicleTypes");
                });

            modelBuilder.Entity("TimXe.Data.Entities.VehicleType", b =>
                {
                    b.Navigation("Prices");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
