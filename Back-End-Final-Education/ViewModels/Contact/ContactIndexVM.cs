using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Contact
{
	public class ContactIndexVM
	{
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string CreateDate { get; set; }
    }
}

