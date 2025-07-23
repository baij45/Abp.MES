using Abp.MES.Samples;
using Xunit;

namespace Abp.MES.EntityFrameworkCore.Applications;

[Collection(MESTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MESEntityFrameworkCoreTestModule>
{

}
