using System;
namespace Back_End_Final_Education.Models
{
	public class Instructor:BaseEntity
	{
		public string FullName { get; set; }

		public string Image { get; set; }

		public string Position { get; set; }

		public List<InstructorSocialMedia> InstructorSocialMedias { get; set; }


	}
}

