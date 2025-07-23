using Volo.Abp.Modularity;

namespace Abp.MES;

[DependsOn(
    typeof(MESDomainModule),
    typeof(MESTestBaseModule)
)]
public class MESDomainTestModule : AbpModule
{

}
