﻿// <auto-generated />
using System;
using Bounce.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bounce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210405165528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bounce.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PlayerAId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlayerAScore")
                        .HasColumnType("int");

                    b.Property<Guid?>("PlayerBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlayerBScore")
                        .HasColumnType("int");

                    b.Property<int>("RoundNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlayerAId");

                    b.HasIndex("PlayerBId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Bounce.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("TotalGames")
                        .HasColumnType("int");

                    b.Property<Guid?>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Bounce.Entities.Tournament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WinningScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("Bounce.Entities.Game", b =>
                {
                    b.HasOne("Bounce.Entities.Player", "PlayerA")
                        .WithMany()
                        .HasForeignKey("PlayerAId");

                    b.HasOne("Bounce.Entities.Player", "PlayerB")
                        .WithMany()
                        .HasForeignKey("PlayerBId");

                    b.Navigation("PlayerA");

                    b.Navigation("PlayerB");
                });

            modelBuilder.Entity("Bounce.Entities.Player", b =>
                {
                    b.HasOne("Bounce.Entities.Tournament", null)
                        .WithMany("Entrants")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("Bounce.Entities.Tournament", b =>
                {
                    b.Navigation("Entrants");
                });
#pragma warning restore 612, 618
        }
    }
}