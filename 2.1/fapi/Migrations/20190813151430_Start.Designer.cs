﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fantacalcioApi.Data;

namespace fapi.Migrations
{
    [DbContext(typeof(FantacalcioContext))]
    [Migration("20190813151430_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("fantacalcioApi.Data.Entities.Championship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anno");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("fantacalcioApi.Data.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageFv");

                    b.Property<int>("CurrentValue");

                    b.Property<Guid?>("FantaTeamId");

                    b.Property<string>("Name");

                    b.Property<string>("Role");

                    b.Property<int>("SoldValue");

                    b.Property<int>("StartValue");

                    b.Property<string>("Team");

                    b.HasKey("Id");

                    b.HasIndex("FantaTeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("fantacalcioApi.Data.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anno");

                    b.Property<Guid?>("ChampionshipId");

                    b.Property<int>("FantaMilioni");

                    b.Property<string>("Name");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.HasIndex("ChampionshipId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("fantacalcioApi.Data.Entities.Player", b =>
                {
                    b.HasOne("fantacalcioApi.Data.Entities.Team", "FantaTeam")
                        .WithMany("Giocatori")
                        .HasForeignKey("FantaTeamId");
                });

            modelBuilder.Entity("fantacalcioApi.Data.Entities.Team", b =>
                {
                    b.HasOne("fantacalcioApi.Data.Entities.Championship", "Championship")
                        .WithMany("Squadre")
                        .HasForeignKey("ChampionshipId");
                });
#pragma warning restore 612, 618
        }
    }
}
