using Xunit;

namespace Abp.MES.EntityFrameworkCore;

[CollectionDefinition(MESTestConsts.CollectionDefinitionName)]
public class MESEntityFrameworkCoreCollection : ICollectionFixture<MESEntityFrameworkCoreFixture>
{

}
