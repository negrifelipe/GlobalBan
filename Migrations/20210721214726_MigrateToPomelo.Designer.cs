﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pustalorc.GlobalBan.Database;

namespace Pustalorc.GlobalBan.Migrations
{
    [DbContext(typeof(GlobalBanDbContext))]
    [Migration("20210721214726_MigrateToPomelo")]
    partial class MigrateToPomelo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pustalorc.GlobalBan.API.Classes.PlayerBan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<ulong>("AdminId")
                        .HasColumnType("bigint unsigned");

                    b.Property<uint>("Duration")
                        .HasColumnType("int unsigned");

                    b.Property<string>("Hwid")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<uint>("Ip")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsUnbanned")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("PlayerId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfBan")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Pustalorc_GlobalBan_PlayerBans");
                });
#pragma warning restore 612, 618
        }
    }
}
