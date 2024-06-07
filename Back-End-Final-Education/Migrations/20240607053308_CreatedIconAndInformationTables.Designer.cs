﻿// <auto-generated />
using System;
using Back_End_Final_Education.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back_End_Final_Education.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240607053308_CreatedIconAndInformationTables")]
    partial class CreatedIconAndInformationTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Back_End_Final_Education.Models.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Icons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassName = "fa fa-3x fa-graduation-cap",
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "fa fa - 3x fa - globe",
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "fa fa-3x fa-home",
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "fa fa-3x fa-book-open",
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4660),
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IconId");

                    b.ToTable("Informations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4670),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 1,
                            SoftDeleted = false,
                            Title = "Skilled Instructors"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 2,
                            SoftDeleted = false,
                            Title = "Online Classes"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 3,
                            SoftDeleted = false,
                            Title = "Home Projects"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4680),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 4,
                            SoftDeleted = false,
                            Title = "Book Library"
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4600),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-1.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "The Best Online Learning Platform"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 7, 9, 33, 8, 219, DateTimeKind.Local).AddTicks(4600),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-2.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "Get Educated Online From Your Home"
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Information", b =>
                {
                    b.HasOne("Back_End_Final_Education.Models.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icon");
                });
#pragma warning restore 612, 618
        }
    }
}