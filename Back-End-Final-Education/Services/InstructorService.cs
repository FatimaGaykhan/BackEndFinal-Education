using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Instructor;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class InstructorService:IInstructorService
	{
		private readonly AppDbContext _context;

		public InstructorService(AppDbContext context)
		{
			_context = context;
		}

        public async Task CreateAsync(Instructor instructor)
        {
            await _context.AddAsync(instructor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Instructor instructor)
        {
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();
        }

        public async Task<InstructorDetailVM> DetailAsync(int id)
        {
            Instructor instructor = await _context.Instructors.Where(m => m.Id == id)
                                                              .Include(m => m.InstructorSocialMedias)
                                                              .ThenInclude(m => m.SocialMedia)
                                                              .FirstOrDefaultAsync();


            List<String> socialMedias = new List<string>();

            string instructorSocialMedias = "";

            socialMedias =instructor.InstructorSocialMedias.Select(m => m.SocialLink).ToList();
            

            instructorSocialMedias = string.Join(",", socialMedias);

            return new InstructorDetailVM
            {
                Image = instructor.Image,
                FullName = instructor.FullName,
                CreatedDate = instructor.CreatedDate.ToString("MM.dd.yyyy"),
                SocialMedias= instructorSocialMedias,
                Position=instructor.Position


            };
        }

        public async Task AddSocialAsync( InstructorSocialMedia instructorSocialMedia)
        {
            _context.InstructorSocialMedias.Add(instructorSocialMedia);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> ExistExceptByIdAsync(int id, string link)
        {
            var instructor = await _context.Instructors.
                Include(m=>m.InstructorSocialMedias).FirstOrDefaultAsync(m=>m.Id==id);
            bool isContain = instructor.InstructorSocialMedias.Any(m => m.SocialLink == link);

            return isContain;
        }

        public async Task<IEnumerable<Instructor>> GetAllAsync()
        {
			return await _context.Instructors.Include(m => m.InstructorSocialMedias).ThenInclude(m => m.SocialMedia).ToListAsync();
        }

        public async Task<IEnumerable<InstructorVM>> GetAllForAdminAsync()
        {
            IEnumerable<Instructor> instructors = await _context.Instructors.Include(m=>m.InstructorSocialMedias).ThenInclude(m=>m.SocialMedia).ToListAsync();

            List<InstructorVM> instructors2 = new();



            foreach (var item in instructors)
            {
                instructors2.Add(new InstructorVM
                {
                    Id=item.Id,
                    FullName=item.FullName,
                    Position=item.Position,
                    Image=item.Image,
                    SocialMedias= string.Join(",", item.InstructorSocialMedias.Select(m => m.SocialLink).ToList())

                });
            }




            return instructors2; 
           
        }

        public async Task<SelectList> GetAllSelectedAsync()
        {
            var socialMedias = await _context.SocialMedias.ToListAsync();
            return new SelectList(socialMedias, "Id", "Name");
        }

        public async Task<SelectList> GetAllSelectedByLinkAsync(int id)
        {
            var instructorSocialMedias = await _context.InstructorSocialMedias.Where(m => m.InstructorId == id).ToListAsync();
            return new SelectList(instructorSocialMedias, "Id", "SocialLink");
        }

        public async Task<Instructor> GetByIdAsync(int id)
        {
            return await _context.Instructors.Where(m => m.Id == id).Include(m => m.InstructorSocialMedias).ThenInclude(m => m.SocialMedia).FirstOrDefaultAsync();

            
        }

        public async Task EditAsync(Instructor instructor, InstructorEditVM request)
        {
            instructor.FullName = request.FullName;
            instructor.Position = request.Position;
            await _context.SaveChangesAsync();
        }
    }
}

