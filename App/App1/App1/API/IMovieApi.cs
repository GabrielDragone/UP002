using App1.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.API
{
    public interface IMovieApi
    {
        [Get("/movie/upcoming?api_key={apiKey}")]
        Task<UpcomingResponse> GetUpcoming(string apiKey);
    }
}
