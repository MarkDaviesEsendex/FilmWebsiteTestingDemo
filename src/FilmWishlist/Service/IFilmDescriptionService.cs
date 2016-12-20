using FilmWishlist.Models;

namespace FilmWishlist.Service
{
    public interface IFilmDescriptionService
    {
        APIFilm GetFilm(string title, string year);
    }
}