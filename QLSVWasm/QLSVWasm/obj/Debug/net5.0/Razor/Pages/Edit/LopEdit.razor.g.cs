#pragma checksum "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c5276705d23b9d787791f4ac9a2b67c0b561ff5"
// <auto-generated/>
#pragma warning disable 1591
namespace QLSVWasm.Pages.Edit
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
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
using QLSV.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
using QLSVWasm.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
using QLSVWasm.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lopEdit/{LopID}")]
    public partial class LopEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
 if (Lop == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<QLSVWasm.Components.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddMarkupContent(2, "Sửa lớp : ");
            __builder.AddContent(3, 
#nullable restore
#line 14 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
                   Lop.TenLop

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
                     Lop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
                                         SubmitLop

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"TenLop\">Tên lớp</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
                                                         Lop.TenLop

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Lop.TenLop = __value, Lop.TenLop))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Lop.TenLop));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.QLSVWasm.Pages.Edit.LopEdit.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 21 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
                                    ()=>Lop.TenLop

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.AddMarkupContent(22, "<small id=\"TenLopHelp\" class=\"form-text text-muted\">Hãy nhập tên lớp.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.AddMarkupContent(24, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\LopEdit.razor"
       
    [Parameter]
    public string LopID { get; set; }

    private LopUpdateRequest Lop;

    protected override async Task OnInitializedAsync()
    {
        var lopDTO = await LopApiClient.GetLopDetail(LopID);
        Lop = new LopUpdateRequest();
        Lop.TenLop = lopDTO.TenLop;
    }

    private async Task SubmitLop(EditContext context)
    {
        var result = await LopApiClient.UpdateLop(Guid.Parse(LopID), Lop);
        if (result)
        {
            NavigationManager.NavigateTo("/lop");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILopApiClient LopApiClient { get; set; }
    }
}
namespace __Blazor.QLSVWasm.Pages.Edit.LopEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
