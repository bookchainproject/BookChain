using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookChain.Models.Purchase
{
    public class PurchaseReceiptModel
    {
        public Purchase RecentPurchase { get; set; }
        public List<Tuple<string, Book>> BookReccomendations { get; set; }
    }
}
