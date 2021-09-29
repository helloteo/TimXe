using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TimXe.Data.Entities;

#nullable disable

namespace TimXe.Data.Context
{
    public partial class SWD_SE1413_TIMXEContext : DbContext
    {
        public SWD_SE1413_TIMXEContext()
        {
        }

        public SWD_SE1413_TIMXEContext(DbContextOptions<SWD_SE1413_TIMXEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<ChannelType> ChannelTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<PriceItem> PriceItems { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ADMIN\\SQLEXPRESS;Database=SWD_SE1413_TIMXE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Acount_Role");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => new { e.IdOwner, e.IdTrip });

                entity.ToTable("Booking");

                entity.HasOne(d => d.IdDriverNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.IdDriver)
                    .HasConstraintName("FK_Booking_Driver");

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.IdOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Owner");

                entity.HasOne(d => d.IdTripNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.IdTrip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Trip");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdChannelTypeNavigation)
                    .WithMany(p => p.Channels)
                    .HasForeignKey(d => d.IdChannelType)
                    .HasConstraintName("FK_Channel_ChannelType");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Channels)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK_Channel_Group");
            });

            modelBuilder.Entity<ChannelType>(entity =>
            {
                entity.ToTable("ChannelType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("Driver");

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.DriverPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.IdOwner)
                    .HasConstraintName("FK_Driver_Owner");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdAcountNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.IdAcount)
                    .HasConstraintName("FK_Group_Acount");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.IdCity)
                    .HasConstraintName("FK_Group_City");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Coordinates)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LatLon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTripNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.IdTrip)
                    .HasConstraintName("FK_Point_Trip");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK_News_Group");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Owners)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK_Owner_Group");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Price");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Price1).HasColumnName("Price");

                entity.HasOne(d => d.IdVehicleTypeNavigation)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.IdVehicleType)
                    .HasConstraintName("FK_Price_VehicleType");
            });

            modelBuilder.Entity<PriceItem>(entity =>
            {
                entity.ToTable("PriceItem");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FromKm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tokm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPriceNavigation)
                    .WithMany(p => p.PriceItems)
                    .HasForeignKey(d => d.IdPrice)
                    .HasConstraintName("FK_PriceItem_Price");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.ToTable("Trip");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.NameCustomer).HasMaxLength(50);

                entity.Property(e => e.PhoneCustomer)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAcountNavigation)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.IdAcount)
                    .HasConstraintName("FK_Trip_Acount");

                entity.HasOne(d => d.IdChannelNavigation)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.IdChannel)
                    .HasConstraintName("FK_Trip_Channel");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.IdOwner)
                    .HasConstraintName("FK_Vehicle_Owner");

                entity.HasOne(d => d.IdVehicleTypeNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.IdVehicleType)
                    .HasConstraintName("FK_Vehicle_VehicleType");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.HasOne(d => d.IdAcountNavigation)
                    .WithMany(p => p.VehicleTypes)
                    .HasForeignKey(d => d.IdAcount)
                    .HasConstraintName("FK_VehicleType_Acount");

                entity.HasOne(d => d.IdTripNavigation)
                    .WithMany(p => p.VehicleTypes)
                    .HasForeignKey(d => d.IdTrip)
                    .HasConstraintName("FK_VehicleType_Trip");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
