using System;
using Back_End_Final_Education.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Back_End_Final_Education.Data
{
	public class AppDbContext:DbContext
	{

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Icon>  Icons { get; set; }

        public DbSet<Information> Informations { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<InstructorSocialMedia> InstructorSocialMedias { get; set; }

        public DbSet<Student> Students { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Icon>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Information>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<About>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Instructor>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<SocialMedia>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<InstructorSocialMedia>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Student>().HasQueryFilter(m => !m.SoftDeleted);







            modelBuilder.Entity<Slider>().HasData(
                 new Slider
                 {
                   Id=1,
                   Subject= "Best Online Courses",
                   Title= "The Best Online Learning Platform",
                   Description= "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                   Image= "carousel-1.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
                 },
                  new Slider
                  {
                      Id = 2,
                      Subject = "Best Online Courses",
                      Title = "Get Educated Online From Your Home",
                      Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                      Image = "carousel-2.jpg",
                      SoftDeleted = false,
                      CreatedDate = DateTime.Now
                  }
                );


            modelBuilder.Entity<Icon>().HasData(
                new Icon
                {
                    Id = 1,
                    ClassName= "fa fa-3x fa-graduation-cap",
                    SoftDeleted = false,
                    CreatedDate = DateTime.Now
                },
                 new Icon
                 {
                     Id = 2,
                     ClassName = "fa fa-3x fa-globe",
                     SoftDeleted = false,
                     CreatedDate = DateTime.Now
                 },
                 new Icon
                 {
                     Id = 3,
                     ClassName = "fa fa-3x fa-home",
                     SoftDeleted = false,
                     CreatedDate = DateTime.Now
                 },
                 new Icon
                 {
                     Id = 4,
                     ClassName = "fa fa-3x fa-book-open",
                     SoftDeleted = false,
                     CreatedDate = DateTime.Now
                 }

               );

            modelBuilder.Entity<Information>().HasData(
               new Information
               {
                   Id = 1,
                   Title = "Skilled Instructors",
                   IconId=1,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 2,
                   Title = "Online Classes",
                   IconId = 2,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 3,
                   Title = "Home Projects",
                   IconId = 3,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 4,
                   Title = "Book Library",
                   IconId = 4,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

              );





            modelBuilder.Entity<About>().HasData(
               new About
               {
                   Id = 1,
                   Title = "Welcome to eLEARNING",
                   Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet",
                   Image= "about.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }
              );

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name="Web Design",
                   Image = "cat-1.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 2,
                   Name = "Graphic Design",
                   Image = "cat-2.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 3,
                   Name = "Video Editing",
                   Image = "cat-3.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 4,
                   Name = "Online Marketing",
                   Image = "cat-4.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

              );



            modelBuilder.Entity<Instructor>().HasData(
               new Instructor
               {
                   Id = 1,
                   FullName = "John Doe",
                   Position="Web Designer",
                   Image = "team-1.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Instructor
               {
                   Id = 2,
                   FullName = "Angelina Jolie",
                   Position = "Graphic Designer",
                   Image = "team-2.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Instructor
               {
                   Id = 3,
                   FullName = "Jake Oliver",
                   Position = "Video Editor",
                   Image = "team-3.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
              new Instructor
              {
                  Id = 4,
                  FullName = "Emily Prior",
                  Position = "SMM Manager",
                  Image = "team-4.jpg",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              }

              );



            modelBuilder.Entity<SocialMedia>().HasData(
               new SocialMedia
               {
                   Id = 1,
                   Name = "Instagram",
                   Icon = "fab fa-instagram",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new SocialMedia
               {
                   Id = 2,
                   Name = "Facebook",
                   Icon = "fab fa-facebook-f",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new SocialMedia
               {
                   Id = 3,
                   Name = "Twitter",
                   Icon = "fab fa-twitter",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

              );


            //modelBuilder.Entity<InstructorSocialMedia>().HasData(
            //   new InstructorSocialMedia
            //   {
            //       Id = 1,
            //       SocialMediaId=1,
            //       InstructorId=1,
            //       SocialLink= "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 2,
            //       SocialMediaId = 2,
            //       InstructorId = 1,
            //       SocialLink = "https://www.facebook.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 3,
            //       SocialMediaId = 3,
            //       InstructorId = 1,
            //       SocialLink = "https://x.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },

            //   new InstructorSocialMedia
            //   {
            //       Id = 4,
            //       SocialMediaId = 1,
            //       InstructorId = 2,
            //       SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 5,
            //       SocialMediaId = 2,
            //       InstructorId = 2,
            //       SocialLink = "https://www.facebook.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 6,
            //       SocialMediaId = 3,
            //       InstructorId = 2,
            //       SocialLink = "https://x.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },

            //   new InstructorSocialMedia
            //   {
            //       Id = 7,
            //       SocialMediaId = 1,
            //       InstructorId = 3,
            //       SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 8,
            //       SocialMediaId = 2,
            //       InstructorId = 3,
            //       SocialLink = "https://www.facebook.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 9,
            //       SocialMediaId = 3,
            //       InstructorId = 3,
            //       SocialLink = "https://x.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 10,
            //       SocialMediaId = 1,
            //       InstructorId = 4,
            //       SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 11,
            //       SocialMediaId = 2,
            //       InstructorId = 4,
            //       SocialLink = "https://www.facebook.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   },
            //   new InstructorSocialMedia
            //   {
            //       Id = 12,
            //       SocialMediaId = 3,
            //       InstructorId = 4,
            //       SocialLink = "https://x.com",
            //       SoftDeleted = false,
            //       CreatedDate = DateTime.Now
            //   }



            //  );




            modelBuilder.Entity<Student>().HasData(
              new Student
              {
                  Id = 1,
                  FullName = "James Beaufort",
                  Image= "testimonial-1.jpg",
                  Description= "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                  Profession="IT",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
               new Student
               {
                   Id = 2,
                   FullName = "Lydia Beaufort",
                   Image = "testimonial-2.jpg",
                   Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                   Profession = "Designer",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Student
               {
                   Id = 3,
                   FullName = "Max Beaufort",
                   Image = "testimonial-3.jpg",
                   Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                   Profession = "SMM",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
                new Student
                {
                    Id = 4,
                    FullName = "Ruby Beaufort",
                    Image = "testimonial-4.jpg",
                    Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                    Profession = "Programmer",
                    SoftDeleted = false,
                    CreatedDate = DateTime.Now
                }

             );





        }
    }
}

