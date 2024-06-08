using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class InstructorViewComponent:ViewComponent
	{
        private readonly IInstructorService _instructorService;

        public InstructorViewComponent(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var instructorDatas = new InstructorVMVC
            {
                Instructors = await _instructorService.GetAllAsync()
            };

            return await Task.FromResult(View(instructorDatas));
        }
    }

    public class InstructorVMVC
    {
        public IEnumerable<Instructor> Instructors { get; set; }

    }
}

