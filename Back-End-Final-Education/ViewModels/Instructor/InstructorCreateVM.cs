using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Instructor
{
	public class InstructorCreateVM
	{
        [Required]
        public IFormFile Image { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(200)]
        public string Position { get; set; }

        //[Required]
        //[StringLength(200)]
        //public string SocialMedias { get; set; }
    }
}

