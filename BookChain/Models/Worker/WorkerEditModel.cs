using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace BookChain.Models.Worker
{
    public class WorkerEditModel
    {
        // Worker Details
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        // Store Managment
        [Required(ErrorMessage = "Salary is required")]
        public int Salary { get; set; }

        // UserIdentity Details
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}