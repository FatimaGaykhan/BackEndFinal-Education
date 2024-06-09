using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End_Final_Education.Models
{
	public class Setting
	{
        public int Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

    }
}

