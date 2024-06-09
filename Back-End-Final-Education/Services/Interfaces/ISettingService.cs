using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Setting;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface ISettingService
	{
        Task<Dictionary<string, string>> GetAllAsync();
        Task<IEnumerable<Setting>> GetAllForAdminAsync();
        Task<Setting> GetByIdAsync(int id);
        Task EditAsync();

    }
}

