using Abp.MES.Samples;
using Xunit;

namespace Abp.MES.EntityFrameworkCore.Domains;

[Collection(MESTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MESEntityFrameworkCoreTestModule>
{

}
