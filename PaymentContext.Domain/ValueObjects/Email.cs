using Flunt.Validations;
using PaymentContext.Domain.Entities;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract<Student>()
                .Requires()
                .IsEmail(Address, "Email.Address", "Email inválido")
            );
        }
        public string Address { get; private set; }
    }
}
