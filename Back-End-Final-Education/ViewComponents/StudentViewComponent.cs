using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class StudentViewComponent:ViewComponent
	{
        private readonly IStudentService _studentService;

        public StudentViewComponent(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var studentDatas = new StudentVMVC
            {
                Students = await _studentService.GetAllAsync()
            };

            return await Task.FromResult(View(studentDatas));
        }
    }
    public class StudentVMVC
    {
        public IEnumerable<Student> Students { get; set; }

    }
}

