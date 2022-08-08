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
    public class DiemApiClient : IDiemApiClient
    {
        public HttpClient _httpClient;

        public DiemApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateDiem(DiemCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/diems", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteDiem(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/diems/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<DiemDTO> GetDiemDetail(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<DiemDTO>($"/api/diems/{id}");
            return result;
        }

        public async Task<List<DiemDTO>> GetDiemList(DiemSearch diemSearch)
        {
            string url = $"/api/diems?hocky={diemSearch.HocKy}";
            var result = await _httpClient.GetFromJsonAsync<List<DiemDTO>>(url);
            return result;
        }

        public async Task<bool> UpdateDiem(Guid id, DiemUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/diems/{id}", request);
            return result.IsSuccessStatusCode;
        }
    }
}
