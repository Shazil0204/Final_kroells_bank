﻿#pragma checksum "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a15d3d6ae7a26a7dcca22d958acb3fd4ec92dedd9bff333535cf2d635d443073"
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
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddAttribute(6, "style", "text-align:center;");
            __builder.AddMarkupContent(7, "<div id=\"LogoAndText>\" style=\"margin-bottom: 50px;\"><img style=\"height: 450px;\" src=\"/img/FrktLogo.png\"></div>\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "Input");
            __builder.AddMarkupContent(10, "<form name=\"Username\" method=\"post\" style=\"margin-bottom: 5px;\"><input type=\"email\" id=\"username\" placeholder=\"Username\"></form>\r\n    \r\n        ");
            __builder.AddMarkupContent(11, "<form name=\"Password\" method=\"post\"><input type=\"password\" id=\"password\" placeholder=\"Password\"></form>\r\n    \r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "id", "Button");
            __builder.AddAttribute(14, "style", " margin-top: 20px; margin-bottom: 20px;");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
                                                          NavigateToAdmin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, " Sign in ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Pages\Index.razor"
 
    private string sayHi()
    {
        return "hello";
    }

    private void NavigateToAdmin()
    {
        Console.WriteLine("Went to Admin");
        NavigationManager.NavigateTo("/Admin");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
