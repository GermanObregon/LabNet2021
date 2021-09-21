
using System.Data.Entity.ModelConfiguration;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Configurations
{
    public class EmployeesConfiguration : EntityTypeConfiguration<Employees>
    {
        public EmployeesConfiguration()
        {
            this.HasMany(e => e.Employees1)
                .WithOptional(e => e.Employees2)
                .HasForeignKey(e => e.ReportsTo);

            this.HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));
        }
    }
}
