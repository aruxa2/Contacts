using Contacts.Entities;

namespace Contacts.Data
{
    public class ContactConfiguration:EntityBaseConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);
            Property(c => c.Email).HasMaxLength(70);
            Property(c => c.Image);
            Property(c => c.PhoneNo).HasMaxLength(14);
        }
    }
}
