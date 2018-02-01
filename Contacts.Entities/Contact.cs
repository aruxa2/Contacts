using System.Security.AccessControl;

namespace Contacts.Entities
{
    public class Contact:IEntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo{ get; set; }

        public string Image { get; set; }
        public string Email { get; set; }

    }
}
