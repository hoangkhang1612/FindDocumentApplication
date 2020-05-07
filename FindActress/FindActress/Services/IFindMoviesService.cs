using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FindActress.Models;

namespace FindActress.Services
{
    public interface IFindMoviesService
    {
        Task<ApiResponse<IEnumerable<Movie>>> GetMovies(string actressId);

    }
}
