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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Icon>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Information>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<About>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);





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







        }
    }
}

