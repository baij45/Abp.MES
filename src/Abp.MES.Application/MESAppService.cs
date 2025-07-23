using Abp.MES.Localization;
using Volo.Abp.Application.Services;

namespace Abp.MES;

/* Inherit your application services from this class.
 */
public abstract class MESAppService : ApplicationService
{
    protected MESAppService()
    {
        LocalizationResource = typeof(MESResource);
    }
}
