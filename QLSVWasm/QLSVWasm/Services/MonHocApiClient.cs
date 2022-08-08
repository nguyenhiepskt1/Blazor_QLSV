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
    public class MonHocApiClient : IMonHocApiClient
    {
        public HttpClient _httpClient;

        public MonHocApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateMonHoc(MonHocCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/monhocs", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteMonHoc(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/monhocs/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<MonHocDTO> GetMonHocDetail(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<MonHocDTO>($"/api/monhocs/{id}");
            return result;
        }

        public async Task<List<MonHocDTO>> GetMonHocList(MonHocSearch monHocSearch)
        {
            string url = $"/api/monhocs?tenmonhoc={monHocSearch.TenMonHoc}";
            var result = await _httpClient.GetFromJsonAsync<List<MonHocDTO>>(url);
            return result;
        }

        public async Task<bool> UpdateMonHoc(Guid id, MonHocUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/monhocs/{id}", request);
            return result.IsSuccessStatusCode;
        }
    }
}
