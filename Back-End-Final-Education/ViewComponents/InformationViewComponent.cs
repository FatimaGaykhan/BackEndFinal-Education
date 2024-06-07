using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class InformationViewComponent:ViewComponent
	{
        private readonly IInformationService _infoService;

        public InformationViewComponent(IInformationService infoService)
        {
            _infoService = infoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var infoDatas = new InfoVMVC
            {
                Informations = await _infoService.GetAllAsync()
            };

            return await Task.FromResult(View(infoDatas));
        }
    }

    public class InfoVMVC
    {
        public IEnumerable<Information> Informations { get; set; }

    }
}

