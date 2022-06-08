using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transctionCode, 
            DateTime paidDate, 
            DateTime expireDate,
            decimal total, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Address address, 
            Email email)
            : base (paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            TransctionCode = transctionCode;
        }

        public string TransctionCode { get; private set; }
    }
}    