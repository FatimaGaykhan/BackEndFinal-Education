using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.SocialMedia
{
	public class SocialMediaEditVM
	{
		public int SocialId { get; set; }

		[Required]
		public string IconClass { get; set; }

	}
}

