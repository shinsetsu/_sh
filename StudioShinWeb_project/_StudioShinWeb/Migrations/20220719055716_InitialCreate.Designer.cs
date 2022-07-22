﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _DBC;

#nullable disable

namespace _StudioShinWeb.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20220719055716_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_oBjects.shinSiteMetrics", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("EventsFiredDebug")
                        .HasColumnType("int");

                    b.Property<int>("EventsFiredRelease")
                        .HasColumnType("int");

                    b.Property<int>("pageViewsDebug")
                        .HasColumnType("int");

                    b.Property<int>("pageViewsRelease")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("shinSiteMetrics");
                });
#pragma warning restore 612, 618
        }
    }
}