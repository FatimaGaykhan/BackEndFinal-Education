using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class CategoryViewComponent:ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public CategoryViewComponent(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryDatas = new CategoryVMVC
            {
               Categories = await _categoryService.GetAllAsync()
            };

            return await Task.FromResult(View(categoryDatas));
        }
    }

    public class CategoryVMVC
    {
        public IEnumerable<Category> Categories { get; set; }

    }
}

