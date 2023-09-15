namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public Subscription(DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, bool active, List<Payment> payments)
        {
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Active = active;
            Payments = payments;
        }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active {get; set; }
        public List<Payment> Payments {get; set;}
    }
}