
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class ShippersConfiguration : EntityTypeConfiguration<Shippers>
    {
        public ShippersConfiguration()
        {
            this.HasMany(e => e.Orders)
                .WithOptional(e => e.Shippers)
                .HasForeignKey(e => e.ShipVia);

        }
    }
}
