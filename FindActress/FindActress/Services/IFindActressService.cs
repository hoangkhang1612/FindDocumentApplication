using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FindActress.Models;

namespace FindActress.Services
{
    public interface IFindActressService
    {
        Task<ApiResponse<IEnumerable<Actress>>> GetActresses(string name);
    }
}
