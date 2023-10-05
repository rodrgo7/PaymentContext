using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Naruto", "Uzumaki");
            var document = new Document("35111507795", EDocumentType.CPF);
            var email = new Email("naru.uzumak@jp.com");
            var Student = new Student(name, document, email);
            var subscription = new Subscription(null);

            Assert.Fail();
        }
        public void ShouldReturnSucessWhenHadActiveSubscriptionHasNoPayment()
        {
            var name = new Name("Naruto", "Uzumaki");
            var document = new Document("35111507795", EDocumentType.CPF);
            var email = new Email("naru.uzumak@jp.com");
            var Student = new Student(name, document, email);

            Assert.Fail();
        }
    }
}