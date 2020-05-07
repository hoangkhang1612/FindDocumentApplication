using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FindActress.Helpers;
using FindActress.Models;

namespace FindActress.Services
{
    public class FindMoviesService : ApiServiceBase, IFindMoviesService
    {
        public async Task<ApiResponse<IEnumerable<Movie>>> GetMovies(string actressId)
        {
            return await GetWithOptionsAsync<IEnumerable<Movie>>($"{Constants.LinkMoviesPath}/{actressId}");
        }
    }
}
