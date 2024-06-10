using System;
namespace Back_End_Final_Education.Models
{
	public class Student:BaseEntity
	{
		public string FullName { get; set; }

		public string Profession { get; set; }

		public string Description { get; set; }

		public string Image { get; set; }
		public List<CourseStudent> CourseStudents { get; set; }

	}
}

