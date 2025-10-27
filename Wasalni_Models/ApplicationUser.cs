using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Wasalni_Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber {  get; set; }
        [Required]
        public int HomeLocationId { get; set; }
        [ForeignKey(nameof(HomeLocationId))]
        public Location HomeLocation { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public UserType UserType { get; set; }
    }
}
