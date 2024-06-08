using System;
using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Education.ViewModels.Instructor
{
	public class InstructorEditVM
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Position { get; set; }


        public string Image { get; set; }

        public IFormFile NewImage { get; set; }

        public List<InstructorSocialMediaLinkVM> SocialMediaLinks { get; set; }


        //public int SocialMediaId { get; set; }

        //public string Link { get; set; }


    }
}

