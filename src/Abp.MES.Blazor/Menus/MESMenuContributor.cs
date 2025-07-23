using System.Threading.Tasks;
using Abp.MES.Localization;
using Abp.MES.Permissions;
using Abp.MES.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace Abp.MES.Blazor.Menus;

public class MESMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<MESResource>();
        
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                MESMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 1
            )
        );

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 6;
    
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        context.Menu.AddItem(
         new ApplicationMenuItem(
             "BooksStore",
             l["Menu:MES"],
             icon: "fa fa-book"
         ).AddItem(
             new ApplicationMenuItem(
                 "BooksStore.Books",
                 l["Menu:Books"],
                 url: "/books"
             ).RequirePermissions(MESPermissions.Books.Default) 
         )
        );

        context.Menu.AddItem(new ApplicationMenuItem(
        "BooksStore.Authors",
        l["Menu:Authors"],
        url: "/authors"
    ).RequirePermissions(MESPermissions.Books.Default));

        return Task.CompletedTask;
    }
}
