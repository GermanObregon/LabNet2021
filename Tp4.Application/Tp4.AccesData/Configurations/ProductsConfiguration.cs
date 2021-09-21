
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class ProductsConfiguration : EntityTypeConfiguration<Products>
    {
        public ProductsConfiguration()
        {
            this.Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            this.HasMany(e => e.Order_Details)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);
        }
    }
}
