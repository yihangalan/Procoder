﻿using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace ProCoder.Model
{
    public class AdminUser
    {
        //Generated by the system
        [Key]
        public int AdminID { get; set; }

        //Entered by the user
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class AdminValidator : AbstractValidator<AdminUser>
    {
        public AdminValidator()
        {
            // check username is not null, empty and is beteen 1 and 15 characters
            RuleFor(x => x.AdminName).NotNull().NotEmpty().Length(1, 15).WithMessage("Please provide a valid user name.");
            // check password is not null, empty and is beteen 6 and 12 characters
            RuleFor(x => x.Password).NotNull().NotEmpty().Length(6, 12).WithMessage("Please provide a valid password.");
            // check email is not null, empty and is valid email address
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress().WithMessage("Please provide a valid email.");
        }
    }
}
