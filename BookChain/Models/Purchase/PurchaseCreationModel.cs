using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookChain.Models.Purchase
{
    public class PurchaseCreationModel
    {
        // Transaction Details
        [Required(ErrorMessage = "Buyer Phone is required")]
        public string BuyerPhone { get; set; }

        [Required(ErrorMessage = "Book ID is required")]
        public int BookId { get; set; }
    }
}