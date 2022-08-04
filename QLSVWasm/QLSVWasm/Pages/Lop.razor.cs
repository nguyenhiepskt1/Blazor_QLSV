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
    public partial class Lop
    {
        [Inject] private ILopApiClient LopApiClient { set; get; }

        private List<LopDTO> Lops;

        private LopSearch LopSearch = new LopSearch();
        protected override async Task OnInitializedAsync()
        {
            Lops = await LopApiClient.GetLopList(LopSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Lops = await LopApiClient.GetLopList(LopSearch);
        }
    }
}
