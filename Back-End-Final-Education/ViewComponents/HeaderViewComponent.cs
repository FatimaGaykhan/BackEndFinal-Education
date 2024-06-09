using System;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
        private readonly ISettingService _settingService;

        public HeaderViewComponent(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, string> settings = await _settingService.GetAllAsync();

            HeaderVMVC response = new()
            {
                Settings = settings,
            };

            return await Task.FromResult(View(response));


        }
    }

    public class HeaderVMVC
    {

        public Dictionary<string, string> Settings { get; set; }

    }
}

