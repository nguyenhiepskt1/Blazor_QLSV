#pragma checksum "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108a344beb02e17ffe51f2bda87f1d7e55bd4583"
// <auto-generated/>
#pragma warning disable 1591
namespace QLSVWasm.Pages
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
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
using QLSVWasm.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nganh")]
    public partial class Nganh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ngành</h3>");
#nullable restore
#line 6 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
 if (Nganhs == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<QLSVWasm.Components.Loading>(1);
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                          NganhSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                                                 SearchForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col");
                __builder2.AddMarkupContent(12, "<label>Tên ngành</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                                                                 NganhSearch.TenNganh

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NganhSearch.TenNganh = __value, NganhSearch.TenNganh))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NganhSearch.TenNganh));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.AddMarkupContent(19, "<div class=\"col\" style=\"padding-top:32px\"><button type=\"submit\" class=\"btn btn-primary\">Search</button></div>\r\n                ");
                __builder2.AddMarkupContent(20, "<div class=\"col\" style=\"padding-top:32px\"><a href=\"/nganhCreate\" class=\"btn btn-success\">Thêm mới</a></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row mt-4");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, "<thead><tr><th>\r\n                        Tên ngành\r\n                    </th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 40 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                 foreach (var item in Nganhs)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 43 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                             item.TenNganh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "/nganhDetails/" + (
#nullable restore
#line 45 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddMarkupContent(36, "Chi tiết");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "/nganhEdit/" + (
#nullable restore
#line 46 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                                                 item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-warning");
            __builder.AddMarkupContent(41, "Sửa");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "/nganhEdit/" + (
#nullable restore
#line 47 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                                                 item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddMarkupContent(46, "Xóa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Nganh.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
