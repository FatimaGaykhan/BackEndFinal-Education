using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Slider
{
	public class SliderCreateVM
	{
		[Required]
		public IFormFile Image { get; set; }

        [Required]
		[StringLength(200)]
        public string Subject { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

	}
}

