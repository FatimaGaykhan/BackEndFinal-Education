﻿using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Instructor;
using Back_End_Final_Education.ViewModels.Slider;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IStudentService
	{
		Task<IEnumerable<Student>> GetAllAsync();
		Task<IEnumerable<StudentVM>> GetAllForAdminasync();
        Task<Student> GetByIdAsync(int id);
        Task<StudentDetailVM> DetailAsync(int id);
        Task CreateAsync(Student student);
        Task DeleteAsync(Student student);
        Task EditAsync(Student student, StudentEditVM request);
        //Task<SelectList> GetAllSelectedByStudentAsync(int id);
        //Task<SelectList> GetAllSelectedByCourseAsync(int id);
        Task<SelectList> GetAllSelectedByCourseAsync();
        Task<SelectList> GetAllSelectedByStudentAsync();
        Task AddToCourseAsync(CourseStudent courseStudent);
        Task DeleteCourseAsync(DeleteCourseFromStudentVM data);
        Task<Student> GetByIdWithAllDatasAsync(int id);


    }
}

