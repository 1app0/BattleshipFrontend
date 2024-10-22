#pragma checksum "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\Instructions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef863fc69819454d248d1252adfc17de8e97c41"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BattleShipFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BattleShipFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BattleShipFrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\Instructions.razor"
using BattleShipFrontEnd.Data.BattleshipData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Instructions")]
    public partial class Instructions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\Instructions.razor"
 
    private bool isGameSaved;
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    
    
    protected override async Task OnInitializedAsync() {
        var authState = await authenticationStateTask;
        var user = authState.User;
        string username = user.Identity.Name;
        isGameSaved = await BattleShipAccess.CheckForSavedGame(username);
    }

    public async Task StartNewGameDeleteSaveAsync() {
        var authState = await authenticationStateTask;
        var user = authState.User;
        string username = user.Identity.Name;
        await BattleShipAccess.DeleteSave(username);
        NavigationManager.NavigateTo("/Game");
    }
    
    public void StartNewGameAsync() {
        NavigationManager.NavigateTo("/Game");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudBattleShipAccess BattleShipAccess { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
