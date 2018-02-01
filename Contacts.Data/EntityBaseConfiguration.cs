using System.Data.Entity.ModelConfiguration;
using Contacts.Entities;

namespace Contacts.Data
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(i => i.Id);
        }
    }
}