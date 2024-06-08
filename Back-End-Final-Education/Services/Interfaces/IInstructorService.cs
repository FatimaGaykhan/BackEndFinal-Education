using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Instructor;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IInstructorService
	{
		Task<IEnumerable<Instructor>> GetAllAsync();
		Task<IEnumerable<InstructorVM>> GetAllForAdminAsync();
		Task<Instructor> GetByIdAsync(int id);
        Task<InstructorDetailVM> DetailAsync(int id);
        Task CreateAsync(Instructor instructor);
        Task DeleteAsync(Instructor instructor);
        Task<SelectList> GetAllSelectedAsync();
        Task<bool> ExistExceptByIdAsync(int id, string link);
        Task AddSocialAsync(InstructorSocialMedia instructorSocialMedia);
        Task<SelectList> GetAllSelectedByLinkAsync(int id);
        Task EditAsync(Instructor instructor, InstructorEditVM request);

    }
}

