#pragma checksum "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc357f045350976f353b37c9a219e547945299c"
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
#line 2 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{Id:int}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Adult: </h3>");
#nullable restore
#line 12 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
 if (adultToEdit == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<em>Adult not found!</em>");
#nullable restore
#line 15 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                      adultToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                   Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "tableAdd");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "<td>First Name:</td> ");
                __builder2.OpenElement(14, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                             adultToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.FirstName = __value, adultToEdit.FirstName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "<td> Last Name:</td> ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                             adultToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.LastName = __value, adultToEdit.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "tr");
                __builder2.AddMarkupContent(29, "<td> Hair Color:</td> ");
                __builder2.OpenElement(30, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                               adultToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.HairColor = __value, adultToEdit.HairColor))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "tr");
                __builder2.AddMarkupContent(37, "<td>Eye Color:</td> ");
                __builder2.OpenElement(38, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                            adultToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.EyeColor = __value, adultToEdit.EyeColor))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "tr");
                __builder2.AddMarkupContent(45, "<td> Age:</td>  ");
                __builder2.OpenElement(46, "td");
                __Blazor.BlazorClient.Pages.EditAdult.TypeInference.CreateInputNumber_0(__builder2, 47, 48, 
#nullable restore
#line 26 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                           adultToEdit.Age

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Age = __value, adultToEdit.Age)), 50, () => adultToEdit.Age);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "tr");
                __builder2.AddMarkupContent(53, "<td>Sex:</td>  ");
                __builder2.OpenElement(54, "td");
                __Blazor.BlazorClient.Pages.EditAdult.TypeInference.CreateInputSelect_1(__builder2, 55, 56, 
#nullable restore
#line 27 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                         adultToEdit.Sex

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Sex = __value, adultToEdit.Sex)), 58, () => adultToEdit.Sex, 59, (__builder3) => {
                    __builder3.AddMarkupContent(60, "<option value>Select sex</option>\r\n            ");
                    __builder3.AddMarkupContent(61, "<option value=\"F\">Female</option>\r\n            ");
                    __builder3.AddMarkupContent(62, "<option value=\"M\">Male</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "tr");
                __builder2.AddMarkupContent(65, "<td>  Weight:</td>");
                __builder2.OpenElement(66, "td");
                __Blazor.BlazorClient.Pages.EditAdult.TypeInference.CreateInputNumber_2(__builder2, 67, 68, "1", 69, 
#nullable restore
#line 32 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                                      adultToEdit.Weight

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Weight = __value, adultToEdit.Weight)), 71, () => adultToEdit.Weight);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenElement(73, "tr");
                __builder2.AddMarkupContent(74, "<td>Height:</td>");
                __builder2.OpenElement(75, "td");
                __Blazor.BlazorClient.Pages.EditAdult.TypeInference.CreateInputNumber_3(__builder2, 76, 77, "1", 78, 
#nullable restore
#line 33 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                                   adultToEdit.Height

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Height = __value, adultToEdit.Height)), 80, () => adultToEdit.Height);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenElement(82, "tr");
                __builder2.AddMarkupContent(83, "<td>    Job:</td>");
                __builder2.OpenElement(84, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                         adultToEdit.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.JobTitle.JobTitle = __value, adultToEdit.JobTitle.JobTitle))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.JobTitle.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenElement(90, "tr");
                __builder2.AddMarkupContent(91, "<td>Salary:</td>");
                __builder2.OpenElement(92, "td");
                __Blazor.BlazorClient.Pages.EditAdult.TypeInference.CreateInputNumber_4(__builder2, 93, 94, "1", 95, 
#nullable restore
#line 35 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                                   adultToEdit.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.JobTitle.Salary = __value, adultToEdit.JobTitle.Salary)), 97, () => adultToEdit.JobTitle.Salary);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.OpenElement(99, "tr");
                __builder2.AddMarkupContent(100, "<td><button class=\"btn btn-outline-dark\" type=\"submit\">Save</button></td>");
                __builder2.OpenElement(101, "td");
                __builder2.OpenElement(102, "button");
                __builder2.AddAttribute(103, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(104, "type", "button");
                __builder2.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
                                                                                                                                                        Back

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(106, "Go back");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 39 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\em_du\DNPAssignment2\DNPAssignment2\Assignment1\Pages\EditAdult.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Adult adultToEdit;

    protected override async Task OnInitializedAsync()
    {
        adultToEdit = await AdultData.GetAdultAsync(Id);
    }

    private async Task Save()
    {
        await AdultData.UpdateAdultAsync(adultToEdit);
        NavMgr.NavigateTo("/AdultsList");
    }

    private void Back()
    {
        NavMgr.NavigateTo("/AdultsList");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
namespace __Blazor.BlazorClient.Pages.EditAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
