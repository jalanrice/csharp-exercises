using C9UserSignup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C9UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        public static bool VerifyPassword(string username, string verify )
        {
            return UserData.VerifyPassword(username, verify);
        }

        public User  CreateUser (AddUserViewModel addUserViewModel)
        {
            User newUser = new User
            {
                Username = addUserViewModel.Username,
                Email = addUserViewModel.Email,
                Password = addUserViewModel.Password,

            };

            return newUser;

        }

    }
}
