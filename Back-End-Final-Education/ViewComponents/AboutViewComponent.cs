using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class AboutViewComponent:ViewComponent
	{
        private readonly IAboutService _aboutService;
        private readonly IInformationService _informationService;

        public AboutViewComponent(IAboutService aboutService,
                                 IInformationService informationService)
        {
            _aboutService = aboutService;
            _informationService = informationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = new AboutVMVC
            {
                About = await _aboutService.GetAsync(),
                Informations = await _informationService.GetAllAsync()
            };

            return await Task.FromResult(View(about));
        }
    }

    public class AboutVMVC
    {
        public About About { get; set; }
        public IEnumerable<Information> Informations { get; set; }

    }
}

