using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.SocialMedia;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class SocialMediaService:ISocialMediaService
	{
        private readonly AppDbContext _context;

		public SocialMediaService(AppDbContext context)
		{
            _context = context;
		}

        public async Task CreateAsync(SocialMedia socialMedia)
        {
            await _context.SocialMedias.AddAsync(socialMedia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(SocialMedia socialMedia)
        {
            _context.SocialMedias.Remove(socialMedia);
            await _context.SaveChangesAsync();
        }

        public async Task<SocialMediaDetailVM> DetailAsync(int id)
        {
            SocialMedia socialMedia = await _context.SocialMedias.Where(m => m.Id == id).FirstOrDefaultAsync();

            return new SocialMediaDetailVM
            {
                Icon=socialMedia.Icon,
                Name=socialMedia.Name,
                CreatedDate = socialMedia.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task EditAsync(SocialMedia socialMedia, SocialMediaEditVM editSocial)
        {
            socialMedia.Id = editSocial.SocialId;
            socialMedia.Icon = editSocial.IconClass.Trim();
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SocialMediaVM>> GetAllAsync()
        {
            var result= await _context.SocialMedias.ToListAsync();

            return result.Select(m => new SocialMediaVM
            {
                Id=m.Id,
                Icon=m.Icon,
                Name=m.Name

            });
        }

        public async Task<SelectList> GetAllSelectedSocialMediaAsync()
        {
            var socialMedias = await _context.SocialMedias.ToListAsync();
            return new SelectList(socialMedias, "Id", "Name");
        }

        public async Task<SocialMedia> GetByIdAsync(int id)
        {
            return await _context.SocialMedias.Where(m => m.Id == id).FirstOrDefaultAsync();

        }
    }
}

