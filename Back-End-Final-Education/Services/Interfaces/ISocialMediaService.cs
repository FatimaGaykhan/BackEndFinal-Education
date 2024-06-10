using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Course;
using Back_End_Final_Education.ViewModels.SocialMedia;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface ISocialMediaService
	{
		Task<IEnumerable<SocialMediaVM>> GetAllAsync();
        Task<SocialMediaDetailVM> DetailAsync(int id);
        Task<SelectList> GetAllSelectedSocialMediaAsync();
        Task<SocialMedia> GetByIdAsync(int id);
        Task EditAsync(SocialMedia socialMedia, SocialMediaEditVM editSocial);
        Task CreateAsync(SocialMedia socialMedia);
        Task DeleteAsync(SocialMedia socialMedia);

    }
}

