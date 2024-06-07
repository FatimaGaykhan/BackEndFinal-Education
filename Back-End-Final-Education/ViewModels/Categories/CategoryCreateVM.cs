using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Categories
{
	public class CategoryCreateVM
	{
		[Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public IFormFile Image { get; set; }

	}
}

