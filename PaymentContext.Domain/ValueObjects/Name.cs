using Flunt.Validations;
using PaymentContext.Domain.Entities;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Student>()
                .Requires()
                .IsLowerThan(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsLowerThan(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                );

            if (string.IsNullOrEmpty(firstName))
            {
                AddNotification("Name.FirstName", "Nome inválido");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                AddNotification("Name.LastName", "Sobrenome inválido");
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
