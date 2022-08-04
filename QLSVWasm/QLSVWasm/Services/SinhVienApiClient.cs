﻿using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public class SinhVienApiClient : ISinhVienApiClient
    {
        public HttpClient _httpClient;

        public SinhVienApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateSV(SinhVienCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/sinhviens", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<SinhVienDTO> GetSVDetail(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<SinhVienDTO>($"/api/sinhviens/{id}");
            return result;
        }

        public async Task<List<SinhVienDTO>> GetSVList(SinhVienSearch sinhVienSearch)
        {
            string url = $"/api/sinhviens?tensinhvien={sinhVienSearch.TenSinhVien}&userId={sinhVienSearch.UserId}";
            var result = await _httpClient.GetFromJsonAsync<List<SinhVienDTO>>(url);
            return result;
        }

        public async Task<bool> UpdateSV(Guid id, SinhVienUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/sinhviens/{id}", request);
            return result.IsSuccessStatusCode;
        }
    }
}
