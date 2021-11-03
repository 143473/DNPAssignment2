// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditUser.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditUser.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditUser.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditUser.razor"
           [Authorize(Policy = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditUser/{Id:int}")]
    public partial class EditUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditUser.razor"
       

    [Parameter]
    public int Id { get; set; }

    private User userToEdit;

    protected override async Task OnInitializedAsync()
    {
        userToEdit = await UserService.GetUserAsync(Id);
    }

    private async Task Save()
    {
        await UserService.UpdateUserAsync(userToEdit);
        NavMgr.NavigateTo("/UsersList");
    }

    private void Back()
    {
        NavMgr.NavigateTo("/UsersList");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
    }
}
#pragma warning restore 1591
