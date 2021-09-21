
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            this.Property(e => e.RegionDescription)
                .IsFixedLength();

            this.HasMany(e => e.Territories)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);
        }
    }
}
