using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using Restourant.Manager.Configuration;
using Restourant.Manager.Web;

using Service.Employee.EntityFramework;

namespace Restourant.Manager.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ManagerDbContextFactory : IDesignTimeDbContextFactory<EmployeeDbContext>
    {
        public EmployeeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EmployeeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ManagerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ManagerConsts.ConnectionStringName));

            return new EmployeeDbContext(builder.Options);
        }
    }
}
