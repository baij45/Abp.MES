using Volo.Abp.Modularity;

namespace Abp.MES;

public abstract class MESApplicationTestBase<TStartupModule> : MESTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
