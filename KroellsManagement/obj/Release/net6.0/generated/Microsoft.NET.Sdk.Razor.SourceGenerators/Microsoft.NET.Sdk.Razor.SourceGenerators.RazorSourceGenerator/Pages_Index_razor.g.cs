﻿#pragma checksum "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6b70f56c146c9e1b7f5b12cad7a587b07a8fec3ceb61367b2e72d0dd400429b0"
// <auto-generated/>
#pragma warning disable 1591
namespace KroellsManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
using KroellsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\_Imports.razor"
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
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "body");
            __builder.AddAttribute(5, "class", "background");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "loginBody");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "<div id=\"LogoAndText\"><img src=\"/img/FrktLogo.png\"></div>\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "Input");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "name", (object)("Input"));
            __builder.AddAttribute(15, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                               db

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "method", (object)("post"));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "type", (object)("text"));
                __builder2.AddAttribute(20, "id", (object)("username"));
                __builder2.AddAttribute(21, "placeholder", (object)("Username"));
                __builder2.AddAttribute(22, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                            db.login.Username

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(23, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => db.login.Username = __value, db.login.Username)))));
                __builder2.AddAttribute(24, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => db.login.Username)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    <br>\r\n                    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "type", (object)("password"));
                __builder2.AddAttribute(28, "id", (object)("password"));
                __builder2.AddAttribute(29, "placeholder", (object)("Password"));
                __builder2.AddAttribute(30, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 15 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                            db.login.Password

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => db.login.Password = __value, db.login.Password)))));
                __builder2.AddAttribute(32, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => db.login.Password)));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "id", "Button");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "submit");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                                    SignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "button");
            __builder.AddContent(40, "Sign in");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.AddMarkupContent(42, "<div id=\"EmployeeError\"><p>Something Wrong With The Input</p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
 
    Classes.Model.Database db = new Classes.Model.Database();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
    
    // 1. Add a boolean field to track the visibility of EmployeeError
    private bool showError = false;
    
    private async Task SignIn()
    {
        sbyte isAuthenticated = await db.DBConnection();
        Console.WriteLine(isAuthenticated);
        if (isAuthenticated == 1)
        {
            NavigationManager.NavigateTo("/admin", false);
        }
        else if (isAuthenticated == -1)
        {
            LoginError();
        }  // i have to make more if statements for each error
    }

    private void LoginError()  // i have to make more methods for each if statement
    {
        // 3. Set showError to true to make the EmployeeError div visible
        showError = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
