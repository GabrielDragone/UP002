using App1.Models;
using App1.Repositories;
using System;
using System.Collections.Generic; //Habilita usar o tipo List
using System.Text;
using System.Threading.Tasks; //Habilita usar o tipo Task

namespace App1.Services
{
    public interface IMovieService
    {
        Task<(string erro, List<Movie>)> GetUpcoming();
    }

    public sealed class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;
        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public Task<(string erro, List<Movie>)> GetUpcoming()
            => movieRepository.GetUpcoming();
    }


    /*await Task.Delay(2000);

    return new List<Item>
    {
        Item.Create("Pikachu", "Rato elétrico", "http://vectorlogofree.com/wp-content/uploads/2013/04/pokemon-anime-vector-400x400.png"),
        Item.Create("Blastoise", "Tartaruga que solta agua", "https://i.pinimg.com/originals/78/bf/2c/78bf2c5d8dca6142f832a5e9d94e2235.png"),
        Item.Create("Sandshrew", "Tatu de areia", "http://assets.stickpng.com/thumbs/585965614f6ae202fedf2868.png"),
    };*/

}

