using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.MES.Data;

/* This is used if database provider does't define
 * IMESDbSchemaMigrator implementation.
 */
public class NullMESDbSchemaMigrator : IMESDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
