﻿#pragma checksum "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d1956c6905c82717e0c412c905c2d5fdf1508e1a3f90cef41da017b11e152cb0"
// <auto-generated/>
#pragma warning disable 1591
namespace KroellsManagement.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using KroellsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\_Imports.razor"
using KroellsManagement.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row ps-3 navbar navbar-dark");
            __builder.AddAttribute(2, "b-j3obbz3nl4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-j3obbz3nl4");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href b-j3obbz3nl4>KroellsManagement</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "title", "Navigation menu");
            __builder.AddAttribute(9, "class", "navbar-toggler");
            __builder.AddAttribute(10, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor"
                                                                         ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-j3obbz3nl4");
            __builder.AddMarkupContent(12, "<span class=\"navbar-toggler-icon\" b-j3obbz3nl4></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", 
#nullable restore
#line 10 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-j3obbz3nl4");
            __builder.OpenElement(18, "nav");
            __builder.AddAttribute(19, "class", "flex-column");
            __builder.AddAttribute(20, "b-j3obbz3nl4");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "nav-item px-3");
            __builder.AddAttribute(23, "b-j3obbz3nl4");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", (object)("nav-link"));
            __builder.AddAttribute(26, "href", (object)(""));
            __builder.AddAttribute(27, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-j3obbz3nl4></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "nav-item px-3");
            __builder.AddAttribute(33, "b-j3obbz3nl4");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", (object)("nav-link"));
            __builder.AddAttribute(36, "href", (object)("counter"));
            __builder.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-j3obbz3nl4></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "nav-item px-3");
            __builder.AddAttribute(42, "b-j3obbz3nl4");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", (object)("nav-link"));
            __builder.AddAttribute(45, "href", (object)("fetchdata"));
            __builder.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-j3obbz3nl4></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\zbcyomi\Documents\GitHub\CSharp-School\KroellsManagement\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
