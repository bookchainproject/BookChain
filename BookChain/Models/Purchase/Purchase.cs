using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookChain.Models.Purchase
{
    public class Purchase
    {
        // Unique Key
        [Key]
        public int Id { get; set; }

        // Transaction Details
        public int BuyerId { get; set; }
        public virtual Customer Buyer { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int PaidPrice { get; set; }

        // Order Details
        public int SellerId { get; set; }
        public virtual Worker.Worker Seller { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}