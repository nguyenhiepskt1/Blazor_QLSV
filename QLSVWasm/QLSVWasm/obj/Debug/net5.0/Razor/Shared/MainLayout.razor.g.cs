#pragma checksum "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39abbb80a9d0f9f0d641e5e6882f182f2734e631"
// <auto-generated/>
#pragma warning disable 1591
namespace QLSVWasm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using QLSVWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using QLSVWasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 5 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
                          ToastPosition.TopRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
                         5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 7 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
                          IconType.Material

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ErrorIcon", "error_outline");
            __builder.AddAttribute(5, "InfoIcon", "school");
            __builder.AddAttribute(6, "SuccessIcon", "done_outline");
            __builder.AddAttribute(7, "WarningIcon", "warning");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "page");
            __builder.AddAttribute(11, "b-9yrr0ziel9");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "sidebar");
            __builder.AddAttribute(14, "b-9yrr0ziel9");
            __builder.OpenComponent<QLSVWasm.Shared.NavMenu>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "main");
            __builder.AddAttribute(19, "b-9yrr0ziel9");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "top-row px-4");
            __builder.AddAttribute(22, "b-9yrr0ziel9");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                    Hello, ");
                __builder2.AddContent(26, 
#nullable restore
#line 22 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
                            context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.AddMarkupContent(28, "<a href=\"/logout\" b-9yrr0ziel9>Logout</a>");
            }
            ));
            __builder.AddAttribute(29, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "<a href=\"/login\" class=\"ml-md-auto\" b-9yrr0ziel9>????ng nh???p</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "          \r\n\r\n            ");
            __builder.AddMarkupContent(32, "<a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-9yrr0ziel9>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "content px-4");
            __builder.AddAttribute(36, "b-9yrr0ziel9");
            __builder.AddContent(37, 
#nullable restore
#line 34 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
