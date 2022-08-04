using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public class LopApiClient : ILopApiClient
    {
        public HttpClient _httpClient;

        public LopApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateLop(LopCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/lops", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<LopDTO> GetLopDetail(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<LopDTO>($"/api/lops/{id}");
            return result;
        }

        public async Task<List<LopDTO>> GetLopList(LopSearch lopSearch)
        {
            string url = $"/api/lops?tenlop={lopSearch.TenLop}";
            var result = await _httpClient.GetFromJsonAsync<List<LopDTO>>(url);
            return result;
        }

        public async Task<bool> UpdateLop(Guid id, LopUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/lops/{id}", request);
            return result.IsSuccessStatusCode;
        }
    }
}
