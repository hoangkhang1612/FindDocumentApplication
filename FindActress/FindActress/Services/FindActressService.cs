using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FindActress.Helpers;
using FindActress.Models;

namespace FindActress.Services
{
    public class FindActressService : ApiServiceBase, IFindActressService
    {
        public async Task<ApiResponse<IEnumerable<Actress>>> GetActresses(string name)
        {
            return await GetWithOptionsAsync<IEnumerable<Actress>>($"{Constants.LinkActressPath}{name}");
        }
    }
}
