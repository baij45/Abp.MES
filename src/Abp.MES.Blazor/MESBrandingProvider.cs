using Microsoft.Extensions.Localization;
using Abp.MES.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.MES.Blazor;

[Dependency(ReplaceServices = true)]
public class MESBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MESResource> _localizer;

    public MESBrandingProvider(IStringLocalizer<MESResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
