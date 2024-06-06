using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.Models
{
	public class Slider:BaseEntity
	{
        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

		public string Image { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }


	}
}

