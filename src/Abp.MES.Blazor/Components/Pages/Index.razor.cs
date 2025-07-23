using Microsoft.AspNetCore.Components;

namespace Abp.MES.Blazor.Components.Pages;


public partial class Index
{
    [Inject]
    protected NavigationManager Navigation { get; set; } = default!;

    private void Login()
    {
        Navigation.NavigateTo("/Account/Login", true);
    }
}
