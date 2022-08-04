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
    public partial class MonHoc
    {
        [Inject] private IMonHocApiClient MonHocApiClient { set; get; }

        private List<MonHocDTO> MonHocs;

        private MonHocSearch MonHocSearch = new MonHocSearch();
        protected override async Task OnInitializedAsync()
        {
            MonHocs = await MonHocApiClient.GetMonHocList(MonHocSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            MonHocs = await MonHocApiClient.GetMonHocList(MonHocSearch);
        }
    }
}
