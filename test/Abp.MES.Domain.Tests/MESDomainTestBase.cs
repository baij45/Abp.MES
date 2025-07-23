using Volo.Abp.Modularity;

namespace Abp.MES;

/* Inherit from this class for your domain layer tests. */
public abstract class MESDomainTestBase<TStartupModule> : MESTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
