#pragma checksum "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "655fdd5a14851259b107df641f28008360efb5c3"
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
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
using QLSV.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
using QLSVWasm.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
using QLSVWasm.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/diemEdit/{DiemID}")]
    public partial class DiemEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
 if (Diem == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<QLSVWasm.Components.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Sửa điểm</h3>");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                     Diem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                                          SubmitDiem

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label for=\"HocKy\">Học kỳ</label>\r\n            ");
                __Blazor.QLSVWasm.Pages.Edit.DiemEdit.TypeInference.CreateInputNumber_0(__builder2, 11, 12, "form-control", 13, 
#nullable restore
#line 20 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                                                           Diem.HocKy

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Diem.HocKy = __value, Diem.HocKy)), 15, () => Diem.HocKy);
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<small id=\"HocKyHelp\" class=\"form-text text-muted\">Hãy nhập học kỳ.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"DiemGiuaKy\">Điểm giữa kỳ</label>\r\n            ");
                __Blazor.QLSVWasm.Pages.Edit.DiemEdit.TypeInference.CreateInputNumber_1(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 25 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                                                           Diem.DiemGiuaKy

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Diem.DiemGiuaKy = __value, Diem.DiemGiuaKy)), 26, () => Diem.DiemGiuaKy);
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<small id=\"DiemGiuaKyHelp\" class=\"form-text text-muted\">Hãy nhập điểm giữa kỳ.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"DiemCuoiKy\">Điểm cuối kỳ</label>\r\n            ");
                __Blazor.QLSVWasm.Pages.Edit.DiemEdit.TypeInference.CreateInputNumber_2(__builder2, 33, 34, "form-control", 35, 
#nullable restore
#line 30 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                                                           Diem.DiemCuoiKy

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Diem.DiemCuoiKy = __value, Diem.DiemCuoiKy)), 37, () => Diem.DiemCuoiKy);
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<small id=\"DiemCuoiKyHelp\" class=\"form-text text-muted\">Hãy nhập điểm cuối kỳ.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"DiemTongKet\">Điểm tổng kết</label>\r\n            ");
                __Blazor.QLSVWasm.Pages.Edit.DiemEdit.TypeInference.CreateInputNumber_3(__builder2, 44, 45, "form-control", 46, 
#nullable restore
#line 35 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
                                                           Diem.DiemTongKet

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Diem.DiemTongKet = __value, Diem.DiemTongKet)), 48, () => Diem.DiemTongKet);
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<small id=\"DiemTongKetHelp\" class=\"form-text text-muted\">Hãy nhập điểm tổng kết.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n        ");
                __builder2.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\DiemEdit.razor"
       
    [Parameter]
    public string DiemID { get; set; }

    private DiemUpdateRequest Diem;

    protected override async Task OnInitializedAsync()
    {
        var diemDTO = await DiemApiClient.GetDiemDetail(DiemID);
        Diem = new DiemUpdateRequest();
        Diem.HocKy = diemDTO.HocKy;
        Diem.DiemGiuaKy = diemDTO.DiemGiuaKy;
        Diem.DiemCuoiKy = diemDTO.DiemCuoiKy;
        Diem.DiemTongKet = diemDTO.DiemTongKet;
    }

    private async Task SubmitDiem(EditContext context)
    {
        var result = await DiemApiClient.UpdateDiem(Guid.Parse(DiemID), Diem);
        if (result)
        {
            NavigationManager.NavigateTo("/diem");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDiemApiClient DiemApiClient { get; set; }
    }
}
namespace __Blazor.QLSVWasm.Pages.Edit.DiemEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
