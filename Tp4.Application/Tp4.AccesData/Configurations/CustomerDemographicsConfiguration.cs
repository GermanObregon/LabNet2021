
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class CustomerDemographicsConfiguration : EntityTypeConfiguration<CustomerDemographics>
    {
        public CustomerDemographicsConfiguration()
        {
            this.Property(e => e.CustomerTypeID)
                .IsFixedLength();

            this.HasMany(e => e.Customers)
                .WithMany(e => e.CustomerDemographics)
                .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));
        }
        
    }
}
