using System;
namespace Back_End_Final_Education.Models
{
	public class Category:BaseEntity
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public IEnumerable<Course> Courses { get; set; }

	}
}

