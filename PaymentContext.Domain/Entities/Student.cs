using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        
        public Name Name { get; private set; }
        public string LastName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public Student(Name name, Document document, Email email)
        {
            Name = name;
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
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    }
}