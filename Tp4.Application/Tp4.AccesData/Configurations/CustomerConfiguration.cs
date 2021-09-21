
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customers>
    {
        public CustomerConfiguration()
        {
           this.Property(e => e.CustomerID)
               .IsFixedLength();
        }
    }
}
