using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.Models
{
	public class Information:BaseEntity
	{
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public Icon Icon { get; set; }

        public int IconId { get; set; }




    }
}

