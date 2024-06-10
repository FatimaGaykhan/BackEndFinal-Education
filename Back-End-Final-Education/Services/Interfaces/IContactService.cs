using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.ViewModels.Contact;

namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IContactService
	{
		Task CreateAsync(Contact contact);
		Task<IEnumerable<ContactIndexVM>> GetAllForAdminAsync();
        Task<Contact> GetByIdAsync(int id);
        Task DeleteAsync(Contact contact);

    }
}

