﻿#pragma checksum "C:\Users\zbcyomi\Documents\GitHub\Final_kroells_bank\KroellsManagement\Pages\Counter.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1f2905aface9dce0b3d715742d0455123bb77dc00358a06c2b68d592a9f99d49"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Counter");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Counter</h1>\r\n\r\n \r\n");
            __builder.AddMarkupContent(5, @"<body style=""display: flex; justify-content:center; align-items:center; min-height:100vh; margin:0;""><div class=""container"" style=""border: 1px solid blue;""><div class=""col-md-10"" style=""border: 1px solid black;"">
            col 1
        </div>
        <div class=""col-md-10"" style=""border: 1px solid black;"">
            col 2
        </div></div></body>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591