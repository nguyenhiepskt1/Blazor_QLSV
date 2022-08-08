using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using QLSV.Model;
using QLSV.Model.Search;
using QLSVWasm.Components;
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

        protected Confirmation DeleteConfirmation { get; set; }

        private List<NganhDTO> Nganhs;
        private Guid DeleteId { get; set; }

        private NganhSearch NganhSearch = new NganhSearch();
        protected override async Task OnInitializedAsync()
        {
            Nganhs = await NganhApiClient.GetNganhList(NganhSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Nganhs = await NganhApiClient.GetNganhList(NganhSearch);
        }

        public void OnDeleteNganh(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteNganh(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await NganhApiClient.DeleteNganh(DeleteId);
                Nganhs = await NganhApiClient.GetNganhList(NganhSearch);
            }
        }
    }
}
