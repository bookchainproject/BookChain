using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookChain.Models
{
    public class Branch
    {
        // Unique Key
        [Key]
        public int Id { get; set; }

        // Address Details
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "BuildingNumber is required")]
        public int BuildingNumber { get; set; }

        // Branch Info
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Owner is required")]
        public string Owner { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "OpeningHours is required")]
        public string OpeningHours { get; set; }
    }
}
