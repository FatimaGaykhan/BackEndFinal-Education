using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Instructor;
using Back_End_Final_Education.ViewModels.Slider;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class StudentService:IStudentService
	{
        private readonly AppDbContext _context;

		public StudentService(AppDbContext context)
		{
            _context = context;
		}

        public async Task AddToCourseAsync(CourseStudent courseStudent)
        {
            _context.CourseStudents.Add(courseStudent);
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(DeleteCourseFromStudentVM data)
        {
            var studentcourse = await _context.CourseStudents.FirstOrDefaultAsync(m => m.CourseId == data.CourseId&& m.StudentId== data.StudentId);

            _context.Remove(studentcourse);

            await _context.SaveChangesAsync();
        }

        public async Task<StudentDetailVM> DetailAsync(int id)
        {
            Student student = await _context.Students.Where(m => m.Id == id).FirstOrDefaultAsync();

            return new StudentDetailVM
            {
                Image = student.Image,
                Description = student.Description,
                Profession= student.Profession,
                FullName = student.FullName,
                CreatedDate = student.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task EditAsync(Student student, StudentEditVM request)
        {
            student.FullName = request.FullName;
            student.Profession = request.Profession;
            student.Description = request.Description;
            await _context.SaveChangesAsync();
        }

        

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<IEnumerable<StudentVM>> GetAllForAdminasync()
        {
            IEnumerable<Student> students = await _context.Students.ToListAsync();

            return students.Select(m => new StudentVM
            {
                Id = m.Id,
                Image = m.Image,
                Profession = m.Profession,
                Description = m.Description,
                FullName = m.FullName,
            });
        }

        public async Task<SelectList> GetAllSelectedByCourseAsync()
        {
            var courses = await _context.Courses.ToListAsync();
            return new SelectList(courses, "Id", "Name");
        }

       
        public async Task<SelectList> GetAllSelectedByStudentAsync()
        {
            var students = await _context.Students.ToListAsync();
            return new SelectList(students, "Id", "FullName");
        }

        //public async Task<SelectList> GetAllSelectedByCourseAsync(int id)
        //{
        //    var courses = await _context.Courses.Where(m => m.Id == id).ToListAsync();
        //    return new SelectList(courses, "Id", "Name");
        //}

        //public async Task<SelectList> GetAllSelectedByStudentAsync(int id)
        //{
        //    var students = await _context.Students.Where(m => m.Id == id).ToListAsync();
        //    return new SelectList(students, "Id", "FullName");
        //}

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _context.Students.Where(m => m.Id == id).FirstOrDefaultAsync();

        }

        public async Task<Student> GetByIdWithAllDatasAsync(int id)
        {
           var result= await _context.Students.Where(m => m.Id == id)
                                          .Include(m => m.CourseStudents)
                                          .ThenInclude(m=>m.Course)
                                          .FirstOrDefaultAsync();

            return result;
        }
    }
}

