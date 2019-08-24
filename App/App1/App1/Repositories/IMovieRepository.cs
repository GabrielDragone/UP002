using App1.API;
using App1.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Repositories
{
    public interface IMovieRepository
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }

}
