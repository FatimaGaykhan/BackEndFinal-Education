using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Course;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class CourseService:ICourseService
	{
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

		public CourseService(AppDbContext context,
                            IWebHostEnvironment env)
		{
            _context = context;
            _env = env;
		}

        public async Task CreateAsync(Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourseImageAsync(MainAndDeleteCourseImageVM data)
        {
            var course = await _context.Courses.Where(m => m.Id == data.CourseId).Include(m => m.CourseImages).FirstOrDefaultAsync();

            var courseImage = course.CourseImages.FirstOrDefault(m => m.Id == data.ImageId);

            _context.CourseImages.Remove(courseImage);
            await _context.SaveChangesAsync();

            string path = _env.GenerateFilePath("assets/img", courseImage.Name);

            path.DeleteFileFromLocal();
        }

        public async Task EditAsync(Course course, CourseEditVM editCourse)
        {
            List<CourseImage> images = new();

            if (editCourse.NewImages != null)
            {
                foreach (var item in editCourse.NewImages)
                {
                    string fileName = $"{Guid.NewGuid()}-{item.FileName}";

                    string path = _env.GenerateFilePath("assets/img", fileName);
                    await item.SaveFileToLocalAsync(path);
                    images.Add(new CourseImage { Name = fileName });
                }

                course.CourseImages.AddRange(images);

            }





            course.Name = editCourse.Name;
            course.Description = editCourse.Description;
            course.CategoryId = editCourse.CategoryId;
            course.InstructorId = editCourse.InstructorId;
            course.Rating = editCourse.Rating;
            course.EndDate = editCourse.EndTime;
            course.StartDate = editCourse.StartTime;
            course.Price = decimal.Parse(editCourse.Price.Replace(".", ","));

            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _context.Courses.AnyAsync(m => m.Name.Trim() == name.Trim());
        }


        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.Courses.Include(m => m.CourseStudents).Include(m=>m.Instructor).Include(m => m.CourseImages).ToListAsync();
                                
        }

        public async Task<IEnumerable<CourseVM>> GetAllForAdminasync()
        {
            var courses = await _context.Courses.Include(m => m.CourseStudents).Include(m => m.Instructor).Include(m => m.CourseImages).ToListAsync();

            return courses.Select(m => new CourseVM
            {
                Id=m.Id,
                Name=m.Name,
                Instructor=m.Instructor.FullName,
                Price=m.Price.ToString(m.Price % 1 == 0 ? "0" : "0.00"),
                CourseImage=m.CourseImages.FirstOrDefault(m=>m.IsMain).Name,
                Rating=m.Rating,
            });
        }

        public async Task<SelectList> GetAllSelectedCategoryAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return new SelectList(categories, "Id", "Name");
        }

        public async Task<SelectList> GetAllSelectedInstructorAsync()
        {
            var instructors = await _context.Instructors.ToListAsync();
            return new SelectList(instructors, "Id", "FullName");
        }

        public async Task<Course> GetByIdWithAllDatasAsync(int id)
        {
            return await _context.Courses.Where(m => m.Id == id)
                                          .Include(m=>m.CourseStudents)
                                          .Include(m => m.Category)
                                          .Include(m=>m.Instructor)
                                          .Include(m => m.CourseImages)
                                          .FirstOrDefaultAsync();
        }

        public async Task SetMainCourseImageAsync(MainAndDeleteCourseImageVM data)
        {
            var course = await _context.Courses.Where(m => m.Id == data.CourseId).Include(m => m.CourseImages).FirstOrDefaultAsync();

            var courseImage = course.CourseImages.FirstOrDefault(m => m.Id == data.ImageId);

            if (course.CourseImages.Any(m => m.IsMain))
            {
                course.CourseImages.FirstOrDefault(m => m.IsMain).IsMain = false;
            }

            courseImage.IsMain = true;

            await _context.SaveChangesAsync();
        }
    }
}

