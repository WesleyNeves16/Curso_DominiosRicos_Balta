using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green & Refactor
        // Red: Fazer o teste falhar
        // Green: Fazer o teste passar
        // Refactor: Refatorar o código
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(!doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("11111111000111", EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(!doc.IsValid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("22222222222")]
        [DataRow("33333333333")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.IsValid);
        }
    }
}