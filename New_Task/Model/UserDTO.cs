using System;
using System.ComponentModel.DataAnnotations;

namespace New_Task.Model
{
	public class UserDTO
	{
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Range(20,30)]
        public int Age { get; set; }

    }
}

