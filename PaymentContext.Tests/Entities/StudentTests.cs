using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            
            var student = new Student ("Rodrigo", "Oliveira", "43987300001", "r.oliveira.95@hmail.com");
        }
    }
}