using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using QLSV.Model;
using QLSV.Model.Search;
using QLSVWasm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QLSVWasm.Pages
{
    public partial class SinhVien
    {
        [Inject] private ISinhVienApiClient SinhVienApiClient { set; get; }
        [Inject] private IUserApiClient UserApiClient { set; get; }

        private List<SinhVienDTO> SinhViens;

        private List<UserDTO> Users;

        private SinhVienSearch SinhVienSearch = new SinhVienSearch();
        protected override async Task OnInitializedAsync()
        {
            SinhViens = await SinhVienApiClient.GetSVList(SinhVienSearch);
            Users = await UserApiClient.GetUsers();
        }

        private async Task SearchForm(EditContext context)
        {
            SinhViens = await SinhVienApiClient.GetSVList(SinhVienSearch);
        }
    }
}
