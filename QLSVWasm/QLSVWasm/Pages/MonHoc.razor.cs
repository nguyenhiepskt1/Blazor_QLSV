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
    public partial class MonHoc
    {
        [Inject] private IMonHocApiClient MonHocApiClient { set; get; }

        protected Confirmation DeleteConfirmation { get; set; }

        private List<MonHocDTO> MonHocs;
        private Guid DeleteId { get; set; }

        private MonHocSearch MonHocSearch = new MonHocSearch();
        protected override async Task OnInitializedAsync()
        {
            MonHocs = await MonHocApiClient.GetMonHocList(MonHocSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            MonHocs = await MonHocApiClient.GetMonHocList(MonHocSearch);
        }

        public void OnDeleteMonHoc(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteMonHoc(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await MonHocApiClient.DeleteMonHoc(DeleteId);
                MonHocs = await MonHocApiClient.GetMonHocList(MonHocSearch);
            }
        }
    }
}
