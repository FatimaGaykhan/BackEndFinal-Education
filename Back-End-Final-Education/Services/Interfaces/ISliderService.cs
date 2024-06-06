using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Slider;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface ISliderService
	{
        Task<IEnumerable<Slider>> GetAllAsync();
        Task<IEnumerable<SliderVM>> GetAllForAdminAsync();
        Task<Slider> GetByIdAsync(int id);
        Task<SliderDetailVM> DetailAsync(int id);
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Slider slider);
        Task DeleteAsync(Slider slider);
        Task<bool> ExistExceptByIdAsync(int id, string title);
        Task EditAsync(Slider slider, SliderEditVM request);
    }
}

