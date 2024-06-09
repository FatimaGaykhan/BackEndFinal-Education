using System;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class FooterViewComponent:ViewComponent
	{
        private readonly ISettingService _settingService;

        public FooterViewComponent(ISettingService settingService)
        {
            _settingService = settingService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerDatas = new FooterVMVC
            {
                SettingDatas = await _settingService.GetAllAsync(),
            };

            return await Task.FromResult(View(footerDatas));
        }
    }

    public class FooterVMVC
    {
        public IDictionary<string, string> SettingDatas { get; set; }


    }
}

