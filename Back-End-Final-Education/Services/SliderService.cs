using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class SliderService:ISliderService
	{
        private readonly AppDbContext _context;

		public SliderService(AppDbContext context)
		{
            _context = context;
		}

        public async Task<SliderDetailVM> DetailAsync(int id)
        {
            Slider slider= await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();

            return new SliderDetailVM
            {
                Image = slider.Image,
                Description = slider.Description,
                Subject = slider.Subject,
                Title = slider.Title,
                CreatedDate = slider.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            return await _context.Sliders.ToListAsync();
        }

        public async Task<IEnumerable<SliderVM>> GetAllForAdminAsync()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();

            return sliders.Select(m => new SliderVM
            {
                Id=m.Id,
                Image = m.Image,
                Subject = m.Subject,
                Description = m.Description,
                Title = m.Title,
            }); ;
        }

        public async Task<Slider> GetByIdAsync(int id)
        {

            return await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();
        }
    }
}

