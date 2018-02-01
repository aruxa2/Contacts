using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Contacts.Entities;


namespace Contacts.Data
{
    public class ContactsContext: DbContext
    {
        public ContactsContext()
            :base("Contacts")
        {
            Database.SetInitializer<ContactsContext>(null);
        }

        //public IDbSet<Contact> ContactSet { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ContactConfiguration());
        }

        public DbSet<Contacts.Entities.Contact> Contacts { get; set; }
    }
}
