using System;
using Microsoft.AspNetCore.Identity;

namespace Back_End_Final_Education.Models
{
	public class AppUser:IdentityUser
	{
        public string FullName { get; set; }
    }
}

