using System;
namespace Back_End_Final_Education.ViewModels.Course
{
	public class CourseImageEditVM
	{
        public int Id { get; set; }

        public int CourseId { get; set; }

        public string Image { get; set; }

        public bool IsMain { get; set; }
    }
}

