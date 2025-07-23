using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.MES.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MESDbContextFactory : IDesignTimeDbContextFactory<MESDbContext>
{
    public MESDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MESEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MESDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new MESDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Abp.MES.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
