using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public interface IDiemApiClient
    {
        Task<List<DiemDTO>> GetDiemList(DiemSearch diemSearch);
        Task<DiemDTO> GetDiemDetail(string id);
        Task<bool> CreateDiem(DiemCreateRequest request);
        Task<bool> UpdateDiem(Guid id, DiemUpdateRequest request);
        Task<bool> DeleteDiem(Guid id);

    }
}
