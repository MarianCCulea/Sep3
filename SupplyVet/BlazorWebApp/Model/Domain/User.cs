using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Model.Domain
{
    public class User
    {

        public int id { get; set; }
      
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "No special characters allowed.")]
        public string username { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "No numbers or special characters allowed.")]
        [Required]
        [StringLength(30)]
        public string fullname { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public string role { get; set; }
        public List<Order> orders { get; set; }
        [Required]
        public int vetid { get; set; }
    }
}
