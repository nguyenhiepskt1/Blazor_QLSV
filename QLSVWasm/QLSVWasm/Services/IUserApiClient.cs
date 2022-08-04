using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSVWasm.Services
{
    public interface IUserApiClient
    {
        Task<List<UserDTO>> GetUsers();
    }
}
