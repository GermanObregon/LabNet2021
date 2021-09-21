
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class TerritoriesConfiguration : EntityTypeConfiguration<Territories>
    {
        public TerritoriesConfiguration()
        {
            this.Property(e => e.TerritoryDescription)
                .IsFixedLength();
        }
    }
}
