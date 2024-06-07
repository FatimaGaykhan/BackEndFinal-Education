using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Abouts
{
	public class AboutEditVM
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        public string Description { get; set; }

        public string Image { get; set; }

        public IFormFile NewImage { get; set; }
    }
}

