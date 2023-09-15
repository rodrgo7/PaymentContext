namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public Student(string firstName,  string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            // Caso haja uma assinatura ativa, cancela
            // Cancela todas as outras as asinaturas e coloca essa como PRINCIPAL

            foreach (var sub in Subscriptions)
            {
                sub.Active = false;
            }

            _subscriptions.Add(subscription);
        }
    }
}