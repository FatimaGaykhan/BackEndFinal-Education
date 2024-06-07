using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Abouts
{
	public class AboutCreateVM
	{
        [Required]
        [StringLength(200)]
        public string Title { get; set; }


        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public IFormFile Image { get; set; }

	}
}

