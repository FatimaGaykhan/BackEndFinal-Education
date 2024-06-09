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
    [Migration("20240609072427_CreateStudentsTable")]
    partial class CreateStudentsTable
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4650),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4660),
                            Image = "cat-1.jpg",
                            Name = "Web Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670),
                            Image = "cat-2.jpg",
                            Name = "Graphic Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670),
                            Image = "cat-3.jpg",
                            Name = "Video Editing",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4670),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "fa fa-3x fa-globe",
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "fa fa-3x fa-home",
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620),
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "fa fa-3x fa-book-open",
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4620),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4630),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 1,
                            SoftDeleted = false,
                            Title = "Skilled Instructors"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 2,
                            SoftDeleted = false,
                            Title = "Online Classes"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640),
                            Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                            IconId = 3,
                            SoftDeleted = false,
                            Title = "Home Projects"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4640),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680),
                            FullName = "John Doe",
                            Image = "team-1.jpg",
                            Position = "Web Designer",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680),
                            FullName = "Angelina Jolie",
                            Image = "team-2.jpg",
                            Position = "Graphic Designer",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4680),
                            FullName = "Jake Oliver",
                            Image = "team-3.jpg",
                            Position = "Video Editor",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4690),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4540),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-1.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "The Best Online Learning Platform"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4550),
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
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4700),
                            Icon = "fab fa-instagram",
                            Name = "Instagram",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4700),
                            Icon = "fab fa-facebook-f",
                            Name = "Facebook",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4710),
                            Icon = "fab fa-twitter",
                            Name = "Twitter",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Back_End_Final_Education.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                            FullName = "James Beaufort",
                            Image = "testimonial-1.jpg",
                            Profession = "IT",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                            FullName = "Lydia Beaufort",
                            Image = "testimonial-2.jpg",
                            Profession = "Designer",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                            FullName = "Max Beaufort",
                            Image = "testimonial-3.jpg",
                            Profession = "SMM",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 24, 27, 519, DateTimeKind.Local).AddTicks(4720),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                            FullName = "Ruby Beaufort",
                            Image = "testimonial-4.jpg",
                            Profession = "Programmer",
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
