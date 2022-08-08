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
    public partial class Lop
    {
        [Inject] private ILopApiClient LopApiClient { set; get; }

        protected Confirmation DeleteConfirmation { get; set; }

        private List<LopDTO> Lops;

        private Guid DeleteId { get; set; }

        private LopSearch LopSearch = new LopSearch();
        protected override async Task OnInitializedAsync()
        {
            Lops = await LopApiClient.GetLopList(LopSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Lops = await LopApiClient.GetLopList(LopSearch);
        }
        public void OnDeleteLop(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteLop(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await LopApiClient.DeleteLop(DeleteId);
                Lops = await LopApiClient.GetLopList(LopSearch);
            }
        }
    }
}
