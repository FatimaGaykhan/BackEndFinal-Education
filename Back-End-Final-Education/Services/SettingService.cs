using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewComponents;
using Back_End_Final_Education.ViewModels.Setting;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class SettingService:ISettingService
	{
        private readonly AppDbContext _context;

        public SettingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task EditAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Dictionary<string, string>> GetAllAsync()
        {
            return await _context.Settings.ToDictionaryAsync(m => m.Key, m => m.Value);
        }

        public async Task<IEnumerable<Setting>> GetAllForAdminAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            return await _context.Settings.Where(m => m.Id == id).FirstOrDefaultAsync();
        }
    }
}

