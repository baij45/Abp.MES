using Abp.MES.Books;
using Xunit;

namespace Abp.MES.EntityFrameworkCore.Applications.Books;

[Collection(MESTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<MESEntityFrameworkCoreTestModule>
{

}