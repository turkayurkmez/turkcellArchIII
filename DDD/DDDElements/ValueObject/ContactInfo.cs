using System.Diagnostics.CodeAnalysis;

namespace DDDElements.ValueObject
{
    public class ContactInfo : IEqualityComparer<ContactInfo>
    {
        //Equal pattern burada kullanılmalı. 
        public string Email { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; }

        public bool Equals(ContactInfo? x, ContactInfo? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] ContactInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
