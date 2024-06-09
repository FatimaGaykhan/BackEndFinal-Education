using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Students
{
	public class StudentCreateVM
	{
        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        [StringLength(200)]
        public string Profession { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

	}
}

