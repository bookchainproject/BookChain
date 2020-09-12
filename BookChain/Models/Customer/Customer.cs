using System;
using System.ComponentModel.DataAnnotations;

namespace BookChain.Models
{
    public class Customer
    {
        // Unique Key
        [Key]
        public int Id { get; set; }

        // Customer Details
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Microsoft.AspNetCore.Mvc.Remote("IsPhoneAvailable", "Customers")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Birth Date is required")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        // Store Managment
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}
