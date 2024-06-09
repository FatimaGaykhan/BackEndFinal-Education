using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Course
{
	public class CourseCreateVM
	{
		[Required]
		public string Name { get; set; }

        [Required]
        public int InstructorId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public List<IFormFile> Images { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string Description { get; set; }



	}
}

