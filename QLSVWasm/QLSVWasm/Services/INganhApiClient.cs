using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public interface INganhApiClient
    {
        Task<List<NganhDTO>> GetNganhList(NganhSearch nganhSearch);
        Task<NganhDTO> GetNganhDetail(string id);
        Task<bool> CreateNganh(NganhCreateRequest request);
        Task<bool> UpdateNganh(Guid id, NganhUpdateRequest request);
    }
}
