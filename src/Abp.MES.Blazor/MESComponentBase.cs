using Abp.MES.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.MES.Blazor;

public abstract class MESComponentBase : AbpComponentBase
{
    protected MESComponentBase()
    {
        LocalizationResource = typeof(MESResource);
    }
}
