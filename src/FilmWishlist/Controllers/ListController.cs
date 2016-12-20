using System.Web.Mvc;
using System.Web.UI.WebControls;
using FilmWishlist.Models;
using FilmWishlist.Service;

namespace FilmWishlist.Controllers
{
    public class ListController : Controller
    {
        private readonly IAddFilmService _addFilmService;

        public ListController(IAddFilmService addFilmService)
        {
            _addFilmService = addFilmService;
        }

        [Route("~/list")]
        public ActionResult Index(string status) => View(new HomePageViewModel
        {
            FilmListViewModel = new FilmListViewModel
            {
                Films = _addFilmService.GetWishlist()
            }
        });
    }
}