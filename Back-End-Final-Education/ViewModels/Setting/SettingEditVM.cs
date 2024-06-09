using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Setting
{
	public class SettingEditVM
	{
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }

	}
}

