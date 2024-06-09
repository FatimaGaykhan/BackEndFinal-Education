using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Students
{
	public class StudentEditVM
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Profession { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Description { get; set; }

        public string Image { get; set; }

        public IFormFile NewImage { get; set; }

    }
}

