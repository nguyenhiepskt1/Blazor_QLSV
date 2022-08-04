// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\SinhVienEdit.razor"
using QLSV.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\SinhVienEdit.razor"
using QLSVWasm.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\SinhVienEdit.razor"
using QLSVWasm.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sinhvienEdit/{SinhVienID}")]
    public partial class SinhVienEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\nguye\Desktop\Project C#6\QLSVWasm\QLSVWasm\Pages\Edit\SinhVienEdit.razor"
       
    [Parameter]
    public string SinhVienID { get; set; }

    private SinhVienUpdateRequest SinhVien;

    protected override async Task OnInitializedAsync()
    {
        var sinhVienDTO = await SinhVienApiClient.GetSVDetail(SinhVienID);
        SinhVien = new SinhVienUpdateRequest();
        SinhVien.TenSinhVien = sinhVienDTO.TenSinhVien;
        SinhVien.Tuoi = sinhVienDTO.Tuoi;
        SinhVien.DiaChi = sinhVienDTO.DiaChi;
        SinhVien.Email = sinhVienDTO.Email;
        SinhVien.SDT = sinhVienDTO.SDT;
        SinhVien.GioiTinh = sinhVienDTO.GioiTinh;
    }

    private async Task SubmitSinhVien(EditContext context)
    {
        var result = await SinhVienApiClient.UpdateSV(Guid.Parse(SinhVienID), SinhVien);
        if (result)
        {
            NavigationManager.NavigateTo("/sinhvien");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISinhVienApiClient SinhVienApiClient { get; set; }
    }
}
#pragma warning restore 1591
