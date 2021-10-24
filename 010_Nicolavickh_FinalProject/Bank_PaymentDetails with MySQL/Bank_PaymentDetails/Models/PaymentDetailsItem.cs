using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_PaymentDetails.Models
{
    public class PaymentDetailsItem
    {
        private Models.PaymentDetailsContext context;

        public int paymentDetailId { get; set; }
        public string cardOwnerName { get; set; }
        public string cardNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public string securityCode { get; set; }
    }
}
