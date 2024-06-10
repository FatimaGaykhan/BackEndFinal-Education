using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Contact
{
	public class ContactVM
	{
        [Required(ErrorMessage = "Username cannot be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject cannot be empty")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message cannot be empty")]
        public string Message { get; set; }

        public string UserEmail { get; set; }


    }
}

