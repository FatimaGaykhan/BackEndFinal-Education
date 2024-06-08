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
    [Migration("20240608091027_CreateInstructorAndSocialMediaAndPevotTable")]
    partial class CreateInstructorAndSocialMediaAndPevotTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Back_End_Final_Education.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(520),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet",
                            Image = "about.jpg",
                            SoftDeleted = false,
                            Title = "Welcome to eLEARNING"
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(530),
                            Image = "cat-1.jpg",
                            Name = "Web Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(530),
                            Image = "cat-2.jpg",
                            Name = "Graphic Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(540),
                            Image = "cat-3.jpg",
                            Name = "Video Editing",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(540),
                            Image = "cat-4.jpg",
                            Name = "Online Marketing",
                            SoftDeleted = false
                        });
                });

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
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "fa fa-3x fa-globe",
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "fa fa-3x fa-home",
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "fa fa-3x fa-book-open",
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(490),
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
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(500),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 1,
                            SoftDeleted = false,
                            Title = "Skilled Instructors"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 2,
                            SoftDeleted = false,
                            Title = "Online Classes"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 3,
                            SoftDeleted = false,
                            Title = "Home Projects"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(510),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 4,
                            SoftDeleted = false,
                            Title = "Book Library"
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550),
                            FullName = "John Doe",
                            Image = "team-1.jpg",
                            Position = "Web Designer",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550),
                            FullName = "Angelina Jolie",
                            Image = "team-2.jpg",
                            Position = "Graphic Designer",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(550),
                            FullName = "Jake Oliver",
                            Image = "team-3.jpg",
                            Position = "Video Editor",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(560),
                            FullName = "Emily Prior",
                            Image = "team-4.jpg",
                            Position = "SMM Manager",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.InstructorSocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SocialLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialMediaId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("SocialMediaId");

                    b.ToTable("InstructorSocialMedias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580),
                            InstructorId = 1,
                            SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                            SocialMediaId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580),
                            InstructorId = 1,
                            SocialLink = "https://www.facebook.com",
                            SocialMediaId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(580),
                            InstructorId = 1,
                            SocialLink = "https://x.com",
                            SocialMediaId = 3,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590),
                            InstructorId = 2,
                            SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                            SocialMediaId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590),
                            InstructorId = 2,
                            SocialLink = "https://www.facebook.com",
                            SocialMediaId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590),
                            InstructorId = 2,
                            SocialLink = "https://x.com",
                            SocialMediaId = 3,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(590),
                            InstructorId = 3,
                            SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                            SocialMediaId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(600),
                            InstructorId = 3,
                            SocialLink = "https://www.facebook.com",
                            SocialMediaId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(600),
                            InstructorId = 3,
                            SocialLink = "https://x.com",
                            SocialMediaId = 3,
                            SoftDeleted = false
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
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(420),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-1.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "The Best Online Learning Platform"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(430),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-2.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "Get Educated Online From Your Home"
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570),
                            Icon = "fab fa-instagram",
                            Name = "Instagram",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570),
                            Icon = "fab fa-facebook-f",
                            Name = "Facebook",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 13, 10, 27, 78, DateTimeKind.Local).AddTicks(570),
                            Icon = "fab fa-twitter",
                            Name = "Twitter",
                            SoftDeleted = false
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

            modelBuilder.Entity("Back_End_Final_Education.Models.InstructorSocialMedia", b =>
                {
                    b.HasOne("Back_End_Final_Education.Models.Instructor", "Instructor")
                        .WithMany("InstructorSocialMedias")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back_End_Final_Education.Models.SocialMedia", "SocialMedia")
                        .WithMany()
                        .HasForeignKey("SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Instructor", b =>
                {
                    b.Navigation("InstructorSocialMedias");
                });
#pragma warning restore 612, 618
        }
    }
}