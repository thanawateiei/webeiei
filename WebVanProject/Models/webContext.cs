using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebVanProject.Models
{
    public partial class webContext : DbContext
    {
        public webContext()
        {
        }

        public webContext(DbContextOptions<webContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<Details1> Details1s { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<Route> Routes { get; set; } = null!;
        public virtual DbSet<Station> Stations { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-8FFPN76C\\SQLEXPRESS;Initial Catalog=web;Persist Security Info=True;User ID=webdev;Password=1234");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Thai_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.IdCar)
                    .HasName("PK__Car__D54686DC2D198884");

                entity.ToTable("Car");

                entity.Property(e => e.IdCar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_car")
                    .UseCollation("Thai_100_CS_AI");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("car_number")
                    .UseCollation("Thai_100_CS_AI");

                entity.Property(e => e.TypeCar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_car")
                    .UseCollation("Thai_100_CS_AI");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdCar)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_car");

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_province");

                entity.Property(e => e.OriginStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_station");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.TerminalProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("terminal_province");

                entity.Property(e => e.TerminalStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("terminal_station");

                entity.Property(e => e.Time)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.Property(e => e.TravelDate)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("travel_date");
            });

            modelBuilder.Entity<Details1>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK__Details__38E9A224DCD786FE");

                entity.ToTable("Details1");

                entity.Property(e => e.DetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("detail_id");

                entity.Property(e => e.Destination)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("destination")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DestinationProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("destination_province")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("end_time")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fare).HasColumnName("fare");

                entity.Property(e => e.OriginDistrict)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_district")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_province")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("phone_number")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PickupDetail)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("pickup_detail")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("queue_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Route)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("route")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("start_time")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictId)
                    .ValueGeneratedNever()
                    .HasColumnName("district_id");

                entity.Property(e => e.District1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("district")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("location_id");

                entity.Property(e => e.DetailId).HasColumnName("detail_id");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Details");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("PK__Payment__862FEFE0E4EF2B62");

                entity.ToTable("Payment");

                entity.Property(e => e.IdPayment)
                    .ValueGeneratedNever()
                    .HasColumnName("id_payment");

                entity.Property(e => e.Payment1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("payment");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.IdProvince)
                    .HasName("PK__Province__E068312CA9DCFF85");

                entity.Property(e => e.IdProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_province");

                entity.Property(e => e.Province1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("province");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.RouteId)
                    .ValueGeneratedNever()
                    .HasColumnName("route_id");

                entity.Property(e => e.DestinationProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("destination_province")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DetailId).HasColumnName("detail_id");

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_province")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point10)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_10")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point11)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_11")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point12)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_12")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point13)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_13")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point14)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_14")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point15)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_15")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point16)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_16")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point17)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_17")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point18)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_18")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point19)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_19")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point20)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_20")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point21)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_21")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point22)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_22")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point23)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_23")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point24)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_24")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point25)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_25")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point26)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_26")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point27)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_27")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point28)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_28")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point29)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_29")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point3)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point30)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_30")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point4)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point5)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_5")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point6)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_6")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point7)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_7")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point8)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_8")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Point9)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("point_9")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.DetailId)
                    .HasConstraintName("FK__Routes__detail_i__4222D4EF");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.HasKey(e => e.IdStation)
                    .HasName("PK__Station__13EE0DCE93F8ABC9");

                entity.ToTable("Station");

                entity.Property(e => e.IdStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_station")
                    .UseCollation("Thai_100_CS_AI");

                entity.Property(e => e.IdProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_province")
                    .UseCollation("Thai_100_CS_AI");

                entity.Property(e => e.NameStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("name_station")
                    .UseCollation("Thai_100_CS_AI");

                entity.Property(e => e.PhoneStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("phone_station")
                    .UseCollation("Thai_100_CS_AI");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdTicket)
                    .HasName("PK__Ticket__48C6F523A6C07F78");

                entity.ToTable("Ticket");

                entity.Property(e => e.IdTicket)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_ticket");

                entity.Property(e => e.DateTicket)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("date_ticket");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("departure_time");

                entity.Property(e => e.IdCar)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("id_car");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_province");

                entity.Property(e => e.OriginStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("origin_station");

                entity.Property(e => e.Passenger)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("passenger");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.TerminalProvince)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("terminal_province");

                entity.Property(e => e.TerminalStation)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("terminal_station");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.Property(e => e.TravelDate)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("travel_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Ticket__user_id__6A30C649");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Status)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
