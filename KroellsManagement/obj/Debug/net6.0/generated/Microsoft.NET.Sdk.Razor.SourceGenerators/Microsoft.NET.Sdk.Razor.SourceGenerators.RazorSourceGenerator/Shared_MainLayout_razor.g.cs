﻿#pragma checksum "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4a164fe101569211fb5bd0c18cb509f01c8196877e31318e1931172f196eb116"
// <auto-generated/>
#pragma warning disable 1591
namespace KroellsManagement.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "KroellsManagement");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-40zir6ouz6");
            __builder.OpenElement(7, "main");
            __builder.AddAttribute(8, "b-40zir6ouz6");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\" style=\"text-align: center; display: flex; justify-content: center; align-items: center;\" b-40zir6ouz6>\r\n            Login Page\r\n        </div>\r\n\r\n\r\n        ");
            __builder.OpenElement(10, "article");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddAttribute(12, "b-40zir6ouz6");
#nullable restore
#line (18,14)-(18,18) 25 "C:\Users\magnu\source\repos\Final_kroells_bank\KroellsManagement\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
