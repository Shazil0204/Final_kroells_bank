﻿#pragma checksum "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01fa7a19f14796ec531124d5bee81e40bb2edd983df4a54d236b00e67d58dc23"
// <auto-generated/>
#pragma warning disable 1591
namespace KroellsManagement
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
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor"
                      typeof(App).Assembly

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(3);
                __builder2.AddAttribute(4, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(5, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 3 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>(7);
                __builder2.AddAttribute(8, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor"
                                     routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "Selector", (object)("h1"));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(11);
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Not found");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(15);
                __builder2.AddAttribute(16, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 8 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<p role=\"alert\">Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
