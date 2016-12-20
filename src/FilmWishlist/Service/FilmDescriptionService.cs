using FilmWishlist.Models;
using FilmWishlist.Repositories;

namespace FilmWishlist.Service
{
    public class FilmDescriptionService : IFilmDescriptionService
    {
        private readonly IFilmDescriptionRepository _repository;

        public FilmDescriptionService(IFilmDescriptionRepository repository)
        {
            _repository = repository;
        }

        public APIFilm GetFilm(string title, string year) => Film(_repository.GetDescriptionResult(title, year));

        private static APIFilm Film(GetDescriptionRepositoryResult result) =>
            result.Result == RepositoryResult.Failed
                ? new APIFilm("No description found.", "No Poster Found")
                : result.Film;
    }
}