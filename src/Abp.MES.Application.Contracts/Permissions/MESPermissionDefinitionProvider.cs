using Abp.MES.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Abp.MES.Permissions;

public class MESPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MESPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(MESPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(MESPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(MESPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(MESPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MESPermissions.MyPermission1, L("Permission:MyPermission1"));

        var authorsPermission = myGroup.AddPermission(
    MESPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            MESPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            MESPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            MESPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MESResource>(name);
    }
}
