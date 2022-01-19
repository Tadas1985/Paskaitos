using System;

namespace Models
{
    public struct Invoice
    {
        public string Receiver { get; }
        public string Sender { get; }
        public decimal Amount { get; }
        //public int AcountNUmber;

        public Invoice(string receiver, string sender, decimal amount)
        {
            Receiver = receiver;
            Sender = sender;
            Amount = amount;
           // AcountNUmber = acountNUmber;

        }
    }
}
