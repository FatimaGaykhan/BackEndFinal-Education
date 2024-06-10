using System;
namespace Back_End_Final_Education.Models
{
	public class Contact:BaseEntity
	{
		public string Username { get; set; }

		public string Email { get; set; }

		public string Subject { get; set; }

		public string Message { get; set; }

	}
}

