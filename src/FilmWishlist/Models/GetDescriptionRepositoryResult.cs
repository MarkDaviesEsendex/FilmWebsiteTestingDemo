namespace FilmWishlist.Models
{
    public class GetDescriptionRepositoryResult
    {
        public RepositoryResult Result { get; set; }
        public APIFilm Film { get; set; }
    }

    public class APIFilm
    {
        public APIFilm(string description, string posterUrl)
        {
            Description = description;
            PosterUrl = posterUrl;
        }

        public string PosterUrl { get; set; }
        public string Description { get; set; }

    }
}