using QLSV.Model;
using QLSV.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public interface ILopApiClient
    {
        Task<List<LopDTO>> GetLopList(LopSearch lopSearch);
        Task<LopDTO> GetLopDetail(string id);
        Task<bool> CreateLop(LopCreateRequest request);
        Task<bool> UpdateLop(Guid id, LopUpdateRequest request);
        Task<bool> DeleteLop(Guid id);
    }
}
