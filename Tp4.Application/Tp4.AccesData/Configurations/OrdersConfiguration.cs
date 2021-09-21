
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class OrdersConfiguration : EntityTypeConfiguration<Orders>
    {
        public OrdersConfiguration()
        {
            this.Property(e => e.CustomerID)
                .IsFixedLength();

            this.Property(e => e.Freight)
                .HasPrecision(19, 4);

            this.HasMany(e => e.Order_Details)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);
        }
    }
}
