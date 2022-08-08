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
    public class NganhApiClient : INganhApiClient
    {
        public HttpClient _httpClient;

        public NganhApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateNganh(NganhCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/nganhs", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteNganh(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/nganhs/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<NganhDTO> GetNganhDetail(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<NganhDTO>($"/api/nganhs/{id}");
            return result;
        }

        public async Task<List<NganhDTO>> GetNganhList(NganhSearch nganhSearch)
        {
            string url = $"/api/nganhs?tennganh={nganhSearch.TenNganh}";
            var result = await _httpClient.GetFromJsonAsync<List<NganhDTO>>(url);
            return result;
        }

        public async Task<bool> UpdateNganh(Guid id, NganhUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/nganhs/{id}", request);
            return result.IsSuccessStatusCode;
        }
    }
}
