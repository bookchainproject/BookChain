using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookChain.Models.Purchase
{
    public class PurchaseModel
    {
        // Transaction Details
        public string BuyerName { get; set; }
        public string BuyerPhone { get; set; }
        public string BookTitle { get; set; }
        public int PaidPrice { get; set; }

        // Order Details
        public string SellerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}