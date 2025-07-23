using System.Threading.Tasks;

namespace Abp.MES.Data;

public interface IMESDbSchemaMigrator
{
    Task MigrateAsync();
}
