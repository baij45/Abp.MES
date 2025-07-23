using Volo.Abp.Modularity;

namespace Abp.MES;

[DependsOn(
    typeof(MESApplicationModule),
    typeof(MESDomainTestModule)
)]
public class MESApplicationTestModule : AbpModule
{

}
