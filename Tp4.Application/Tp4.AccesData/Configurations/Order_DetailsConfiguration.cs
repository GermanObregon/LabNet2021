
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class Order_DetailsConfiguration : EntityTypeConfiguration<Order_Details>
    {
        public Order_DetailsConfiguration()
        {
            this.Property(e => e.UnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
