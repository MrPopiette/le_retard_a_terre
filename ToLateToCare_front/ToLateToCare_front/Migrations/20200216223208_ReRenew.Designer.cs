﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToLateToCare_front.Data;

namespace ToLateToCare_front.Migrations
{
    [DbContext(typeof(ContexteBDD))]
    [Migration("20200216223208_ReRenew")]
    partial class ReRenew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_2Late2CareBack.Classe", b =>
                {
                    b.Property<string>("libelle")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("libelle");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("_2Late2CareBack.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("_2Late2CareBack.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("auteurId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<string>("titre")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("urlPhoto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("auteurId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("_2Late2CareBack.TicketTag", b =>
                {
                    b.Property<string>("libelle")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int?>("tagId")
                        .HasColumnType("int");

                    b.HasKey("libelle", "TicketId");

                    b.HasIndex("TicketId");

                    b.HasIndex("tagId");

                    b.ToTable("TicketTag");
                });

            modelBuilder.Entity("_2Late2CareBack.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("classelibelle")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pseudo")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("classelibelle");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("_2Late2CareBack.Vote", b =>
                {
                    b.Property<int>("utilisateurId")
                        .HasColumnType("int");

                    b.Property<int>("ticketId")
                        .HasColumnType("int");

                    b.HasKey("utilisateurId", "ticketId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("_2Late2CareBack.Ticket", b =>
                {
                    b.HasOne("_2Late2CareBack.Utilisateur", "auteur")
                        .WithMany()
                        .HasForeignKey("auteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_2Late2CareBack.TicketTag", b =>
                {
                    b.HasOne("_2Late2CareBack.Ticket", "ticket")
                        .WithMany("TicketTags")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2Late2CareBack.Tag", "tag")
                        .WithMany("TicketTags")
                        .HasForeignKey("tagId");
                });

            modelBuilder.Entity("_2Late2CareBack.Utilisateur", b =>
                {
                    b.HasOne("_2Late2CareBack.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("classelibelle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
