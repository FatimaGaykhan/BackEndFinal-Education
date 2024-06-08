using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Instructor
{
	public class InstructorSocialMediaVM
	{
		[Required]
		public string Link { get; set; }

		public int SocialMediaId { get; set; }


	}
}

