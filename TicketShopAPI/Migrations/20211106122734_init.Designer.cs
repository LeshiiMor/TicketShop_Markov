﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketShopAPI.Data;

namespace TicketShopAPI.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20211106122734_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("TicketShopAPI.Data.Models.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmountTickets")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEvent")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Place")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.MusicGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortInfo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MusicGroups");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.Musician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MusicGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MusicGroupId");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooking")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.ClassicType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameComposer")
                        .HasColumnType("longtext");

                    b.Property<string>("TypeVoice")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.ToTable("ClassicTypes");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.OpenAirType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Headliner")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.ToTable("OpenAirTypes");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.PartyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AgeRage")
                        .HasColumnType("int");

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Opportunities")
                        .HasColumnType("longtext");

                    b.Property<string>("Topic")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.ToTable("PartyTypes");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.Musician", b =>
                {
                    b.HasOne("TicketShopAPI.Data.Models.MusicGroup", "Group")
                        .WithMany("Musicians")
                        .HasForeignKey("MusicGroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.ClassicType", b =>
                {
                    b.HasOne("TicketShopAPI.Data.Models.Concert", "Concert")
                        .WithMany()
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.OpenAirType", b =>
                {
                    b.HasOne("TicketShopAPI.Data.Models.Concert", "Concert")
                        .WithMany()
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.TypeConcerts.PartyType", b =>
                {
                    b.HasOne("TicketShopAPI.Data.Models.Concert", "Concert")
                        .WithMany()
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");
                });

            modelBuilder.Entity("TicketShopAPI.Data.Models.MusicGroup", b =>
                {
                    b.Navigation("Musicians");
                });
#pragma warning restore 612, 618
        }
    }
}
