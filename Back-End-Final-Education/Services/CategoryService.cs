using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Categories;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<CategoryDetailVM> DetailAsync(int id)
        {
            Category category = await _context.Categories.Where(m => m.Id == id).FirstOrDefaultAsync();

            return new CategoryDetailVM
            {
                Image = category.Image,
                Name = category.Name,
                CreatedDate = category.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _context.Categories.AnyAsync(m => m.Name.Trim() == name.Trim());
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<CategoryVM>> GetAllForAdminAsync()
        {
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();

            return categories.Select(m => new CategoryVM
            {
                Id = m.Id,
                Image = m.Image,
                Name = m.Name,
            });
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.Where(m => m.Id == id).FirstOrDefaultAsync();

        }

        public async Task<bool> ExistExceptByIdAsync(int id, string name)
        {
            return await _context.Categories.AnyAsync(m => m.Name == name && m.Id != id);
        }

        public async Task EditAsync(Category category, CategoryEditVM request)
        {

            category.Name = request.Name;
            await _context.SaveChangesAsync();
        }
    }
}

