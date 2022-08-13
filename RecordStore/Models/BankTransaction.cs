using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public partial class BankTransaction
    {
        public Guid UserId { get; set; }
        public float NewWalletAmount { get; set; }
        public Guid TransactionNumber { get; set; }
        public string TransactionDescription { get; set; } = null!;
        public float TransactionAmount { get; set; } 
        public DateTime TransactionDate { get; set; }
        public string TransactionLocation { get; set; }
    }
}
