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
    public partial class Nganh
    {
        [Inject] private INganhApiClient NganhApiClient { set; get; }

        private List<NganhDTO> Nganhs;

        private NganhSearch NganhSearch = new NganhSearch();
        protected override async Task OnInitializedAsync()
        {
            Nganhs = await NganhApiClient.GetNganhList(NganhSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Nganhs = await NganhApiClient.GetNganhList(NganhSearch);
        }
    }
}
