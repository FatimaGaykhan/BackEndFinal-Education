using System;
namespace Back_End_Final_Education.ViewModels.Course
{
	public class CourseDetailVM
	{

        public string Price { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public string Instructor { get; set; }

        public int StudentCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<CourseImageVM> Images { get; set; }

        public String Category { get; set; }


    }
}

