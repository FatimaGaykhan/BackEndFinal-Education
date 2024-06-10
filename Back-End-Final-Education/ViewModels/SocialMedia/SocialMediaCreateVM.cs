using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.SocialMedia
{
	public class SocialMediaCreateVM
	{
		[Required]
		public string Name { get; set; }

        [Required]
        public string Icon { get; set; }

	}
}

