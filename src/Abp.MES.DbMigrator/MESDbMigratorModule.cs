using Abp.MES.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.MES.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MESEntityFrameworkCoreModule),
    typeof(MESApplicationContractsModule)
)]
public class MESDbMigratorModule : AbpModule
{
}
