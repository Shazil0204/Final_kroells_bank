﻿#pragma checksum "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4482258caa8314cf5944e11f8facf486f1bda07ed8ca04ce2fa5600ae8abc0d8"
// <auto-generated/>
#pragma warning disable 1591
namespace KroellsManagement.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using KroellsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\_Imports.razor"
using KroellsManagement.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Management Login");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex align-items-center justify-content-center vh-100");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddAttribute(8, "style", "width:700px; height:600px; text-align:center; box-shadow: 5px 5px 10px rgba(0,0,0,0.3); border-radius: 10px;");
            __builder.AddMarkupContent(9, "<div id=\"LogoAndText\" style=\"margin-bottom: 10px;\"><img style=\"height: 450px;\" src=\"/img/FrktLogo.png\"></div>\r\n\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "Input");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "name", (object)("Input"));
            __builder.AddAttribute(14, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                           database

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "method", (object)("post"));
            __builder.AddAttribute(16, "style", (object)("margin-bottom: 5px;"));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "type", (object)("text"));
                __builder2.AddAttribute(20, "id", (object)("username"));
                __builder2.AddAttribute(21, "placeholder", (object)("Username"));
                __builder2.AddAttribute(22, "style", (object)(" margin-bottom: 3px"));
                __builder2.AddAttribute(23, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                        database.Username

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => database.Username = __value, database.Username)))));
                __builder2.AddAttribute(25, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => database.Username)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, " <br>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "type", (object)("password"));
                __builder2.AddAttribute(29, "id", (object)("password"));
                __builder2.AddAttribute(30, "placeholder", (object)("Password"));
                __builder2.AddAttribute(31, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                        database.Password

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(32, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => database.Password = __value, database.Password)))));
                __builder2.AddAttribute(33, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => database.Password)));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n    \r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "id", "Button");
            __builder.AddAttribute(37, "style", "margin-top: 20px;");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "submit");
            __builder.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                                SignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddContent(42, " Sign in ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
 
    Data.Database database = new Data.Database();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
    
    private async Task SignIn()
    {
        sbyte isAuthenticated = await database.DBConnection();
        
        if (isAuthenticated == 1)
        {
            NavigationManager.NavigateTo("/test", true);
        }
        else
        {
          
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
