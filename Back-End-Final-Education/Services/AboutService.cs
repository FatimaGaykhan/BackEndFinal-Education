using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Abouts;
using Back_End_Final_Education.ViewModels.Informations;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class AboutService:IAboutService
	{
        private readonly AppDbContext _context;

		public AboutService(AppDbContext context)
		{
            _context = context;
		}

        public async Task CreateAsync(About about)
        {
            await _context.AddAsync(about);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(About about)
        {
            _context.Abouts.Remove(about);
            await _context.SaveChangesAsync();
        }

        public async Task<AboutDetailVM> DetailAsync(int id)
        {
            About about = await _context.Abouts.Where(m => m.Id == id).FirstOrDefaultAsync();

            return new AboutDetailVM
            {
                Image = about.Image,
                Description = about.Description,
                Title = about.Title,
                CreatedDate = about.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task EditAsync(About about, AboutEditVM request)
        {
            about.Title = request.Title;
            about.Description = request.Description;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AboutVM>> GetAllForAdminAsync()
        {
            IEnumerable<About> abouts = await _context.Abouts.ToListAsync();

            return abouts.Select(m => new AboutVM
            {
                Id = m.Id,
                Image=m.Image,
                Description = m.Description,
                Title = m.Title,
            }); 
        }

        public async Task<About> GetAsync()
        {
            return await _context.Abouts.FirstOrDefaultAsync();
        }

        public async Task<About> GetByIdAsync(int id)
        {
            return await _context.Abouts.Where(m => m.Id == id).FirstOrDefaultAsync();

        }
    }
}

