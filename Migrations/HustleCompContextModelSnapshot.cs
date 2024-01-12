﻿// <auto-generated />
using System;
using DominosDriverHustleComp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DominosDriverHustleComp.Migrations
{
    [DbContext(typeof(HustleCompContext))]
    partial class HustleCompContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("DominosDriverHustleComp.Models.DeliveryRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DispatchedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DriverId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LeftStoreAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StoreEnteredAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("DominosDriverHustleComp.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("DominosDriverHustleComp.Models.DeliveryRecord", b =>
                {
                    b.HasOne("DominosDriverHustleComp.Models.Driver", "Driver")
                        .WithMany("Deliveries")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("DominosDriverHustleComp.Models.Driver", b =>
                {
                    b.Navigation("Deliveries");
                });
#pragma warning restore 612, 618
        }
    }
}
