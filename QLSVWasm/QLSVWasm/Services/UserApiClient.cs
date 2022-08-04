using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public class UserApiClient : IUserApiClient
    {
        public HttpClient _httpClient;

        public UserApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            var result = await _httpClient.GetFromJsonAsync<List<UserDTO>>($"/api/users");
            return result;
        }
    }
}
