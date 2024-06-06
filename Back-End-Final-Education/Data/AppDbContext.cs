using System;
using Back_End_Final_Education.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Data
{
	public class AppDbContext:DbContext
	{

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);

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

        }
    }
}

