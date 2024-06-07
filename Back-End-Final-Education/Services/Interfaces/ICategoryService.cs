using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Categories;
using Back_End_Final_Education.ViewModels.Slider;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync();
		Task<IEnumerable<CategoryVM>> GetAllForAdminAsync();
        Task<CategoryDetailVM> DetailAsync(int id);
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Category category);
        Task<Category> GetByIdAsync(int id);
        Task DeleteAsync(Category category);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task EditAsync(Category category, CategoryEditVM request);


    }
}

