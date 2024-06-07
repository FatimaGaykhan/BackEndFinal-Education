using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Informations;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
    public class InformationService : IInformationService
    {
        private readonly AppDbContext _context;

        public InformationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<InformationDetailVM> DetailAsync(int id)
        {
            Information info = await _context.Informations.Where(m => m.Id == id).Include(m=>m.Icon).FirstOrDefaultAsync();

            return new InformationDetailVM
            {
                ClassName=info.Icon.ClassName,
                Description = info.Description,
                Title = info.Title,
                CreatedDate = info.CreatedDate.ToString("MM.dd.yyyy")

            };
        }

        public async Task<IEnumerable<Information>> GetAllAsync()
        {
            return await _context.Informations.Include(m => m.Icon).ToListAsync();
        }

        public async Task<IEnumerable<InformationVM>> GetAllForAdminAsync()
        {
            IEnumerable<Information> infos= await _context.Informations.Include(m => m.Icon).ToListAsync();

            return infos.Select(m => new InformationVM
            {
                Id = m.Id,
                ClassName = m.Icon.ClassName,
                Description = m.Description,
                Title = m.Title,
            }); ;
        }

        public async Task<Information> GetByIdAsync(int id)
        {
            return await _context.Informations.Where(m => m.Id == id).Include(m=>m.Icon).FirstOrDefaultAsync();
        }

        public async Task<SelectList> GetAllSelectedAsync()
        {
            var infos = await _context.Icons.ToListAsync();
            return new SelectList(infos, "Id", "ClassName");
        }

        public async Task CreateAsync(Information information)
        {
            await _context.Informations.AddAsync(information);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Information information)
        {
            _context.Informations.Remove(information);
            await _context.SaveChangesAsync();
        }

        public async Task<Information> GetByIdWithAllDatasAsync(int id)
        {
            return await _context.Informations.Where(m => m.Id == id)
                                         .Include(m => m.Icon)
                                         .FirstOrDefaultAsync();
        }

        public async Task<bool> ExistExceptByIdAsync(int id, string name)
        {
            return await _context.Informations.AnyAsync(m => m.Title == name && m.Id != id);
        }

        public async Task EditAsync(Information information, InformationEditVM request)
        {
           information.Title = request.Title;
           information.Description = request.Description;
           information.IconId = request.IconId;

            await _context.SaveChangesAsync();
        }
    }
}

