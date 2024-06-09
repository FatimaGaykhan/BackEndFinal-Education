using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Course
{
	public class CourseEditVM
	{
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public int Rating { get; set; }

        public int CategoryId { get; set; }

        public int InstructorId { get; set; }

        public List<IFormFile> NewImages { get; set; }

        public List<CourseImageEditVM> ExistImages { get; set; }
    }
}

