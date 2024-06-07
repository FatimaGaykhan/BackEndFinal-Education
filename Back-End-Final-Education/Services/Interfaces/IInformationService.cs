using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Informations;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IInformationService
	{
		public Task<IEnumerable<Information>> GetAllAsync();
        public Task<IEnumerable<InformationVM>> GetAllForAdminAsync();
        Task<Information> GetByIdAsync(int id);
        Task<InformationDetailVM> DetailAsync(int id);
        Task<SelectList> GetAllSelectedAsync();
        Task CreateAsync(Information information);
        Task DeleteAsync(Information information);
        Task<Information> GetByIdWithAllDatasAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task EditAsync(Information information, InformationEditVM request);
    }
}

