#pragma checksum "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c5702d40efbd39e61ce74f672a40e9339526e8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
using BlazorClient.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddUser")]
    public partial class AddUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddUser</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
                  newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
                                           AddNewUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((b) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n                 ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n                 ");
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "tableAdd");
                __builder2.OpenElement(11, "tr");
                __builder2.AddMarkupContent(12, "<td><label>User name:</label></td> ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "placeholder", "user name");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
                                                                                                                         newUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.UserName = __value, newUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                     ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "<td><label>Password</label></td> ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "password");
                __builder2.AddAttribute(25, "placeholder", "password");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
                                                                                                                          newUser.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.Password = __value, newUser.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                     ");
                __builder2.AddMarkupContent(29, "<tr><td><button class=\"btn btn-outline-dark\" type=\"submit\"> Create</button></td></tr>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\em_du\RiderProjects\DNPAssignment2\Assignment1\Pages\AddUser.razor"
       
        private User newUser = new();

        private async Task AddNewUser()
        {
            await UserService.AddUserAsync(newUser);
            await PerformLogin();
        }
        public async Task PerformLogin()
        {
            var errorMessage = "";
            try
            {
                await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLoginAsync(newUser.UserName, newUser.Password);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
