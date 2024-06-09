using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class CourseViewComponent:ViewComponent
	{
		private readonly ICourseService _courseService;

		public CourseViewComponent(ICourseService courseService)
		{
			_courseService = courseService;
		}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var courseDatas = new CourseVMVC
            {
                Courses = await _courseService.GetAllAsync()
            };

            return await Task.FromResult(View(courseDatas));
        }
    }
    public class CourseVMVC
    {
        public IEnumerable<Course> Courses { get; set; }

    }
}

