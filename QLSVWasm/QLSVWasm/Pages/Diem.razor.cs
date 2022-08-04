using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using QLSV.Model;
using QLSV.Model.Search;
using QLSVWasm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Pages
{
    public partial class Diem
    {
        [Inject] private IDiemApiClient DiemApiClient { set; get; }

        private List<DiemDTO> Diems;

        private DiemSearch DiemSearch = new DiemSearch();
        protected override async Task OnInitializedAsync()
        {
            Diems = await DiemApiClient.GetDiemList(DiemSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Diems = await DiemApiClient.GetDiemList(DiemSearch);
        }
    }
}
