using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookChain.Models.Worker
{
    public class Worker: IdentityUser<int>
    {
        // Worker Details
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Microsoft.AspNetCore.Mvc.Remote("IsPhoneAvailable", "Workers")]
        public string Phone { get; set; }

        // Store Managment
        public int Salary { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ResignationDate { get; set; }
    }
}
