using System.Collections.Generic;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student(string firstName, string lastName, string document, string email, string address) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Document = document;
            this.Email = email;
            this.Address = address;               
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }        
        public string Address { get; set; }
        public List<Subscription> Subscription { get; set; }
    }
}