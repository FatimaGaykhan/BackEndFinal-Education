using System;
namespace Back_End_Final_Education.Models
{
	public class CourseImage
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

