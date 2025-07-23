using Abp.MES.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.MES.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MESController : AbpControllerBase
{
    protected MESController()
    {
        LocalizationResource = typeof(MESResource);
    }
}
