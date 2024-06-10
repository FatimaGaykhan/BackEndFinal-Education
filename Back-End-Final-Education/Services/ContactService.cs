using System;
using Back_End_Final_Education.Data;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Categories;
using Back_End_Final_Education.ViewModels.Contact;
using Back_End_Final_Education.ViewModels.Course;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Final_Education.Services
{
	public class ContactService:IContactService
	{
		private readonly AppDbContext _context;

		public ContactService(AppDbContext context)
		{
			_context = context;
		}

        public async Task CreateAsync(Contact contact)
        {
			await _context.Contacts.AddAsync(contact);
			await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Contact contact)
        {
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ContactIndexVM>> GetAllForAdminAsync()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return contacts.Select(m => new ContactIndexVM
            {
                Id = m.Id,
                Username = m.Username,
                Email=m.Email,
                Subject=m.Subject,
                CreateDate=m.CreatedDate.ToString("MM.dd.yyyy"),
                Message=m.Message
               
            });
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            return await _context.Contacts.Where(m => m.Id == id).FirstOrDefaultAsync();

        }
    }
}

