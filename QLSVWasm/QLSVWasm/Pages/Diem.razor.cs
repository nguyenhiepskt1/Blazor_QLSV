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
    public partial class Diem
    {
        [Inject] private IDiemApiClient DiemApiClient { set; get; }

        protected Confirmation DeleteConfirmation { get; set; }

        private List<DiemDTO> Diems;

        private Guid DeleteId { get; set; }

        private DiemSearch DiemSearch = new DiemSearch();
        protected override async Task OnInitializedAsync()
        {
            Diems = await DiemApiClient.GetDiemList(DiemSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            Diems = await DiemApiClient.GetDiemList(DiemSearch);
        }

        public void OnDeleteDiem(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteDiem(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await DiemApiClient.DeleteDiem(DeleteId);
                Diems = await DiemApiClient.GetDiemList(DiemSearch);
            }
        }
    }
}
