using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Slider;
using Back_End_Final_Education.ViewModels.Students;

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

    }
}

