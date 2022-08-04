using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public interface IMonHocApiClient
    {
        Task<List<MonHocDTO>> GetMonHocList(MonHocSearch monHocSearch);
        Task<MonHocDTO> GetMonHocDetail(string id);
        Task<bool> CreateMonHoc(MonHocCreateRequest request);
        Task<bool> UpdateMonHoc(Guid id, MonHocUpdateRequest request);
    }
}
