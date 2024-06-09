using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Course;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface ICourseService
	{
		Task<IEnumerable<Course>> GetAllAsync();
		Task<IEnumerable<CourseVM>> GetAllForAdminasync();
        Task<Course> GetByIdWithAllDatasAsync(int id);
        Task<SelectList> GetAllSelectedCategoryAsync();
        Task<SelectList> GetAllSelectedInstructorAsync();
        Task CreateAsync(Course course);
        Task DeleteAsync(Course course);
        Task<bool> ExistAsync( string name);
        Task EditAsync(Course course, CourseEditVM editCourse);
        Task DeleteCourseImageAsync(MainAndDeleteCourseImageVM data);
        Task SetMainCourseImageAsync(MainAndDeleteCourseImageVM data);
    }
}

