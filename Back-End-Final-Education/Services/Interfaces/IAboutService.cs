using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Abouts;
using Back_End_Final_Education.ViewModels.Slider;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IAboutService
	{
        public Task<About> GetAsync();
        public Task<IEnumerable<AboutVM>> GetAllForAdminAsync();
        Task<AboutDetailVM> DetailAsync(int id);
        Task CreateAsync(About about);
        Task<About> GetByIdAsync(int id);
        Task DeleteAsync(About about);
        Task EditAsync(About about, AboutEditVM request);



    }
}

